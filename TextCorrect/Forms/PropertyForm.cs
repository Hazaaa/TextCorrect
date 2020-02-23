using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCorrect.Forms
{
    public partial class PropertyForm : Form
    {
        public PropertyForm()
        {
            InitializeComponent();
        }

        public PropertyForm(System.Windows.Controls.RichTextBox richTextBox)
        {
            InitializeComponent();
            pgrProperties.SelectedObject = richTextBox;
        }
    }
}
