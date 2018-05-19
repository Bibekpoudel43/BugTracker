using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Assignment2
{
    public partial class ReportForm : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataTable d;
        DataSet dt;
        MySqlCommand myCommand;
        string clickedtext;
        public ReportForm()
        {
            InitializeComponent();
            getUsers();
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

        public void getUsers() {
            dt = new DataSet();
            try
            {
                string query = "select id,email from users";
                MySqlCommand cmd = new MySqlCommand(query, con);
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);
                comboBoxAssignee.DataSource = dt.Tables[0];
                comboBoxAssignee.DisplayMember = "email";
                comboBoxAssignee.ValueMember = "id";
                comboBoxAssignee.Enabled = true;
                comboBoxAssignee.SelectedIndex = -1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            if (op.ShowDialog() == DialogResult.OK) {
                pictureBoxImage.Image = Image.FromFile(op.FileName);
            }
        }

        private void clickCommit(object sender, EventArgs e)
        {

            //validation
            if (txtpname.Text == "")
            {
                lblpname.Text = "•Please enter a project name ";
            }
            else if (txtclass.Text == "")
            {
                lblclass.Text = " •Please enter a class name ";
            }
            else if (txtmethod.Text == "")
            {
                lblmethod.Text = " •Please enter a method name ";
            }
            else if (textlineno.Text == "")
            {
                lbllineno.Text = "•Please enter a line number ";
            }
            else if (txtauthor.Text == "")
            {
                lblauthor.Text = "•Please enter a author name ";
            }
            else if (comboBoxAssignee.Text == "")
            {
                lblassignee.Text = "•Please choose whom to assign ";
            }
            else if (textsummary.Text == "")
            {
                lblsummary.Text = " •Please enter a summary";
            }
            else if (comboBoxSeverity.Text == "")
            {
                lblseverity.Text = " •Please choose a severity level ";
            }
            else if (editor.Text == "")
            {
                lblEditor.Text = "•Please write a error syntax ";
            }
            else {
                string pNmae = txtpname.Text;
                string className = txtclass.Text;
                string mName = txtmethod.Text;
                string lineNo = textlineno.Text;
                string author = txtauthor.Text;
                string assignTo = comboBoxAssignee.Text;
                string summary = textsummary.Text;
                string severity = comboBoxSeverity.Text;
                string editorB = editor.Text;

                MemoryStream ms = new MemoryStream();
                pictureBoxImage.Image.Save(ms, pictureBoxImage.Image.RawFormat);
                byte[] img = ms.ToArray();
                try
                {
                    string myInsertQuery = "INSERT INTO bugs (project_name, class, method, line_no, code_author, severity, assigned_to," +
                        "summary, syntax, language, image, assigned_by, status) " +
                        "Values('" + pNmae + "','" + className + "','" + mName + "', '" + lineNo + "','" + author + "','" + severity + "', " +
                        "'" + assignTo + "','" + summary + "','" + editorB + "','" + clickedtext + "', '" + img + "','" + LoginForm.user + "', 'Un-Fixed')";
                    myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Connection = con;
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Inserted sucessfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                myCommand.Connection.Close();
            }
        }

        private void Language_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            clickedtext = e.ClickedItem.Text;
        }
    }
}
