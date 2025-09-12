using Reactive.Bindings;
using System.Diagnostics;
using System.Reflection;

namespace YoutubeDLder;

/// <summary>
/// 設定画面のモデル
/// </summary>
public class SettingModel
{
    /// <summary>設定のパス</summary>
    public const string SettingPath = "setting.xml";

    /// <summary>音量調整前 保存先</summary>
    public ReactiveProperty<string> SaveDirectory { get; } = new("");

    /// <summary>音量調整後 保存先</summary>
    public ReactiveProperty<string> AdjustedDirectory { get; } = new("");

    /// <summary>Cookieパス</summary>
    public ReactiveProperty<string> CookiesPath { get; set; } = new("");

    /// <summary>拡張子</summary>
    public ReactiveProperty<string> Extension { get; } = new("");

    /// <summary>動画コーデック</summary>
    public ReactiveProperty<string> VideoCodec { get; } = new("");

    /// <summary>音声コーデック</summary>
    public ReactiveProperty<string> AudioCodec { get; } = new("");

    /// <summary>最大幅</summary>
    public ReactiveProperty<string> MaxWidth { get; } = new("");

    /// <summary>最大高さ</summary>
    public ReactiveProperty<string> MaxHeight { get; } = new("");

    /// <summary>動画をダウンロードするか</summary>
    public ReactiveProperty<bool> DownloadsVideo { get; set; } = new();

    /// <summary>音声をダウンロードするか</summary>
    public ReactiveProperty<bool> DownloadsAudio { get; set; } = new();

    /// <summary>音量を調整するか</summary>
    public ReactiveProperty<bool> AdjustsVolume { get; } = new();

    /// <summary>音声ビットレート</summary>
    public ReactiveProperty<string> AudioBitrate { get; set; } = new("");

    /// <summary>フレーム長</summary>
    public ReactiveProperty<string> FrameLength { get; } = new("");

    /// <summary>ガウシアンフィルタサイズ</summary>
    public ReactiveProperty<string> GaussSize { get; } = new("");

    /// <summary>ピークレベル</summary>
    public ReactiveProperty<string> PeakLevel { get; } = new("");

    /// <summary>最大ゲイン</summary>
    public ReactiveProperty<string> MaxGain { get; set; } = new("");

    /// <summary>
    /// 初期化する
    /// </summary>
    public void Initialize()
    {
        Setting setting = Setting.Load();

        SaveDirectory.Value = setting.SaveDirectory;
        AdjustedDirectory.Value = setting.AdjustedDirectory;
        CookiesPath.Value = setting.CookiesPath;
        Extension.Value = setting.Extension;
        VideoCodec.Value = setting.VideoCodec;
        AudioCodec.Value = setting.AudioCodec;
        MaxWidth.Value = setting.MaxWidth;
        MaxHeight.Value = setting.MaxHeight;
        DownloadsVideo.Value = setting.DownloadsVideo;
        DownloadsAudio.Value = setting.DownloadsAudio;
        AudioBitrate.Value = setting.AudioBitrate;
        FrameLength.Value = setting.FrameLength;
        GaussSize.Value = setting.GaussSize;
        PeakLevel.Value = setting.PeakLevel;
        MaxGain.Value = setting.MaxGain;
    }

    /// <summary>
    /// 保存する
    /// </summary>
    public void Save()
    {
        Setting setting = new()
        {
            SaveDirectory = SaveDirectory.Value,
            AdjustedDirectory = AdjustedDirectory.Value,
            CookiesPath = CookiesPath.Value,
            Extension = Extension.Value,
            VideoCodec = VideoCodec.Value,
            AudioCodec = AudioCodec.Value,
            MaxWidth = MaxWidth.Value,
            MaxHeight = MaxHeight.Value,
            DownloadsVideo = DownloadsVideo.Value,
            DownloadsAudio = DownloadsAudio.Value,
            AudioBitrate = AudioBitrate.Value,
            FrameLength = FrameLength.Value,
            GaussSize = GaussSize.Value,
            PeakLevel = PeakLevel.Value,
            MaxGain = MaxGain.Value,
        };

        setting.Save();
    }

    /// <summary>
    /// Cookieパスを選択する
    /// </summary>
    public void SelectCookiesPath()
    {
        using OpenFileDialog dialog = new()
        {
            InitialDirectory = Path.GetDirectoryName(CookiesPath.Value),
        };

        if (dialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        CookiesPath.Value = dialog.FileName;
    }

    /// <summary>
    /// yt-dlpをインストールする
    /// </summary>
    public void InstallYtDlp()
    {
        using Process process = new();

        process.StartInfo = new ProcessStartInfo()
        {
            FileName = "winget",
            Arguments = "install yt-dlp",
            UseShellExecute = true,
        };

        process.Start();
    }

    /// <summary>
    /// ffmpegをインストールする
    /// </summary>
    public void InstallFfmpeg()
    {
        using Process process = new();

        process.StartInfo = new ProcessStartInfo()
        {
            FileName = "winget",
            Arguments = "install ffmpeg",
            UseShellExecute = true,
        };

        process.Start();
    }
}
