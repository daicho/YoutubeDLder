namespace YoutubeDLder;

/// <summary>
/// 設定画面
/// </summary>
public partial class SettingForm : Form
{
    /// <summary>モデル</summary>
    private readonly SettingModel _model = new();

    public SettingForm()
    {
        InitializeComponent();

        // バインディング
        cookiesPathText.DataBindings.Add("Text", _model.CookiesPath, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        extensionText.DataBindings.Add("Text", _model.Extension, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        videoCodecText.DataBindings.Add("Text", _model.VideoCodec, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        audioCodecText.DataBindings.Add("Text", _model.AudioCodec, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        maxWidthText.DataBindings.Add("Text", _model.MaxWidth, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        maxHeightText.DataBindings.Add("Text", _model.MaxHeight, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        downloadsVideoCheck.DataBindings.Add("Checked", _model.DownloadsVideo, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        downloadsAudioCheck.DataBindings.Add("Checked", _model.DownloadsAudio, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        audioBitrateText.DataBindings.Add("Text", _model.AudioBitrate, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        frameLengthText.DataBindings.Add("Text", _model.FrameLength, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        gaussSizeText.DataBindings.Add("Text", _model.GaussSize, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        peakLevelText.DataBindings.Add("Text", _model.PeakLevel, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        maxGainText.DataBindings.Add("Text", _model.MaxGain, "Value", false, DataSourceUpdateMode.OnPropertyChanged);

        // クリックイベント
        selectCookiesPathButton.Click += (s, e) => _model.SelectCookiesPath();
        installYtDlpButton.Click += (s, e) => _model.InstallYtDlp();
        installFfmpegButton.Click += (s, e) => _model.InstallFfmpeg();
    }

    // フォーム起動
    private void SettingForm_Load(object sender, EventArgs e)
    {
        _model.Initialize();
    }

    // 保存ボタンクリック
    private void saveButton_Click(object sender, EventArgs e)
    {
        _model.Save();
        this.Close();
    }

    // キャンセルボタンクリック
    private void cancelButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
