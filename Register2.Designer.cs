namespace Login1
{
    partial class Register2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register2));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btexit = new PictureBox();
            btsignup = new Button();
            label3 = new Label();
            label2 = new Label();
            btRegister = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            panel3 = new Panel();
            panel2 = new Panel();
            txtConfirm = new TextBox();
            panel4 = new Panel();
            btLogin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btexit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 369);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btexit
            // 
            btexit.BackColor = SystemColors.ActiveCaption;
            btexit.Image = (Image)resources.GetObject("btexit.Image");
            btexit.Location = new Point(771, 0);
            btexit.Name = "btexit";
            btexit.Size = new Size(31, 28);
            btexit.SizeMode = PictureBoxSizeMode.Zoom;
            btexit.TabIndex = 20;
            btexit.TabStop = false;
            btexit.Click += btexit_Click_1;
            // 
            // btsignup
            // 
            btsignup.Location = new Point(0, 0);
            btsignup.Name = "btsignup";
            btsignup.Size = new Size(75, 23);
            btsignup.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(527, 310);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(364, 324);
            label2.Name = "label2";
            label2.Size = new Size(157, 19);
            label2.TabIndex = 18;
            label2.Text = "Already have an account?";
            // 
            // btRegister
            // 
            btRegister.BackColor = SystemColors.ActiveCaption;
            btRegister.FlatAppearance.BorderSize = 0;
            btRegister.FlatAppearance.MouseDownBackColor = Color.Black;
            btRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btRegister.FlatStyle = FlatStyle.Flat;
            btRegister.Font = new Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btRegister.ForeColor = Color.Black;
            btRegister.Location = new Point(302, 265);
            btRegister.Margin = new Padding(2, 3, 2, 2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(405, 43);
            btRegister.TabIndex = 15;
            btRegister.Text = "REGISTER";
            btRegister.UseVisualStyleBackColor = false;
            btRegister.Click += btRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Rockwell Extra Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(415, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 35);
            label1.TabIndex = 17;
            label1.Text = "Get Started";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPassword.BackColor = SystemColors.InactiveCaptionText;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe Script", 10.8F);
            txtPassword.ForeColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(302, 127);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(405, 39);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.InactiveCaptionText;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe Script", 10.8F);
            txtUserName.ForeColor = SystemColors.InactiveCaption;
            txtUserName.Location = new Point(302, 62);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(405, 35);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "UserName";
            txtUserName.Enter += txtUserName_Enter;
            txtUserName.Leave += txtUserName_Leave;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(302, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(405, 1);
            panel3.TabIndex = 14;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(302, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 1);
            panel2.TabIndex = 12;
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = SystemColors.InactiveCaptionText;
            txtConfirm.BorderStyle = BorderStyle.None;
            txtConfirm.Font = new Font("Segoe Script", 10.8F);
            txtConfirm.ForeColor = SystemColors.InactiveCaption;
            txtConfirm.Location = new Point(302, 197);
            txtConfirm.Multiline = true;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(405, 35);
            txtConfirm.TabIndex = 3;
            txtConfirm.Text = "Confirm Password";
            txtConfirm.Enter += txtConfirm_Enter;
            txtConfirm.Leave += txtConfirm_Leave;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(302, 234);
            panel4.Name = "panel4";
            panel4.Size = new Size(405, 1);
            panel4.TabIndex = 22;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.White;
            btLogin.Location = new Point(527, 320);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(88, 37);
            btLogin.TabIndex = 24;
            btLogin.Text = "LOGIN";
            btLogin.Click += btLogin_Click;
            // 
            // Register2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(804, 369);
            Controls.Add(btLogin);
            Controls.Add(txtConfirm);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(btexit);
            Controls.Add(btsignup);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btRegister);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register2";
            Opacity = 0.9D;
            Text = "Form2";
            Load += Form2_Load;
            Enter += Form2_Enter;
            MouseDown += Form2_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btexit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox btexit;
        private Button btsignup;
        private Label label3;
        private Label label2;
        private Button btRegister;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtConfirm;
        private Panel panel4;
        private Button btLogin;
    }
}