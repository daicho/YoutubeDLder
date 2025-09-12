namespace YoutubeDLder
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            extensionText = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            label2 = new Label();
            videoCodecText = new TextBox();
            label4 = new Label();
            maxWidthText = new TextBox();
            label5 = new Label();
            maxHeightText = new TextBox();
            label6 = new Label();
            frameLengthText = new TextBox();
            label7 = new Label();
            gaussSizeText = new TextBox();
            label8 = new Label();
            peakLevelText = new TextBox();
            installYtDlpButton = new Button();
            installFfmpegButton = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            selectCookiesPathButton = new Button();
            downloadsAudioCheck = new CheckBox();
            cookiesPathText = new TextBox();
            downloadsVideoCheck = new CheckBox();
            label3 = new Label();
            audioCodecText = new TextBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            label11 = new Label();
            maxGainText = new TextBox();
            audioBitrateText = new TextBox();
            groupBox4 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(16, 56);
            label1.Name = "label1";
            label1.Size = new Size(80, 24);
            label1.TabIndex = 3;
            label1.Text = "拡張子";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // extensionText
            // 
            extensionText.Location = new Point(104, 56);
            extensionText.Margin = new Padding(3, 2, 3, 2);
            extensionText.Name = "extensionText";
            extensionText.Size = new Size(104, 23);
            extensionText.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(255, 255, 192);
            saveButton.Location = new Point(8, 512);
            saveButton.Margin = new Padding(3, 2, 3, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(216, 32);
            saveButton.TabIndex = 4;
            saveButton.Text = "保存";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(232, 512);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(216, 32);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "キャンセル";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label2
            // 
            label2.Location = new Point(16, 120);
            label2.Name = "label2";
            label2.Size = new Size(80, 24);
            label2.TabIndex = 6;
            label2.Text = "動画コーデック";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // videoCodecText
            // 
            videoCodecText.Location = new Point(104, 120);
            videoCodecText.Margin = new Padding(3, 2, 3, 2);
            videoCodecText.Name = "videoCodecText";
            videoCodecText.Size = new Size(104, 23);
            videoCodecText.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(16, 152);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 8;
            label4.Text = "最大幅";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maxWidthText
            // 
            maxWidthText.Location = new Point(104, 152);
            maxWidthText.Margin = new Padding(3, 2, 3, 2);
            maxWidthText.Name = "maxWidthText";
            maxWidthText.Size = new Size(104, 23);
            maxWidthText.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(232, 152);
            label5.Name = "label5";
            label5.Size = new Size(80, 24);
            label5.TabIndex = 10;
            label5.Text = "最大高さ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maxHeightText
            // 
            maxHeightText.Location = new Point(320, 152);
            maxHeightText.Margin = new Padding(3, 2, 3, 2);
            maxHeightText.Name = "maxHeightText";
            maxHeightText.Size = new Size(104, 23);
            maxHeightText.TabIndex = 11;
            // 
            // label6
            // 
            label6.Location = new Point(16, 56);
            label6.Name = "label6";
            label6.Size = new Size(80, 24);
            label6.TabIndex = 3;
            label6.Text = "framelen";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frameLengthText
            // 
            frameLengthText.Location = new Point(104, 56);
            frameLengthText.Margin = new Padding(3, 2, 3, 2);
            frameLengthText.Name = "frameLengthText";
            frameLengthText.Size = new Size(104, 23);
            frameLengthText.TabIndex = 4;
            // 
            // label7
            // 
            label7.Location = new Point(232, 56);
            label7.Name = "label7";
            label7.Size = new Size(80, 24);
            label7.TabIndex = 5;
            label7.Text = "gausssize";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gaussSizeText
            // 
            gaussSizeText.Location = new Point(320, 56);
            gaussSizeText.Margin = new Padding(3, 2, 3, 2);
            gaussSizeText.Name = "gaussSizeText";
            gaussSizeText.Size = new Size(104, 23);
            gaussSizeText.TabIndex = 6;
            // 
            // label8
            // 
            label8.Location = new Point(16, 88);
            label8.Name = "label8";
            label8.Size = new Size(80, 24);
            label8.TabIndex = 7;
            label8.Text = "peak";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // peakLevelText
            // 
            peakLevelText.Location = new Point(104, 88);
            peakLevelText.Margin = new Padding(3, 2, 3, 2);
            peakLevelText.Name = "peakLevelText";
            peakLevelText.Size = new Size(104, 23);
            peakLevelText.TabIndex = 8;
            // 
            // installYtDlpButton
            // 
            installYtDlpButton.Location = new Point(16, 24);
            installYtDlpButton.Margin = new Padding(3, 2, 3, 2);
            installYtDlpButton.Name = "installYtDlpButton";
            installYtDlpButton.Size = new Size(199, 32);
            installYtDlpButton.TabIndex = 0;
            installYtDlpButton.Text = "yt-dlp インストール";
            installYtDlpButton.UseVisualStyleBackColor = true;
            // 
            // installFfmpegButton
            // 
            installFfmpegButton.Location = new Point(224, 24);
            installFfmpegButton.Margin = new Padding(3, 2, 3, 2);
            installFfmpegButton.Name = "installFfmpegButton";
            installFfmpegButton.Size = new Size(199, 32);
            installFfmpegButton.TabIndex = 1;
            installFfmpegButton.Text = "ffmpeg インストール";
            installFfmpegButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(selectCookiesPathButton);
            groupBox2.Controls.Add(downloadsAudioCheck);
            groupBox2.Controls.Add(cookiesPathText);
            groupBox2.Controls.Add(downloadsVideoCheck);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(extensionText);
            groupBox2.Controls.Add(maxHeightText);
            groupBox2.Controls.Add(videoCodecText);
            groupBox2.Controls.Add(maxWidthText);
            groupBox2.Controls.Add(audioCodecText);
            groupBox2.Location = new Point(8, 8);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(440, 256);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "yt-dlp設定";
            // 
            // label9
            // 
            label9.Location = new Point(16, 24);
            label9.Name = "label9";
            label9.Size = new Size(80, 24);
            label9.TabIndex = 0;
            label9.Text = "Cookies";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectCookiesPathButton
            // 
            selectCookiesPathButton.Location = new Point(400, 24);
            selectCookiesPathButton.Margin = new Padding(3, 2, 3, 2);
            selectCookiesPathButton.Name = "selectCookiesPathButton";
            selectCookiesPathButton.Size = new Size(24, 24);
            selectCookiesPathButton.TabIndex = 2;
            selectCookiesPathButton.Text = "...";
            selectCookiesPathButton.UseVisualStyleBackColor = true;
            // 
            // downloadsAudioCheck
            // 
            downloadsAudioCheck.Location = new Point(16, 184);
            downloadsAudioCheck.Margin = new Padding(3, 2, 3, 2);
            downloadsAudioCheck.Name = "downloadsAudioCheck";
            downloadsAudioCheck.Size = new Size(192, 24);
            downloadsAudioCheck.TabIndex = 12;
            downloadsAudioCheck.Text = "音声をダウンロードする";
            downloadsAudioCheck.UseVisualStyleBackColor = true;
            // 
            // cookiesPathText
            // 
            cookiesPathText.Location = new Point(104, 24);
            cookiesPathText.Margin = new Padding(3, 2, 3, 2);
            cookiesPathText.Name = "cookiesPathText";
            cookiesPathText.Size = new Size(288, 23);
            cookiesPathText.TabIndex = 1;
            // 
            // downloadsVideoCheck
            // 
            downloadsVideoCheck.Location = new Point(16, 88);
            downloadsVideoCheck.Margin = new Padding(3, 2, 3, 2);
            downloadsVideoCheck.Name = "downloadsVideoCheck";
            downloadsVideoCheck.Size = new Size(192, 24);
            downloadsVideoCheck.TabIndex = 5;
            downloadsVideoCheck.Text = "動画をダウンロードする";
            downloadsVideoCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Location = new Point(16, 216);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 13;
            label3.Text = "音声コーデック";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // audioCodecText
            // 
            audioCodecText.Location = new Point(104, 216);
            audioCodecText.Margin = new Padding(3, 2, 3, 2);
            audioCodecText.Name = "audioCodecText";
            audioCodecText.Size = new Size(104, 23);
            audioCodecText.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(maxGainText);
            groupBox3.Controls.Add(audioBitrateText);
            groupBox3.Controls.Add(gaussSizeText);
            groupBox3.Controls.Add(peakLevelText);
            groupBox3.Controls.Add(frameLengthText);
            groupBox3.Location = new Point(8, 280);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(440, 128);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "ffmpeg設定";
            // 
            // label10
            // 
            label10.Location = new Point(232, 88);
            label10.Name = "label10";
            label10.Size = new Size(80, 24);
            label10.TabIndex = 9;
            label10.Text = "maxgain";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Location = new Point(16, 24);
            label11.Name = "label11";
            label11.Size = new Size(80, 24);
            label11.TabIndex = 1;
            label11.Text = "ビットレート";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // maxGainText
            // 
            maxGainText.Location = new Point(320, 88);
            maxGainText.Margin = new Padding(3, 2, 3, 2);
            maxGainText.Name = "maxGainText";
            maxGainText.Size = new Size(104, 23);
            maxGainText.TabIndex = 10;
            // 
            // audioBitrateText
            // 
            audioBitrateText.Location = new Point(104, 24);
            audioBitrateText.Margin = new Padding(3, 2, 3, 2);
            audioBitrateText.Name = "audioBitrateText";
            audioBitrateText.Size = new Size(104, 23);
            audioBitrateText.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(installYtDlpButton);
            groupBox4.Controls.Add(installFfmpegButton);
            groupBox4.Location = new Point(8, 424);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(440, 72);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "インストール";
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 552);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SettingForm";
            Text = "設定";
            Load += SettingForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private TextBox extensionText;
        private Button saveButton;
        private Button cancelButton;
        private Label label2;
        private TextBox videoCodecText;
        private Label label4;
        private TextBox maxWidthText;
        private Label label5;
        private TextBox maxHeightText;
        private Label label6;
        private TextBox frameLengthText;
        private Label label7;
        private TextBox gaussSizeText;
        private Label label8;
        private TextBox peakLevelText;
        private Button installYtDlpButton;
        private Button installFfmpegButton;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox audioCodecText;
        private CheckBox downloadsAudioCheck;
        private CheckBox downloadsVideoCheck;
        private Label label9;
        private Button selectCookiesPathButton;
        private TextBox cookiesPathText;
        private Label label10;
        private TextBox maxGainText;
        private Label label11;
        private TextBox audioBitrateText;
    }
}