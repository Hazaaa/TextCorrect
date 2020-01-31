namespace TextCorrect.Forms
{
    partial class CorrectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrectionForm));
            this.gbxText = new System.Windows.Forms.GroupBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rtbEnteredText = new System.Windows.Forms.RichTextBox();
            this.gbxWordReplace = new System.Windows.Forms.GroupBox();
            this.btnAllOccurrences = new System.Windows.Forms.Button();
            this.btnOnlyFirstOccurrence = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbReplaceWith = new System.Windows.Forms.TextBox();
            this.txbWordToReplace = new System.Windows.Forms.TextBox();
            this.cmsSuggestedWords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxText.SuspendLayout();
            this.gbxWordReplace.SuspendLayout();
            this.SuspendLayout();
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
            this.gbxText.TabIndex = 3;
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
            // 
            // rtbEnteredText
            // 
            this.rtbEnteredText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEnteredText.BackColor = System.Drawing.Color.White;
            this.rtbEnteredText.Location = new System.Drawing.Point(6, 16);
            this.rtbEnteredText.Name = "rtbEnteredText";
            this.rtbEnteredText.Size = new System.Drawing.Size(570, 453);
            this.rtbEnteredText.TabIndex = 0;
            this.rtbEnteredText.Text = "";
            // 
            // gbxWordReplace
            // 
            this.gbxWordReplace.Controls.Add(this.btnAllOccurrences);
            this.gbxWordReplace.Controls.Add(this.btnOnlyFirstOccurrence);
            this.gbxWordReplace.Controls.Add(this.label2);
            this.gbxWordReplace.Controls.Add(this.label1);
            this.gbxWordReplace.Controls.Add(this.txbReplaceWith);
            this.gbxWordReplace.Controls.Add(this.txbWordToReplace);
            this.gbxWordReplace.Location = new System.Drawing.Point(615, 11);
            this.gbxWordReplace.Name = "gbxWordReplace";
            this.gbxWordReplace.Size = new System.Drawing.Size(131, 184);
            this.gbxWordReplace.TabIndex = 9;
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
            // 
            // btnOnlyFirstOccurrence
            // 
            this.btnOnlyFirstOccurrence.Location = new System.Drawing.Point(6, 115);
            this.btnOnlyFirstOccurrence.Name = "btnOnlyFirstOccurrence";
            this.btnOnlyFirstOccurrence.Size = new System.Drawing.Size(119, 23);
            this.btnOnlyFirstOccurrence.TabIndex = 13;
            this.btnOnlyFirstOccurrence.Text = "Only First Occurrence";
            this.btnOnlyFirstOccurrence.UseVisualStyleBackColor = true;
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
            // cmsSuggestedWords
            // 
            this.cmsSuggestedWords.Name = "cmsSuggestedWords";
            this.cmsSuggestedWords.Size = new System.Drawing.Size(181, 26);
            // 
            // CorrectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 527);
            this.Controls.Add(this.gbxWordReplace);
            this.Controls.Add(this.gbxText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 485);
            this.Name = "CorrectionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correction Form";
            this.gbxText.ResumeLayout(false);
            this.gbxWordReplace.ResumeLayout(false);
            this.gbxWordReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxText;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtbEnteredText;
        private System.Windows.Forms.GroupBox gbxWordReplace;
        private System.Windows.Forms.Button btnAllOccurrences;
        private System.Windows.Forms.Button btnOnlyFirstOccurrence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbReplaceWith;
        private System.Windows.Forms.TextBox txbWordToReplace;
        private System.Windows.Forms.ContextMenuStrip cmsSuggestedWords;
    }
}