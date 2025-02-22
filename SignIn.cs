using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frm10_mutipleDocumentInterface_exam
{
    public partial class frmSignIn : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH DAT\OneDrive\ドキュメント\signInData.mdf;Integrated Security=True;Connect Timeout=30");
        public frmSignIn()
        {
            InitializeComponent();

        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUserNameSignIn.Text == "" || txtPasswordSignIn.Text == "")
            {
                MessageBox.Show("Please fill in the required fields", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    try
                    {
                        sqlConnection.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND password = @password"; 
                        using(SqlCommand cmd = new SqlCommand(selectData, sqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUserNameSignIn.Text);
                            cmd.Parameters.AddWithValue("@password", txtPasswordSignIn.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count >= 1)
                            {
                                MessageBox.Show("Sign in successfully", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmMainInterface frmMainInterface = new frmMainInterface();
                                frmMainInterface.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username or password is incorrect", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to database: " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.Show();
            this.Hide();
        }

        private void lblCloseSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkShowPassword_SignIn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword_SignIn.Checked)
            {
                txtPasswordSignIn.UseSystemPasswordChar = true;
            }
            else txtPasswordSignIn.UseSystemPasswordChar = false;
        }
    }
}
