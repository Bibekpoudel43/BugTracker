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
        //set connection to mysql database
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataSet dt;
        MySqlCommand myCommand;
        string clickedtext;

        //iniitializing variables
        private string pNmae;
        private string className;
        private string mName;
        private string lineNo;
        private string author;
        private string assignTo;
        private string summary;
        private string severity;
        private string editorB;
        private string lnk;

        public ReportForm()
        {
            InitializeComponent();
            getUsers();
        }

        private void code_default(object sender, EventArgs e)
        {
            //syntax highilghting based on selected language
            editor.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void clickHTML(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.HTML;

        }

        private void clickJS(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.JS;

        }

        private void clickPHP(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.PHP;
        }

        /// <summary>
        /// fetching developer only and load it into a combo ox
        /// </summary>
        public void getUsers()
        {
            dt = new DataSet();
            try
            {
                string query = "select u.id, u.email from users u, roles r, user_roles ur " +
                    "WHERE u.id = ur.user_id and r.id= ur.role_id and r.user_type = 'developer'";
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
            //pop-up dilaogue box for image selection
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
            else if (txtCodeLink.Text == "")
            {
                lblCodeLink.Text = " •Please provide a link to your code";
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
                addBug();
            }
        }

        /// <summary>
        /// adding bug details 
        /// </summary>
        public void addBug()
        {
             pNmae = txtpname.Text;
             className = txtclass.Text;
             mName = txtmethod.Text;
             lineNo = textlineno.Text;
             author = txtauthor.Text;
             assignTo = comboBoxAssignee.Text;
             summary = textsummary.Text;
             severity = comboBoxSeverity.Text;
             editorB = editor.Text;
             lnk = txtCodeLink.Text;

            //converting image into byte array
            MemoryStream ms = new MemoryStream();
            pictureBoxImage.Image.Save(ms, pictureBoxImage.Image.RawFormat);
            byte[] img = ms.ToArray();
            try
            {
                string myInsertQuery = "INSERT INTO bugs (project_name, class, method, line_no, code_author, severity, assigned_to," +
                    "summary, syntax, language, image, assigned_by, date_added, link, status) " +
                    "VALUES('" + pNmae + "','" + className + "','" + mName + "','" + lineNo + "','" + author + "','" + severity + "'," +
                    "'" + assignTo + "','" + summary + "','" + editorB + "','" + clickedtext + "','" + img + "','" + LoginForm.user + "','" + DateTime.Now + "','" + lnk + "', 'Un-Fixed')";
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
                MessageBox.Show("Error in connection!", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            myCommand.Connection.Close();
        }
    
        private void Language_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            clickedtext = e.ClickedItem.Text;
        }
    }
}
