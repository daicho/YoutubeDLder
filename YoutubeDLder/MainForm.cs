using System.Reactive.Linq;

namespace YoutubeDLder;

/// <summary>
/// メイン画面
/// </summary>
public partial class MainForm : Form
{
    /// <summary>モデル</summary>
    private readonly MainModel _model = new();

    public MainForm()
    {
        InitializeComponent();

        // バインディング
        videoListText.DataBindings.Add("Text", _model.VideoList, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        videoListText.DataBindings.Add("ReadOnly", _model.IsProcessing, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        saveDirectoryText.DataBindings.Add("Text", _model.SaveDirectory, "Value", false, DataSourceUpdateMode.OnPropertyChanged);
        adjustedDirectoryText.DataBindings.Add("Text", _model.AdjustedDirectory, "Value", false, DataSourceUpdateMode.OnPropertyChanged);

        _model.Version.Subscribe(version =>
        {
            this.Text = $"YoutubeDLder {version}";
        });

        _model.IsProcessing.Subscribe(isProcessing =>
        {
            processingButtonsPanel.Visible = !isProcessing;
            interruptButton.Visible = isProcessing;
        });

        // イベント
        selectSaveDirectoryButton.Click += (s, e) => _model.SelectSaveDirectory();
        selectAdjustedDirectoryButton.Click += (s, e) => _model.SelectAdjustedDirectory();
        downloadButton.Click += async (s, e) => await _model.Download();
        adjustVolumeButton.Click += async (s, e) => await _model.AdjustVolume();
        interruptButton.Click += (s, e) => _model.Interrupt();
        showSettingButton.Click += (s, e) => _model.ShowSetting();
    }

    // フォーム起動
    private void MainForm_Load(object sender, EventArgs e)
    {
        _model.Console.Subscribe(console =>
        {
            this.Invoke(() =>
            {
                consoleText.Text = console;
                consoleText.SelectionStart = consoleText.Text.Length;
                consoleText.ScrollToCaret();
            });
        });

        _model.Initialize();
    }

    // フォーム終了
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _model.Exit();
    }
}
