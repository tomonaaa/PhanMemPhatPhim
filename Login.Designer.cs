namespace Login1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btexit = new PictureBox();
            btsignup = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btlogin = new Button();
            txtUserName = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)btexit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btexit
            // 
            btexit.BackColor = SystemColors.ActiveCaption;
            btexit.Image = (Image)resources.GetObject("btexit.Image");
            btexit.Location = new Point(747, 0);
            btexit.Name = "btexit";
            btexit.Size = new Size(31, 28);
            btexit.SizeMode = PictureBoxSizeMode.Zoom;
            btexit.TabIndex = 9;
            btexit.TabStop = false;
            btexit.Click += btexit_Click;
            // 
            // btsignup
            // 
            btsignup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btsignup.ForeColor = Color.White;
            btsignup.Location = new Point(530, 281);
            btsignup.Name = "btsignup";
            btsignup.Size = new Size(79, 40);
            btsignup.TabIndex = 10;
            btsignup.Text = "SIGN UP";
            btsignup.Click += btsignup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(530, 289);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(378, 293);
            label2.Name = "label2";
            label2.Size = new Size(146, 19);
            label2.TabIndex = 6;
            label2.Text = "Don't have an account?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(453, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 35);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // btlogin
            // 
            btlogin.BackColor = SystemColors.ActiveCaption;
            btlogin.FlatAppearance.BorderSize = 0;
            btlogin.FlatAppearance.MouseDownBackColor = Color.Black;
            btlogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btlogin.FlatStyle = FlatStyle.Flat;
            btlogin.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btlogin.ForeColor = Color.Black;
            btlogin.Location = new Point(301, 225);
            btlogin.Margin = new Padding(2, 3, 2, 2);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(405, 51);
            btlogin.TabIndex = 3;
            btlogin.Text = "LOGIN";
            btlogin.UseVisualStyleBackColor = false;
            btlogin.Click += btlogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.InactiveCaptionText;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe Script", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.InactiveCaption;
            txtUserName.Location = new Point(301, 75);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(405, 34);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "UserName";
            txtUserName.Enter += txtUserName_Enter;
            txtUserName.Leave += txtUserName_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(301, 194);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 1);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(301, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 1);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(77, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 339);
            panel1.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPassword.BackColor = SystemColors.InactiveCaptionText;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe Script", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(301, 154);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(405, 38);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(780, 339);
            Controls.Add(btexit);
            Controls.Add(btsignup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btlogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Enter += Form1_Enter;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)btexit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btexit;
        private Button btsignup;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button btlogin;
        public TextBox txtUserName;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox txtPassword;
    }
}
