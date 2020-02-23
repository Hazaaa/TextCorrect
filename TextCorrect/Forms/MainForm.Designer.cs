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
            this.gbxText = new System.Windows.Forms.GroupBox();
            this.ehText = new System.Windows.Forms.Integration.ElementHost();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.btnPreCorrection = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnToCyrillic = new System.Windows.Forms.Button();
            this.btnToLatin = new System.Windows.Forms.Button();
            this.gbxSpecialFunctions = new System.Windows.Forms.GroupBox();
            this.btnLoadTextFormFile = new System.Windows.Forms.Button();
            this.ofdLoadFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveTextToFile = new System.Windows.Forms.Button();
            this.sfdSaveTextToFile = new System.Windows.Forms.SaveFileDialog();
            this.gbxWordReplace = new System.Windows.Forms.GroupBox();
            this.btnAllOccurrences = new System.Windows.Forms.Button();
            this.btnOnlyFirstOccurrence = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbReplaceWith = new System.Windows.Forms.TextBox();
            this.txbWordToReplace = new System.Windows.Forms.TextBox();
            this.gbxText.SuspendLayout();
            this.gbxSpecialFunctions.SuspendLayout();
            this.gbxWordReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxText
            // 
            this.gbxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxText.Controls.Add(this.ehText);
            this.gbxText.Controls.Add(this.btnCopyToClipboard);
            this.gbxText.Controls.Add(this.btnClear);
            this.gbxText.Location = new System.Drawing.Point(12, 12);
            this.gbxText.Name = "gbxText";
            this.gbxText.Size = new System.Drawing.Size(588, 503);
            this.gbxText.TabIndex = 2;
            this.gbxText.TabStop = false;
            this.gbxText.Text = "Text:";
            // 
            // ehText
            // 
            this.ehText.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ehText.Location = new System.Drawing.Point(6, 19);
            this.ehText.Name = "ehText";
            this.ehText.Size = new System.Drawing.Size(576, 450);
            this.ehText.TabIndex = 10;
            this.ehText.Text = "elementHost1";
            this.ehText.Child = null;
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
            this.btnChangeLanguage.Location = new System.Drawing.Point(616, 31);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(131, 23);
            this.btnChangeLanguage.TabIndex = 3;
            this.btnChangeLanguage.Text = "🌍 Change Language";
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // btnPreCorrection
            // 
            this.btnPreCorrection.Location = new System.Drawing.Point(616, 124);
            this.btnPreCorrection.Name = "btnPreCorrection";
            this.btnPreCorrection.Size = new System.Drawing.Size(131, 23);
            this.btnPreCorrection.TabIndex = 5;
            this.btnPreCorrection.Text = "✔ Text Correction";
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
            this.gbxSpecialFunctions.Location = new System.Drawing.Point(618, 345);
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
            this.btnLoadTextFormFile.Location = new System.Drawing.Point(616, 63);
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
            this.btnSaveTextToFile.Location = new System.Drawing.Point(616, 94);
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
            // gbxWordReplace
            // 
            this.gbxWordReplace.Controls.Add(this.btnAllOccurrences);
            this.gbxWordReplace.Controls.Add(this.btnOnlyFirstOccurrence);
            this.gbxWordReplace.Controls.Add(this.label2);
            this.gbxWordReplace.Controls.Add(this.label1);
            this.gbxWordReplace.Controls.Add(this.txbReplaceWith);
            this.gbxWordReplace.Controls.Add(this.txbWordToReplace);
            this.gbxWordReplace.Location = new System.Drawing.Point(616, 154);
            this.gbxWordReplace.Name = "gbxWordReplace";
            this.gbxWordReplace.Size = new System.Drawing.Size(131, 184);
            this.gbxWordReplace.TabIndex = 10;
            this.gbxWordReplace.TabStop = false;
            this.gbxWordReplace.Text = "Word Replace:";
            // 
            // btnAllOccurrences
            // 
            this.btnAllOccurrences.Location = new System.Drawing.Point(6, 149);
            this.btnAllOccurrences.Name = "btnAllOccurrences";
            this.btnAllOccurrences.Size = new System.Drawing.Size(119, 23);
            this.btnAllOccurrences.TabIndex = 14;
            this.btnAllOccurrences.Text = "All Occurrences";
            this.btnAllOccurrences.UseVisualStyleBackColor = true;
            this.btnAllOccurrences.Click += new System.EventHandler(this.btnAllOccurrences_Click_1);
            // 
            // btnOnlyFirstOccurrence
            // 
            this.btnOnlyFirstOccurrence.Location = new System.Drawing.Point(6, 115);
            this.btnOnlyFirstOccurrence.Name = "btnOnlyFirstOccurrence";
            this.btnOnlyFirstOccurrence.Size = new System.Drawing.Size(119, 23);
            this.btnOnlyFirstOccurrence.TabIndex = 13;
            this.btnOnlyFirstOccurrence.Text = "Only First Occurrence";
            this.btnOnlyFirstOccurrence.UseVisualStyleBackColor = true;
            this.btnOnlyFirstOccurrence.Click += new System.EventHandler(this.btnOnlyFirstOccurrence_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "With:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Replace:";
            // 
            // txbReplaceWith
            // 
            this.txbReplaceWith.Location = new System.Drawing.Point(16, 84);
            this.txbReplaceWith.Name = "txbReplaceWith";
            this.txbReplaceWith.Size = new System.Drawing.Size(100, 20);
            this.txbReplaceWith.TabIndex = 11;
            // 
            // txbWordToReplace
            // 
            this.txbWordToReplace.Location = new System.Drawing.Point(16, 38);
            this.txbWordToReplace.Name = "txbWordToReplace";
            this.txbWordToReplace.Size = new System.Drawing.Size(100, 20);
            this.txbWordToReplace.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(761, 527);
            this.Controls.Add(this.btnPreCorrection);
            this.Controls.Add(this.gbxWordReplace);
            this.Controls.Add(this.btnSaveTextToFile);
            this.Controls.Add(this.btnLoadTextFormFile);
            this.Controls.Add(this.gbxSpecialFunctions);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.gbxText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 485);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextCorrect";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxText.ResumeLayout(false);
            this.gbxSpecialFunctions.ResumeLayout(false);
            this.gbxWordReplace.ResumeLayout(false);
            this.gbxWordReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxText;
        private System.Windows.Forms.Button btnChangeLanguage;
        private System.Windows.Forms.Button btnPreCorrection;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbxSpecialFunctions;
        private System.Windows.Forms.Button btnToLatin;
        private System.Windows.Forms.Button btnToCyrillic;
        private System.Windows.Forms.Button btnLoadTextFormFile;
        private System.Windows.Forms.OpenFileDialog ofdLoadFile;
        private System.Windows.Forms.Button btnSaveTextToFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveTextToFile;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Integration.ElementHost ehText;
        private System.Windows.Forms.GroupBox gbxWordReplace;
        private System.Windows.Forms.Button btnAllOccurrences;
        private System.Windows.Forms.Button btnOnlyFirstOccurrence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbReplaceWith;
        private System.Windows.Forms.TextBox txbWordToReplace;
    }
}

