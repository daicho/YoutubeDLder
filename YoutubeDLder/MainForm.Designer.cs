namespace YoutubeDLder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            videoListText = new TextBox();
            consoleText = new TextBox();
            downloadButton = new Button();
            showSettingButton = new Button();
            interruptButton = new Button();
            processingButtonsPanel = new TableLayoutPanel();
            adjustVolumeButton = new Button();
            label10 = new Label();
            selectAdjustedDirectoryButton = new Button();
            label9 = new Label();
            adjustedDirectoryText = new TextBox();
            selectSaveDirectoryButton = new Button();
            saveDirectoryText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            processingButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(8, 8);
            splitContainer1.Margin = new Padding(4, 2, 4, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(videoListText);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(consoleText);
            splitContainer1.Size = new Size(960, 536);
            splitContainer1.SplitterDistance = 499;
            splitContainer1.TabIndex = 0;
            // 
            // videoListText
            // 
            videoListText.Dock = DockStyle.Fill;
            videoListText.Location = new Point(0, 0);
            videoListText.Margin = new Padding(4, 2, 4, 2);
            videoListText.Multiline = true;
            videoListText.Name = "videoListText";
            videoListText.ScrollBars = ScrollBars.Both;
            videoListText.Size = new Size(499, 536);
            videoListText.TabIndex = 0;
            // 
            // consoleText
            // 
            consoleText.BackColor = Color.FromArgb(12, 12, 12);
            consoleText.Dock = DockStyle.Fill;
            consoleText.Font = new Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            consoleText.ForeColor = Color.FromArgb(224, 224, 224);
            consoleText.Location = new Point(0, 0);
            consoleText.Margin = new Padding(4, 2, 4, 2);
            consoleText.Multiline = true;
            consoleText.Name = "consoleText";
            consoleText.ReadOnly = true;
            consoleText.ScrollBars = ScrollBars.Both;
            consoleText.Size = new Size(457, 536);
            consoleText.TabIndex = 0;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = Color.FromArgb(255, 255, 192);
            downloadButton.Dock = DockStyle.Fill;
            downloadButton.Location = new Point(0, 0);
            downloadButton.Margin = new Padding(0, 0, 4, 0);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(408, 32);
            downloadButton.TabIndex = 2;
            downloadButton.Text = "ダウンロード";
            downloadButton.UseVisualStyleBackColor = false;
            // 
            // showSettingButton
            // 
            showSettingButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            showSettingButton.Location = new Point(8, 616);
            showSettingButton.Margin = new Padding(4, 2, 4, 2);
            showSettingButton.Name = "showSettingButton";
            showSettingButton.Size = new Size(128, 32);
            showSettingButton.TabIndex = 2;
            showSettingButton.Text = "設定";
            showSettingButton.UseVisualStyleBackColor = true;
            // 
            // interruptButton
            // 
            interruptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            interruptButton.BackColor = Color.FromArgb(255, 192, 192);
            interruptButton.Location = new Point(142, 616);
            interruptButton.Margin = new Padding(4, 2, 4, 2);
            interruptButton.Name = "interruptButton";
            interruptButton.Size = new Size(824, 32);
            interruptButton.TabIndex = 2;
            interruptButton.Text = "中断";
            interruptButton.UseVisualStyleBackColor = false;
            // 
            // processingButtonsPanel
            // 
            processingButtonsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            processingButtonsPanel.ColumnCount = 2;
            processingButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            processingButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            processingButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            processingButtonsPanel.Controls.Add(adjustVolumeButton, 1, 0);
            processingButtonsPanel.Controls.Add(downloadButton, 0, 0);
            processingButtonsPanel.Location = new Point(144, 616);
            processingButtonsPanel.Name = "processingButtonsPanel";
            processingButtonsPanel.RowCount = 1;
            processingButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            processingButtonsPanel.Size = new Size(824, 32);
            processingButtonsPanel.TabIndex = 3;
            // 
            // adjustVolumeButton
            // 
            adjustVolumeButton.BackColor = Color.FromArgb(255, 255, 192);
            adjustVolumeButton.Dock = DockStyle.Fill;
            adjustVolumeButton.Location = new Point(416, 0);
            adjustVolumeButton.Margin = new Padding(4, 0, 0, 0);
            adjustVolumeButton.Name = "adjustVolumeButton";
            adjustVolumeButton.Size = new Size(408, 32);
            adjustVolumeButton.TabIndex = 3;
            adjustVolumeButton.Text = "音量調整";
            adjustVolumeButton.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.Location = new Point(8, 584);
            label10.Name = "label10";
            label10.Size = new Size(80, 24);
            label10.TabIndex = 6;
            label10.Text = "音量調整後";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectAdjustedDirectoryButton
            // 
            selectAdjustedDirectoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAdjustedDirectoryButton.Location = new Point(944, 584);
            selectAdjustedDirectoryButton.Margin = new Padding(3, 2, 3, 2);
            selectAdjustedDirectoryButton.Name = "selectAdjustedDirectoryButton";
            selectAdjustedDirectoryButton.Size = new Size(24, 24);
            selectAdjustedDirectoryButton.TabIndex = 4;
            selectAdjustedDirectoryButton.Text = "...";
            selectAdjustedDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.Location = new Point(8, 552);
            label9.Name = "label9";
            label9.Size = new Size(80, 24);
            label9.TabIndex = 7;
            label9.Text = "ダウンロード";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // adjustedDirectoryText
            // 
            adjustedDirectoryText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adjustedDirectoryText.Location = new Point(96, 584);
            adjustedDirectoryText.Margin = new Padding(3, 2, 3, 2);
            adjustedDirectoryText.Name = "adjustedDirectoryText";
            adjustedDirectoryText.Size = new Size(840, 23);
            adjustedDirectoryText.TabIndex = 8;
            // 
            // selectSaveDirectoryButton
            // 
            selectSaveDirectoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectSaveDirectoryButton.Location = new Point(944, 552);
            selectSaveDirectoryButton.Margin = new Padding(3, 2, 3, 2);
            selectSaveDirectoryButton.Name = "selectSaveDirectoryButton";
            selectSaveDirectoryButton.Size = new Size(24, 24);
            selectSaveDirectoryButton.TabIndex = 5;
            selectSaveDirectoryButton.Text = "...";
            selectSaveDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // saveDirectoryText
            // 
            saveDirectoryText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveDirectoryText.Location = new Point(96, 552);
            saveDirectoryText.Margin = new Padding(3, 2, 3, 2);
            saveDirectoryText.Name = "saveDirectoryText";
            saveDirectoryText.Size = new Size(840, 23);
            saveDirectoryText.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 656);
            Controls.Add(label10);
            Controls.Add(selectAdjustedDirectoryButton);
            Controls.Add(label9);
            Controls.Add(adjustedDirectoryText);
            Controls.Add(selectSaveDirectoryButton);
            Controls.Add(saveDirectoryText);
            Controls.Add(showSettingButton);
            Controls.Add(processingButtonsPanel);
            Controls.Add(splitContainer1);
            Controls.Add(interruptButton);
            Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(4, 2, 4, 2);
            Name = "MainForm";
            Text = "Youtube DLder";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            processingButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox videoListText;
        private TextBox consoleText;
        private Button downloadButton;
        private Button showSettingButton;
        private Button interruptButton;
        private TableLayoutPanel processingButtonsPanel;
        private Button adjustVolumeButton;
        private Label label10;
        private Button selectAdjustedDirectoryButton;
        private Label label9;
        private TextBox adjustedDirectoryText;
        private Button selectSaveDirectoryButton;
        private TextBox saveDirectoryText;
    }
}
