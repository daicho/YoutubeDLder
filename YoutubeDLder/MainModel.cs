using Reactive.Bindings;
using System.Diagnostics;
using System.Reflection;

namespace YoutubeDLder;

/// <summary>
/// メイン画面のモデル
/// </summary>
public class MainModel
{
    /// <summary>設定</summary>
    public ReactiveProperty<Setting> Setting { get; } = new(new Setting());

    /// <summary>バージョン</summary>
    public ReactiveProperty<string> Version { get; } = new("");

    /// <summary>ダウンロードする動画一覧</summary>
    public ReactiveProperty<string> VideoList { get; } = new("");

    /// <summary>コンソール出力</summary>
    public ReactiveProperty<string> Console { get; } = new("");

    /// <summary>音量調整前 保存先</summary>
    public ReactiveProperty<string> SaveDirectory { get; } = new("");

    /// <summary>音量調整後 保存先</summary>
    public ReactiveProperty<string> AdjustedDirectory { get; } = new("");

    /// <summary>処理中か</summary>
    public ReactiveProperty<bool> IsProcessing { get; } = new(false);

    /// <summary>キャンセルトークン</summary>
    private CancellationTokenSource _cancellationTokenSource = new();

    /// <summary>
    /// 初期化する
    /// </summary>
    public void Initialize()
    {
        // 設定を読み込み
        Setting.Value = YoutubeDLder.Setting.Load();

        SaveDirectory.Value = Setting.Value.SaveDirectory;
        AdjustedDirectory.Value = Setting.Value.AdjustedDirectory;

        // バージョンを取得
        Version.Value = Assembly.GetEntryAssembly()!.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion;
    }

    /// <summary>
    /// 終了する
    /// </summary>
    public void Exit()
    {
        // 処理を中断
        Interrupt();

        // 設定を保存
        Setting setting = YoutubeDLder.Setting.Load();

        setting.SaveDirectory = SaveDirectory.Value;
        setting.AdjustedDirectory = AdjustedDirectory.Value;

        setting.Save();
    }

    /// <summary>
    /// ダウンロードを実行する
    /// </summary>
    public async Task Download()
    {
        // 処理中だったら終了
        if (IsProcessing.Value)
        {
            return;
        }

        // キャンセルトークンを初期化
        _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = _cancellationTokenSource.Token;

        Console.Value = "";
        IsProcessing.Value = true;

        try
        {
            string[] videos = VideoList.Value.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < videos.Length; i++)
            {
                string video = videos[i];

                cancellationToken.ThrowIfCancellationRequested();

                // [済]から始まっていたらスキップ
                if (video.StartsWith("[済] "))
                {
                    continue;
                }

                // コマンドを作成
                string arguments = "";

                if (video.StartsWith("http"))
                {
                    // URL指定
                    arguments += $"\"{video}\" ";
                }
                else
                {
                    // キーワード検索
                    arguments += $"\"ytsearch1:{video.Replace("-", "")}\" --no-playlist --max-downloads 1 ";
                }

                // 動画フォーマット
                arguments += "-f \"";

                if (Setting.Value.DownloadsVideo)
                {
                    arguments += "bestvideo";

                    if (!string.IsNullOrWhiteSpace(Setting.Value.VideoCodec))
                    {
                        arguments += $"[vcodec^={Setting.Value.VideoCodec}]";
                    }

                    if (!string.IsNullOrWhiteSpace(Setting.Value.MaxWidth))
                    {
                        arguments += $"[width<={Setting.Value.MaxWidth}]";
                    }

                    if (!string.IsNullOrWhiteSpace(Setting.Value.MaxHeight))
                    {
                        arguments += $"[height<={Setting.Value.MaxHeight}]";
                    }
                }

                // 音声フォーマット
                if (Setting.Value.DownloadsVideo && Setting.Value.DownloadsAudio)
                {
                    arguments += "+";
                }

                if (Setting.Value.DownloadsAudio)
                {
                    arguments += "bestaudio";

                    if (!string.IsNullOrWhiteSpace(Setting.Value.AudioCodec))
                    {
                        arguments += $"[acodec^={Setting.Value.AudioCodec}]";
                    }
                }

                arguments += "\" ";
                arguments += $"--merge-output-format {Setting.Value.Extension} ";

                // Cookie
                if (!string.IsNullOrWhiteSpace(Setting.Value.CookiesPath))
                {
                    arguments += $"--cookies \"{Setting.Value.CookiesPath}\" ";
                }

                arguments += $"-o {Path.Combine(SaveDirectory.Value, "%(title)s.%(ext)s")}";

                // コンソールに実行コマンドを出力
                Console.Value += $"> yt-dlp {arguments}{Environment.NewLine}";

                // コマンドを実行
                using Process process = new();

                process.StartInfo = new ProcessStartInfo("yt-dlp", arguments)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };

                process.EnableRaisingEvents = true; 
                process.OutputDataReceived += (s, e) => Console.Value += $"{e.Data}{Environment.NewLine}";
                process.ErrorDataReceived += (s, e) => Console.Value += $"{e.Data}{Environment.NewLine}";

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // 終了まで待機
                await process.WaitForExitAsync(cancellationToken);

                // 成功したら[済]を付ける
                if (process.ExitCode == 0)
                {
                    videos[i] = $"[済] {video}";
                    VideoList.Value = string.Join(Environment.NewLine, videos);
                }
            }
        }
        catch (OperationCanceledException)
        {
            // キャンセルされた場合は何もしない
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.GetType().FullName}\n{ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            IsProcessing.Value = false;
        }
    }

    /// <summary>
    /// 音量を調整する
    /// </summary>
    public async Task AdjustVolume()
    {
        // 処理中だったら終了
        if (IsProcessing.Value)
        {
            return;
        }

        // キャンセルトークンを初期化
        _cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = _cancellationTokenSource.Token;

        Console.Value = "";
        IsProcessing.Value = true;

        try
        {
            // 出力先ディレクトリがなければ作成
            if (!Directory.Exists(AdjustedDirectory.Value))
            {
                Directory.CreateDirectory(AdjustedDirectory.Value);
            }

            // SaveDirectory.Value 内の全ファイルを列挙
            string[] inputPaths = Directory.GetFiles(SaveDirectory.Value);

            foreach (string inputPath in inputPaths)
            {
                cancellationToken.ThrowIfCancellationRequested();

                // 出力ファイルパス
                string outputPath = Path.Combine(AdjustedDirectory.Value, Path.GetFileName(inputPath));

                // コマンドを作成
                string arguments = $"-i \"{inputPath}\" -y -af \"dynaudnorm";

                bool hasOption = new[]
                {
                    Setting.Value.FrameLength,
                    Setting.Value.GaussSize,
                    Setting.Value.PeakLevel,
                    Setting.Value.MaxGain,
                }.Any(option => !string.IsNullOrWhiteSpace(option));

                if (hasOption)
                {
                    arguments += "=";
                }

                List<string> options = new();

                if (!string.IsNullOrWhiteSpace(Setting.Value.FrameLength))
                {
                    options.Add($"framelen={Setting.Value.FrameLength}");
                }

                if (!string.IsNullOrWhiteSpace(Setting.Value.GaussSize))
                {
                    options.Add($"gausssize={Setting.Value.GaussSize}");
                }

                if (!string.IsNullOrWhiteSpace(Setting.Value.PeakLevel))
                {
                    options.Add($"peak={Setting.Value.PeakLevel}");
                }

                if (!string.IsNullOrWhiteSpace(Setting.Value.MaxGain))
                {
                    options.Add($"maxgain={Setting.Value.MaxGain}");
                }

                arguments += $"{string.Join(":", options)}\" -c:v copy -c:a aac ";

                if (!string.IsNullOrWhiteSpace(Setting.Value.AudioBitrate))
                {
                    arguments += $"-b:a {Setting.Value.AudioBitrate} ";
                }

                arguments += $"\"{outputPath}\"";

                // コンソールに実行コマンドを出力
                Console.Value += $"> ffmpeg {arguments}{Environment.NewLine}";

                // コマンドを実行
                using Process process = new();

                process.StartInfo = new ProcessStartInfo("ffmpeg", arguments)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };

                process.EnableRaisingEvents = true;
                process.OutputDataReceived += (s, e) => Console.Value += $"{e.Data}{Environment.NewLine}";
                process.ErrorDataReceived += (s, e) => Console.Value += $"{e.Data}{Environment.NewLine}";

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // 終了まで待機
                await process.WaitForExitAsync(cancellationToken);
            }
        }
        catch (OperationCanceledException)
        {
            // キャンセルされた場合は何もしない
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.GetType().FullName}\n{ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            IsProcessing.Value = false;
        }
    }

    /// <summary>
    /// ダウンロードを中断する
    /// </summary>
    public void Interrupt()
    {
        _cancellationTokenSource.Cancel();
    }

    /// <summary>
    /// 設定を表示する
    /// </summary>
    public void ShowSetting()
    {
        using var form = new SettingForm();
        form.ShowDialog();

        Setting.Value = YoutubeDLder.Setting.Load();
    }

    /// <summary>
    /// 音量調整前 保存先を選択する
    /// </summary>
    public void SelectSaveDirectory()
    {
        using var dialog = new FolderBrowserDialog()
        {
            SelectedPath = SaveDirectory.Value,
            ShowNewFolderButton = true,
        };

        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        SaveDirectory.Value = dialog.SelectedPath;
    }

    /// <summary>
    /// 音量調整後 保存先を選択する
    /// </summary>
    public void SelectAdjustedDirectory()
    {
        using var dialog = new FolderBrowserDialog()
        {
            SelectedPath = AdjustedDirectory.Value,
            ShowNewFolderButton = true,
        };

        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        AdjustedDirectory.Value = dialog.SelectedPath;
    }
}
