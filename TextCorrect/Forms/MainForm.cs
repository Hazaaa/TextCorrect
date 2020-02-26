using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Markup;
using TextCorrect.Core;
using TextCorrect.Forms;

namespace TextCorrect
{
    public partial class MainForm : Form
    {
        private readonly TextManipulation textManipulation;
        private PropertyForm pf;

        System.Windows.Controls.RichTextBox rtbEnteredText = new System.Windows.Controls.RichTextBox();

        public string EnteredText {
            get
            {
                return new TextRange(rtbEnteredText.Document.ContentStart, rtbEnteredText.Document.ContentEnd).Text;
            }
            set {
                rtbEnteredText.Document.Blocks.Clear();
                rtbEnteredText.AppendText(value);
            } }
        
        public Language SelectedLanguage { get; set; }

        public PropertyForm PropertyForm
        {
            get
            {
                if (pf == null || pf.IsDisposed)
                {
                    pf = new PropertyForm(rtbEnteredText);
                    return pf;
                }
                else
                {
                    return pf;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            textManipulation = new TextManipulation();
        }

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text += " - " + SelectedLanguage;
            if(SelectedLanguage == Language.Serbian_latin)
            {
                gbxSpecialFunctions.Visible = true;
            }
            else
            {
                gbxSpecialFunctions.Visible = false;
            }

            SetWpfElementHost();

            timer.Start();
        }

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            if(EnteredText != "\r\n")
            {
                if(System.Windows.Forms.MessageBox.Show("Are you sure you want to change language?", "Language change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            string text = textManipulation.PreCorrectText(EnteredText);
            EnteredText = text;
        }

        private void btnLoadTextFormFile_Click(object sender, EventArgs e)
        {
            if (ofdLoadFile.ShowDialog() == DialogResult.OK)
            {
                string path = ofdLoadFile.FileName;

                using (StreamReader sr = new StreamReader(path))
                {
                    if (EnteredText != "\r\n")
                    {
                        if (System.Windows.Forms.MessageBox.Show("You have unsaved text. Are you sure you want to overwrite it?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            EnteredText = sr.ReadToEnd();

                            if(SelectedLanguage != Language.English)
                            {
                                if(EnteredText.ToUpper().Contains("И"))
                                {
                                    SelectedLanguage = Language.Serbian_cyrillic;
                                } else
                                {
                                    SelectedLanguage = Language.Serbian_latin;
                                }
                            }
                            SetSpellCheckDictionary();
                        }
                    }
                    else
                    {
                        EnteredText = sr.ReadToEnd();

                        if (SelectedLanguage != Language.English)
                        {
                            if (EnteredText.ToUpper().Contains("И"))
                            {
                                SelectedLanguage = Language.Serbian_cyrillic;
                            }
                            else
                            {
                                SelectedLanguage = Language.Serbian_latin;
                            }
                        }
                        SetSpellCheckDictionary();
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
                    sw.Write(EnteredText);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (EnteredText != "\r\n")
            {
                if (System.Windows.Forms.MessageBox.Show("You have unsaved text. Are you sure you want to clear it?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rtbEnteredText.Document.Blocks.Clear();
                }
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            System.Windows.Clipboard.SetText(EnteredText);
        }

        private void btnOnlyFirstOccurrence_Click_1(object sender, EventArgs e)
        {
            ReplaceWordInText(txbWordToReplace.Text, txbReplaceWith.Text, true);
        }

        private void btnAllOccurrences_Click_1(object sender, EventArgs e)
        {
            ReplaceWordInText(txbWordToReplace.Text, txbReplaceWith.Text, false);
        }

        private void btnToCyrillic_Click(object sender, EventArgs e)
        {
            var cyrillicText = textManipulation.ConvertTextToCyrillic(EnteredText);
            EnteredText = cyrillicText;
            SelectedLanguage = Language.Serbian_cyrillic;
            SetSpellCheckDictionary();
        }

        private void btnToLatin_Click(object sender, EventArgs e)
        {
            var latinText = textManipulation.ConvertTextToLatin(EnteredText);
            EnteredText = latinText;
            SelectedLanguage = Language.Serbian_latin;
            SetSpellCheckDictionary();
        }
        private void RtbEnteredText_SelectionChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            txbWordToReplace.Text = rtbEnteredText.Selection.Text.Trim();
        }

        private void pbxSettings_Click(object sender, EventArgs e)
        {
            PropertyForm.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (EnteredText != "\r\n" && rtbEnteredText.GetNextSpellingErrorPosition(rtbEnteredText.Document.ContentStart, LogicalDirection.Forward) != null)
            {
                lblTextErrorIndicator.Visible = true;
                lblTextErrorIndicator.ForeColor = Color.Red;
                lblTextErrorIndicator.Text = "X - There are spelling errors.";
            }
            else
            {
                lblTextErrorIndicator.Visible = true;
                lblTextErrorIndicator.ForeColor = Color.Green;
                lblTextErrorIndicator.Text = "✔ - No spelling errors.";
            }
        }

        private void RtbEnteredText_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SetSpellCheckDictionary();
        }

        #endregion

        #region Helpers

        public void SetWpfElementHost()
        {
            // Adding wpf richtextbox to control
            rtbEnteredText.SpellCheck.IsEnabled = true;
            rtbEnteredText.AutoWordSelection = true;
            rtbEnteredText.VerticalScrollBarVisibility = System.Windows.Controls.ScrollBarVisibility.Auto;

            rtbEnteredText.SelectionChanged += RtbEnteredText_SelectionChanged;
            rtbEnteredText.MouseEnter += RtbEnteredText_MouseEnter;
            ehText.Child = rtbEnteredText;
            
        }

        public void ReplaceWordInText(string word, string replaceWith, bool firstOccurrence)
        {
            if (word == "" || replaceWith == "")
                return;

            if (firstOccurrence)
            {
                int indexWord = EnteredText.IndexOf(word);

                if (indexWord != -1)
                {
                    var replacedText = EnteredText.Remove(indexWord, word.Length).Insert(indexWord, replaceWith);
                    EnteredText = replacedText;
                }
            }
            else
            {
                var replacedText = EnteredText.Replace(word, replaceWith);
                EnteredText = replacedText;
            }

            txbReplaceWith.Text = "";
            txbWordToReplace.Text = "";
        }

        public void ShowWelcomeForm()
        {
            this.Hide();
            WelcomeForm wf = new WelcomeForm();
            wf.ShowDialog();
            this.Close();
        }

        public void SetSpellCheckDictionary()
        {
            rtbEnteredText.SpellCheck.CustomDictionaries.Clear();

            if (SelectedLanguage == Language.Serbian_cyrillic)
            {
                var culture = System.Globalization.CultureInfo.GetCultureInfo("sr-Cyrl-RS");
                Thread.CurrentThread.CurrentCulture = culture;
                rtbEnteredText.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentCulture.Name);
                var language = InputLanguage.FromCulture(culture);

                if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                    InputLanguage.CurrentInputLanguage = language;

                rtbEnteredText.SpellCheck.CustomDictionaries.Add(new Uri(@"pack://application:,,,/sr.lex"));
            }
            else if (SelectedLanguage == Language.Serbian_latin)
            {
                var culture = System.Globalization.CultureInfo.GetCultureInfo("sr-Latn-RS");
                Thread.CurrentThread.CurrentCulture = culture;
                rtbEnteredText.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentCulture.Name);
                var language = InputLanguage.FromCulture(culture);

                if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                    InputLanguage.CurrentInputLanguage = language;

                rtbEnteredText.SpellCheck.CustomDictionaries.Add(new Uri(@"pack://application:,,,/sr-latn.lex"));
            } else
            {
                var culture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = culture;
                rtbEnteredText.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentCulture.Name);
                var language = InputLanguage.FromCulture(culture);

                if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0)
                    InputLanguage.CurrentInputLanguage = language;
            }
        }

        #endregion
    }
}
