namespace frm10_mutipleDocumentInterface_exam
{
    partial class frmSignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.lblSignIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkShowPassword_SignIn = new System.Windows.Forms.CheckBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtUserNameSignIn = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasswordSignIn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCloseSignIn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignIn
            // 
            this.lblSignIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSignIn.Location = new System.Drawing.Point(205, 89);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(148, 47);
            this.lblSignIn.TabIndex = 0;
            this.lblSignIn.Text = "Sign In";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkShowPassword_SignIn);
            this.panel1.Controls.Add(this.lblSignUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Controls.Add(this.txtUserNameSignIn);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPasswordSignIn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSignIn);
            this.panel1.Location = new System.Drawing.Point(284, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 544);
            this.panel1.TabIndex = 1;
            // 
            // chkShowPassword_SignIn
            // 
            this.chkShowPassword_SignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkShowPassword_SignIn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkShowPassword_SignIn.Location = new System.Drawing.Point(300, 305);
            this.chkShowPassword_SignIn.Name = "chkShowPassword_SignIn";
            this.chkShowPassword_SignIn.Size = new System.Drawing.Size(126, 24);
            this.chkShowPassword_SignIn.TabIndex = 10;
            this.chkShowPassword_SignIn.Text = "Show password";
            this.chkShowPassword_SignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkShowPassword_SignIn.UseVisualStyleBackColor = true;
            this.chkShowPassword_SignIn.CheckedChanged += new System.EventHandler(this.chkShowPassword_SignIn_CheckedChanged);
            // 
            // lblSignUp
            // 
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSignUp.Location = new System.Drawing.Point(321, 400);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(67, 29);
            this.lblSignUp.TabIndex = 9;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignUp.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(160, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Don\'t have an account?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.Location = new System.Drawing.Point(145, 346);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(272, 29);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtUserNameSignIn
            // 
            this.txtUserNameSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserNameSignIn.Location = new System.Drawing.Point(145, 185);
            this.txtUserNameSignIn.Multiline = true;
            this.txtUserNameSignIn.Name = "txtUserNameSignIn";
            this.txtUserNameSignIn.Size = new System.Drawing.Size(272, 29);
            this.txtUserNameSignIn.TabIndex = 3;
            this.txtUserNameSignIn.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUsername.Location = new System.Drawing.Point(63, 186);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 23);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.Location = new System.Drawing.Point(63, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 23);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPasswordSignIn
            // 
            this.txtPasswordSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPasswordSignIn.Location = new System.Drawing.Point(145, 255);
            this.txtPasswordSignIn.Multiline = true;
            this.txtPasswordSignIn.Name = "txtPasswordSignIn";
            this.txtPasswordSignIn.PasswordChar = '*';
            this.txtPasswordSignIn.Size = new System.Drawing.Size(272, 29);
            this.txtPasswordSignIn.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblCloseSignIn
            // 
            this.lblCloseSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseSignIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCloseSignIn.Location = new System.Drawing.Point(1059, 9);
            this.lblCloseSignIn.Name = "lblCloseSignIn";
            this.lblCloseSignIn.Size = new System.Drawing.Size(29, 23);
            this.lblCloseSignIn.TabIndex = 2;
            this.lblCloseSignIn.Text = "X";
            this.lblCloseSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCloseSignIn.Click += new System.EventHandler(this.lblCloseSignIn_Click);
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.lblCloseSignIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPasswordSignIn;
        private System.Windows.Forms.TextBox txtUserNameSignIn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkShowPassword_SignIn;
        private System.Windows.Forms.Label lblCloseSignIn;
    }
}