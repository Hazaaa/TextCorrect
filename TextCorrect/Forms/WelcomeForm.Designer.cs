namespace TextCorrect.Forms
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pbxEnglish = new System.Windows.Forms.PictureBox();
            this.pbxSerbian = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCloseForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSerbian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to TextCorrect";
            // 
            // pbxEnglish
            // 
            this.pbxEnglish.Image = global::TextCorrect.Properties.Resources.flag_800;
            this.pbxEnglish.Location = new System.Drawing.Point(174, 252);
            this.pbxEnglish.Name = "pbxEnglish";
            this.pbxEnglish.Size = new System.Drawing.Size(47, 29);
            this.pbxEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEnglish.TabIndex = 3;
            this.pbxEnglish.TabStop = false;
            this.pbxEnglish.Click += new System.EventHandler(this.pbxEnglish_Click);
            // 
            // pbxSerbian
            // 
            this.pbxSerbian.Image = global::TextCorrect.Properties.Resources.flag_400;
            this.pbxSerbian.Location = new System.Drawing.Point(72, 256);
            this.pbxSerbian.Name = "pbxSerbian";
            this.pbxSerbian.Size = new System.Drawing.Size(48, 29);
            this.pbxSerbian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSerbian.TabIndex = 2;
            this.pbxSerbian.TabStop = false;
            this.pbxSerbian.Click += new System.EventHandler(this.pbxSerbian_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TextCorrect.Properties.Resources.analytics;
            this.pictureBox1.Location = new System.Drawing.Point(77, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Serbian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "English";
            // 
            // lblCloseForm
            // 
            this.lblCloseForm.AutoSize = true;
            this.lblCloseForm.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseForm.Location = new System.Drawing.Point(275, 6);
            this.lblCloseForm.Name = "lblCloseForm";
            this.lblCloseForm.Size = new System.Drawing.Size(18, 23);
            this.lblCloseForm.TabIndex = 6;
            this.lblCloseForm.Text = "X";
            this.lblCloseForm.Click += new System.EventHandler(this.lblCloseForm_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(297, 343);
            this.Controls.Add(this.lblCloseForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxEnglish);
            this.Controls.Add(this.pbxSerbian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSerbian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxSerbian;
        private System.Windows.Forms.PictureBox pbxEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCloseForm;
    }
}