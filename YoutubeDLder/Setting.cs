using System.Text;
using System.Xml.Serialization;

namespace YoutubeDLder;

/// <summary>
/// 設定
/// </summary>
public class Setting
{
    /// <summary>音量調整前 保存先</summary>
    public string SaveDirectory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "YoutubeDLder");

    /// <summary>音量調整後 保存先</summary>
    public string AdjustedDirectory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "YoutubeDLder_音量調整後");

    /// <summary>Cookieパス</summary>
    public string CookiesPath { get; set; } = "";

    /// <summary>拡張子</summary>
    public string Extension { get; set; } = "mp4";

    /// <summary>動画コーデック</summary>
    public string VideoCodec { get; set; } = "avc1";

    /// <summary>音声コーデック</summary>
    public string AudioCodec { get; set; } = "mp4a";

    /// <summary>最大幅</summary>
    public string MaxWidth { get; set; } = "1920";

    /// <summary>最大高さ</summary>
    public string MaxHeight { get; set; } = "1080";

    /// <summary>動画をダウンロードするか</summary>
    public bool DownloadsVideo { get; set; } = true;

    /// <summary>音声をダウンロードするか</summary>
    public bool DownloadsAudio { get; set; } = true;

    /// <summary>音声ビットレート</summary>
    public string AudioBitrate { get; set; } = "128k";

    /// <summary>フレーム長</summary>
    public string FrameLength { get; set; } = "500";

    /// <summary>ガウシアンフィルタサイズ</summary>
    public string GaussSize { get; set; } = "31";

    /// <summary>ピークレベル</summary>
    public string PeakLevel { get; set; } = "0.95";

    /// <summary>最大ゲイン</summary>
    public string MaxGain { get; set; } = "10";

    /// <summary>
    /// 設定を読み込む
    /// </summary>
    /// <returns>読み込んだ設定</returns>
    public static Setting Load()
    {
        if (!File.Exists(SettingModel.SettingPath))
        {
            return new Setting();
        }

        // デシリアライズして読み込み
        using StreamReader reader = new(SettingModel.SettingPath, Encoding.UTF8);
        XmlSerializer serializer = new(typeof(Setting));
        return (Setting)serializer.Deserialize(reader)!;
    }

    /// <summary>
    /// 設定を保存する
    /// </summary>
    public void Save()
    {
        // シリアライズして保存
        using StreamWriter writer = new(SettingModel.SettingPath, false, Encoding.UTF8);
        XmlSerializer serializer = new(typeof(Setting));
        serializer.Serialize(writer, this);
    }
}
