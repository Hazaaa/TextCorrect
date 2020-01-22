using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextCorrect.Core;
using TextCorrect.Forms;

namespace TextCorrect
{
    public partial class MainForm : Form
    {
        private readonly TextManipulation textManipulation;
        public Language SelectedLanguage { get; set; }

        public MainForm()
        {
            InitializeComponent();
            textManipulation = new TextManipulation();
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text += " - " + SelectedLanguage;
            if(SelectedLanguage == Language.Serbian)
            {
                gbxSpecialFunctions.Visible = true;
            }
            else
            {
                gbxSpecialFunctions.Visible = false;
            }
        }

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            if(rtbEnteredText.Text != "")
            {
                if(MessageBox.Show("Are you sure you want to change language?", "Language change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ShowWelcomeForm();
                }
            }
            else
            {
                ShowWelcomeForm();
            }
        }

        private void btnPreCorrection_Click(object sender, EventArgs e)
        {
            rtbEnteredText.Text = textManipulation.PreCorrectText(rtbEnteredText.Text);
        }

        private void btnLoadTextFormFile_Click(object sender, EventArgs e)
        {
            if (ofdLoadFile.ShowDialog() == DialogResult.OK)
            {
                string path = ofdLoadFile.FileName;

                using (StreamReader sr = new StreamReader(path))
                {
                    if (rtbEnteredText.Text != "")
                    {
                        if (MessageBox.Show("You have unsaved text. Are you sure you want to overwrite it?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            rtbEnteredText.Text = sr.ReadToEnd();
                        }
                    }
                    else
                    {
                        rtbEnteredText.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void btnSaveTextToFile_Click(object sender, EventArgs e)
        {
            if (sfdSaveTextToFile.ShowDialog() == DialogResult.OK)
            {
                string path = ofdLoadFile.FileName;

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(rtbEnteredText.Text);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (rtbEnteredText.Text != "")
            {
                if (MessageBox.Show("You have unsaved text. Are you sure you want to clear it?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtbEnteredText.Clear();
                }
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbEnteredText.Text);
        }

        private void btnToCyrillic_Click(object sender, EventArgs e)
        {
            rtbEnteredText.Text = textManipulation.ConvertTextToCyrillic(rtbEnteredText.Text);
        }

        private void btnToLatin_Click(object sender, EventArgs e)
        {
            rtbEnteredText.Text = textManipulation.ConvertTextToLatin(rtbEnteredText.Text);
        }

        #endregion

        #region Helpers

        public void ShowWelcomeForm()
        {
            this.Hide();
            WelcomeForm wf = new WelcomeForm();
            wf.ShowDialog();
            this.Close();
        }

        #endregion

        private async void btnAnalyzeText_Click(object sender, EventArgs e)
        {
            List<string> splittedText = rtbEnteredText.Text.Split(' ').Distinct().ToList();

            if (SelectedLanguage == Language.English)
            {
                foreach (string word in splittedText)
                {
                    List<string> checkResult = await textManipulation.CheckEnglishWord(textManipulation.RemoveSpecialCharacters(word.ToLower()));

                    if (!checkResult.Contains(word))
                    {
                        foreach (Match match in Regex.Matches(rtbEnteredText.Text, "\\b" + textManipulation.RemoveSpecialCharacters(word) + "\\b"))
                        {
                            rtbEnteredText.SelectionStart = match.Index;
                            rtbEnteredText.SelectionLength = word.Length;
                            rtbEnteredText.SelectionFont = new Font(rtbEnteredText.SelectionFont, FontStyle.Underline);
                            rtbEnteredText.SelectionColor = Color.Red;
                        }
                    }
                }
            }
            else
            {

            }
        }
    }
}
