using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace frm10_mutipleDocumentInterface_exam
{
    public partial class frmSignUp : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THANH DAT\OneDrive\ドキュメント\signInData.mdf;Integrated Security=True;Connect Timeout=30");
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordSignUp.Checked)
            {
                txtPasswordSignUp.UseSystemPasswordChar = true;
            } 
            else txtPasswordSignUp.UseSystemPasswordChar = false;
                
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.Show();
            this.Hide();
        }

        private void lblCloseSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                try
                {
                    sqlConnection.Open();
                    String checkUserName = "SELECT * FROM admin WHERE username = '" + txtNameSignUp.Text.Trim() + "'";

                    using (SqlCommand sqlCommand = new SqlCommand(checkUserName, sqlConnection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count >= 1)
                        {
                            MessageBox.Show("This username is already taken, please choose another one", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (txtNameSignUp.Text == "" || txtPasswordSignUp.Text == "" || txtEmailSignUp.Text=="")
                            {
                                MessageBox.Show("Please fill in all fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, password, date_created) VALUES (@email, @username, @password, @date)";
                                DateTime date = DateTime.Today;
                                using (SqlCommand sqlCommand1 = new SqlCommand(insertData, sqlConnection))
                                {
                                    sqlCommand1.Parameters.AddWithValue("@email", txtEmailSignUp.Text.Trim());
                                    sqlCommand1.Parameters.AddWithValue("@username", txtNameSignUp.Text.Trim());
                                    sqlCommand1.Parameters.AddWithValue("@password", txtPasswordSignUp.Text.Trim());
                                    sqlCommand1.Parameters.AddWithValue("@date", date);


                                    sqlCommand1.ExecuteNonQuery();
                                    MessageBox.Show("Sign up successfully", "Success message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //change form
                                    frmSignIn frmSignIn = new frmSignIn();
                                    frmSignIn.Show();
                                    this.Hide();
                                }
                            }
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
}
