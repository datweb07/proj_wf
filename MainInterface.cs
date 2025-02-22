using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm10_mutipleDocumentInterface_exam
{
    public partial class frmMainInterface : Form
    {
        public frmMainInterface()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmSignIn frmSignIn = new frmSignIn();
            frmSignIn.Show();
        }

        private void lblCloseSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
