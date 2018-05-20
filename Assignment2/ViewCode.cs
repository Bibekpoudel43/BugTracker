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
    public partial class ViewCode : Form
    {
        public ViewCode()
        {
            InitializeComponent();
        }

        private void fastColoredTextBoxCode_Load(object sender, EventArgs e)
        { 

            if(ViewBug.Language == "C#")
            {
                fastColoredTextBoxCode.Language = FastColoredTextBoxNS.Language.CSharp;
                fastColoredTextBoxCode.Text = ViewBug.code;
            }
            else if (ViewBug.Language == "HTML")
            {
                fastColoredTextBoxCode.Language = FastColoredTextBoxNS.Language.HTML;
                fastColoredTextBoxCode.Text = ViewBug.code;
            }
            else if (ViewBug.Language == "PHP")
            {
                fastColoredTextBoxCode.Language = FastColoredTextBoxNS.Language.PHP;
                fastColoredTextBoxCode.Text = ViewBug.code;
            }
            else if (ViewBug.Language == "JS")
            {
                fastColoredTextBoxCode.Language = FastColoredTextBoxNS.Language.JS;
                fastColoredTextBoxCode.Text = ViewBug.code;
            }
        }
    }
}
