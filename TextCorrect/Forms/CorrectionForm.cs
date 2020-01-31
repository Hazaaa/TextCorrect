using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextCorrect.Core;

namespace TextCorrect.Forms
{
    public partial class CorrectionForm : Form
    {
        private readonly TextManipulation textManipulation;
        public Language SelectedLanguage { get; set; }

        public CorrectionForm()
        {
            InitializeComponent();
            textManipulation = new TextManipulation();
        }

        #region Events

        private void rtbEnteredText_MouseDown(object sender, MouseEventArgs e)
        {
            if (rtbEnteredText.SelectedText == "")
            {
                SuggestWordsInContextMenuStrip(new List<string>(), cmsSuggestedWords);
                return;
            }

            if (textManipulation.CheckIfWordIsValidHunspell(SelectedLanguage, rtbEnteredText.SelectedText.Trim()))
                return;

            txbWordToReplace.Text = rtbEnteredText.SelectedText.Trim();

            List<string> suggestedWords = textManipulation.SuggestWordsForWordHunspell(SelectedLanguage, rtbEnteredText.SelectedText.Trim());

            if (rtbEnteredText.ContextMenuStrip == null)
            {
                rtbEnteredText.ContextMenuStrip = cmsSuggestedWords;
            }

            if (e.Button == MouseButtons.Right)
            {
                SuggestWordsInContextMenuStrip(suggestedWords, cmsSuggestedWords);
            }
        }

        private void btnOnlyFirstOccurrence_Click(object sender, EventArgs e)
        {
            ReplaceWordInText(txbWordToReplace.Text, txbReplaceWith.Text, true);
        }

        private void btnAllOccurrences_Click(object sender, EventArgs e)
        {
            ReplaceWordInText(txbWordToReplace.Text, txbReplaceWith.Text, false);
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

        #endregion

        #region Helpers

        public void ReplaceWordInText(string word, string replaceWith, bool firstOccurrence)
        {
            if (word == "" || replaceWith == "")
                return;

            if (firstOccurrence)
            {
                int indexWord = rtbEnteredText.Text.IndexOf(word);

                if (indexWord != -1)
                {
                    rtbEnteredText.Text = rtbEnteredText.Text.Remove(indexWord, word.Length).Insert(indexWord, replaceWith);
                }
            }
            else
            {
                rtbEnteredText.Text = rtbEnteredText.Text.Replace(word, replaceWith);
            }

            txbReplaceWith.Text = "";
            txbWordToReplace.Text = "";
        }

        public void ReplaceSelectedTextWith(string replace)
        {
            rtbEnteredText.ReadOnly = true;
            rtbEnteredText.SelectionFont = new Font(rtbEnteredText.SelectionFont, FontStyle.Regular);
            rtbEnteredText.SelectionColor = Color.Black;

            rtbEnteredText.Text = rtbEnteredText.Text.Replace(rtbEnteredText.SelectedText.Trim(), replace);

            rtbEnteredText.ReadOnly = false;

            txbReplaceWith.Text = "";
            txbWordToReplace.Text = "";
        }

        public void SuggestWordsInContextMenuStrip(List<string> words, ContextMenuStrip menu)
        {
            string suggestion = "suggestion";
            menu.Items.Cast<ToolStripItem>().Where(x => x.Tag == (object)suggestion)
                .ToList().ForEach(x => menu.Items.Remove(x));

            words.ToList().ForEach(x =>
            {
                var item = new ToolStripMenuItem(x);
                item.Tag = suggestion;
                item.Click += (s, e) => ReplaceSelectedTextWith(x);
                menu.Items.Insert(0, item);
            });
        }

        #endregion
    }
}
