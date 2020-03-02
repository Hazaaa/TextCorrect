using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextCorrect.Core;

namespace TextCorrect.Forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        //Making form draggable because it doesn't have borders
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        //

        private void pbxSerbian_Click(object sender, EventArgs e)
        {
            string[] languages = { "sr-Cyrl-RS", "sr-Latn-RS" };

            foreach (string languageName in languages)
            {
                var culture = System.Globalization.CultureInfo.GetCultureInfo(languageName);
                var language = InputLanguage.FromCulture(culture);

                if (InputLanguage.InstalledInputLanguages.IndexOf(language) < 0)
                {
                    MessageBox.Show("Serbian language pack is missing.\nTry installing Serbian Latin and Cyrillic in your Windows preferences and restart application.", "Language pack missing.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            ShowMainForm(Language.Serbian_latin);
        }

        private void pbxEnglish_Click(object sender, EventArgs e)
        {
            ShowMainForm(Language.English);
        }

        public void ShowMainForm(Language language)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.SelectedLanguage = language;

            mf.ShowDialog();
            
            this.Close();
        }

        private void lblCloseForm_Click(object sender, EventArgs e)
        {
            //Closing app with closing all other forms that are open
            if (MessageBox.Show("Are you sure you want to close app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
