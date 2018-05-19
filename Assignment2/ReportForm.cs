using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void code_default(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void clickHTML(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.HTML;

        }
        private void clickJava(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void clickPython(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.PHP;
        }
    }
}
