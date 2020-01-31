namespace TextCorrect
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtbEnteredText = new System.Windows.Forms.RichTextBox();
            this.gbxText = new System.Windows.Forms.GroupBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.gbxLanguage = new System.Windows.Forms.GroupBox();
            this.btnAnalyzeText = new System.Windows.Forms.Button();
            this.btnPreCorrection = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnToCyrillic = new System.Windows.Forms.Button();
            this.btnToLatin = new System.Windows.Forms.Button();
            this.gbxSpecialFunctions = new System.Windows.Forms.GroupBox();
            this.btnLoadTextFormFile = new System.Windows.Forms.Button();
            this.ofdLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveTextToFile = new System.Windows.Forms.Button();
            this.sfdSaveTextToFile = new System.Windows.Forms.SaveFileDialog();
            this.gbxText.SuspendLayout();
            this.gbxLanguage.SuspendLayout();
            this.gbxSpecialFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEnteredText
            // 
            this.rtbEnteredText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEnteredText.BackColor = System.Drawing.Color.White;
            this.rtbEnteredText.Location = new System.Drawing.Point(6, 19);
            this.rtbEnteredText.Name = "rtbEnteredText";
            this.rtbEnteredText.Size = new System.Drawing.Size(576, 453);
            this.rtbEnteredText.TabIndex = 0;
            this.rtbEnteredText.Text = "";
            // 
            // gbxText
            // 
            this.gbxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxText.Controls.Add(this.btnCopyToClipboard);
            this.gbxText.Controls.Add(this.btnClear);
            this.gbxText.Controls.Add(this.rtbEnteredText);
            this.gbxText.Location = new System.Drawing.Point(12, 12);
            this.gbxText.Name = "gbxText";
            this.gbxText.Size = new System.Drawing.Size(588, 503);
            this.gbxText.TabIndex = 2;
            this.gbxText.TabStop = false;
            this.gbxText.Text = "Text:";
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(81, 475);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(106, 22);
            this.btnCopyToClipboard.TabIndex = 9;
            this.btnCopyToClipboard.Text = "Copy To Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(6, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 22);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear\r\n";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeLanguage.Location = new System.Drawing.Point(616, 16);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(131, 23);
            this.btnChangeLanguage.TabIndex = 3;
            this.btnChangeLanguage.Text = "🌍 Change Language";
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // gbxLanguage
            // 
            this.gbxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLanguage.Controls.Add(this.btnAnalyzeText);
            this.gbxLanguage.Controls.Add(this.btnPreCorrection);
            this.gbxLanguage.Location = new System.Drawing.Point(616, 112);
            this.gbxLanguage.Name = "gbxLanguage";
            this.gbxLanguage.Size = new System.Drawing.Size(131, 98);
            this.gbxLanguage.TabIndex = 4;
            this.gbxLanguage.TabStop = false;
            this.gbxLanguage.Text = "Analyze:";
            // 
            // btnAnalyzeText
            // 
            this.btnAnalyzeText.Location = new System.Drawing.Point(6, 60);
            this.btnAnalyzeText.Name = "btnAnalyzeText";
            this.btnAnalyzeText.Size = new System.Drawing.Size(119, 23);
            this.btnAnalyzeText.TabIndex = 6;
            this.btnAnalyzeText.Text = "✍ Analyze Text";
            this.btnAnalyzeText.UseVisualStyleBackColor = true;
            this.btnAnalyzeText.Click += new System.EventHandler(this.btnAnalyzeText_Click);
            // 
            // btnPreCorrection
            // 
            this.btnPreCorrection.Location = new System.Drawing.Point(6, 24);
            this.btnPreCorrection.Name = "btnPreCorrection";
            this.btnPreCorrection.Size = new System.Drawing.Size(119, 23);
            this.btnPreCorrection.TabIndex = 5;
            this.btnPreCorrection.Text = "✔ Pre-Correction";
            this.toolTip.SetToolTip(this.btnPreCorrection, "Removes unnecessary whitespace, special characters, capitalize first letter, ...");
            this.btnPreCorrection.UseVisualStyleBackColor = true;
            this.btnPreCorrection.Click += new System.EventHandler(this.btnPreCorrection_Click);
            // 
            // btnToCyrillic
            // 
            this.btnToCyrillic.Location = new System.Drawing.Point(6, 25);
            this.btnToCyrillic.Name = "btnToCyrillic";
            this.btnToCyrillic.Size = new System.Drawing.Size(119, 23);
            this.btnToCyrillic.TabIndex = 5;
            this.btnToCyrillic.Text = "Text To Cyrillic ";
            this.toolTip.SetToolTip(this.btnToCyrillic, "Removes unnecessary whitespace, special characters, sets first letters to up, ..." +
        "");
            this.btnToCyrillic.UseVisualStyleBackColor = true;
            this.btnToCyrillic.Click += new System.EventHandler(this.btnToCyrillic_Click);
            // 
            // btnToLatin
            // 
            this.btnToLatin.Location = new System.Drawing.Point(6, 61);
            this.btnToLatin.Name = "btnToLatin";
            this.btnToLatin.Size = new System.Drawing.Size(119, 23);
            this.btnToLatin.TabIndex = 6;
            this.btnToLatin.Text = "Text To Latin";
            this.toolTip.SetToolTip(this.btnToLatin, "Removes unnecessary whitespace, special characters, sets first letters to up, ..." +
        "");
            this.btnToLatin.UseVisualStyleBackColor = true;
            this.btnToLatin.Click += new System.EventHandler(this.btnToLatin_Click);
            // 
            // gbxSpecialFunctions
            // 
            this.gbxSpecialFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSpecialFunctions.Controls.Add(this.btnToLatin);
            this.gbxSpecialFunctions.Controls.Add(this.btnToCyrillic);
            this.gbxSpecialFunctions.Location = new System.Drawing.Point(618, 219);
            this.gbxSpecialFunctions.Name = "gbxSpecialFunctions";
            this.gbxSpecialFunctions.Size = new System.Drawing.Size(131, 95);
            this.gbxSpecialFunctions.TabIndex = 5;
            this.gbxSpecialFunctions.TabStop = false;
            this.gbxSpecialFunctions.Text = "Special Functions:";
            this.gbxSpecialFunctions.Visible = false;
            // 
            // btnLoadTextFormFile
            // 
            this.btnLoadTextFormFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTextFormFile.Location = new System.Drawing.Point(616, 48);
            this.btnLoadTextFormFile.Name = "btnLoadTextFormFile";
            this.btnLoadTextFormFile.Size = new System.Drawing.Size(131, 23);
            this.btnLoadTextFormFile.TabIndex = 6;
            this.btnLoadTextFormFile.Text = "📁 Load Text From File";
            this.btnLoadTextFormFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFormFile.Click += new System.EventHandler(this.btnLoadTextFormFile_Click);
            // 
            // ofdLoadFile
            // 
            this.ofdLoadFile.Filter = "Txt files|*.txt";
            // 
            // btnSaveTextToFile
            // 
            this.btnSaveTextToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveTextToFile.Location = new System.Drawing.Point(616, 80);
            this.btnSaveTextToFile.Name = "btnSaveTextToFile";
            this.btnSaveTextToFile.Size = new System.Drawing.Size(131, 23);
            this.btnSaveTextToFile.TabIndex = 7;
            this.btnSaveTextToFile.Text = "📂 Save Text To File";
            this.btnSaveTextToFile.UseVisualStyleBackColor = true;
            this.btnSaveTextToFile.Click += new System.EventHandler(this.btnSaveTextToFile_Click);
            // 
            // sfdSaveTextToFile
            // 
            this.sfdSaveTextToFile.Filter = "Txt file|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(761, 527);
            this.Controls.Add(this.btnSaveTextToFile);
            this.Controls.Add(this.btnLoadTextFormFile);
            this.Controls.Add(this.gbxSpecialFunctions);
            this.Controls.Add(this.gbxLanguage);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.gbxText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 485);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextCorrect";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxText.ResumeLayout(false);
            this.gbxLanguage.ResumeLayout(false);
            this.gbxSpecialFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEnteredText;
        private System.Windows.Forms.GroupBox gbxText;
        private System.Windows.Forms.Button btnChangeLanguage;
        private System.Windows.Forms.GroupBox gbxLanguage;
        private System.Windows.Forms.Button btnPreCorrection;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbxSpecialFunctions;
        private System.Windows.Forms.Button btnToLatin;
        private System.Windows.Forms.Button btnToCyrillic;
        private System.Windows.Forms.Button btnAnalyzeText;
        private System.Windows.Forms.Button btnLoadTextFormFile;
        private System.Windows.Forms.OpenFileDialog ofdLoadFile;
        private System.Windows.Forms.Button btnSaveTextToFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveTextToFile;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnClear;
    }
}

