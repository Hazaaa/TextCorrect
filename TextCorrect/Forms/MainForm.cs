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
        #region Properties

        private readonly TextManipulation textManipulation;

        System.Windows.Controls.RichTextBox rtbEnteredText = new System.Windows.Controls.RichTextBox();

        public Language SelectedLanguage { get; set; }
        public string EnteredText
        {
            get
            {
                return new TextRange(rtbEnteredText.Document.ContentStart, rtbEnteredText.Document.ContentEnd).Text;
            }
            set
            {
                rtbEnteredText.Document.Blocks.Clear();
                rtbEnteredText.AppendText(value);
            }
        }

        private PropertyForm pf;
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

        #endregion

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
            SetSpellCheckDictionary();
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

        private void RtbEnteredText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!CheckCurrentLanguageOfRichTextBox())
            {
                SetSpellCheckDictionary();
            }
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
            rtbEnteredText.GotFocus += RtbEnteredText_GotFocus;
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
                SetInputAndRichTextBoxLanguage("sr-Cyrl-RS");
                rtbEnteredText.SpellCheck.CustomDictionaries.Add(new Uri(@"pack://application:,,,/sr.lex"));
            }
            else if (SelectedLanguage == Language.Serbian_latin)
            {
                SetInputAndRichTextBoxLanguage("sr-Latn-RS");
                rtbEnteredText.SpellCheck.CustomDictionaries.Add(new Uri(@"pack://application:,,,/sr-latn.lex"));
            } else
            {
                SetInputAndRichTextBoxLanguage("en-US");
            }
        }

        public void SetInputAndRichTextBoxLanguage(string languageCode)
        {
            var culture = System.Globalization.CultureInfo.GetCultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = culture;
            rtbEnteredText.Language = XmlLanguage.GetLanguage(culture.Name);
            var language = InputLanguage.FromCulture(culture);

            if (InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0 && InputLanguage.CurrentInputLanguage != language)
                InputLanguage.CurrentInputLanguage = language;
        }

        public bool CheckCurrentLanguageOfRichTextBox()
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var language = InputLanguage.FromCulture(culture);

            if (rtbEnteredText.Language == XmlLanguage.GetLanguage(culture.Name) && InputLanguage.CurrentInputLanguage.LayoutName == language.LayoutName)
                return true;
            else
                return false;
        }

        #endregion
    }
}
