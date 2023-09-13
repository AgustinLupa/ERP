namespace SystemERP
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtPass = new TextBox();
            txtUser = new TextBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(237, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 40);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 375);
            panel2.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.AcceptsTab = true;
            txtPass.BackColor = SystemColors.GradientActiveCaption;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtPass.Location = new Point(194, 173);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(207, 35);
            txtPass.TabIndex = 2;
            txtPass.UseSystemPasswordChar = true;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // txtUser
            // 
            txtUser.AcceptsTab = true;
            txtUser.BackColor = SystemColors.GradientActiveCaption;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Sans Serif Collection", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(194, 70);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(207, 35);
            txtUser.TabIndex = 1;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(237, 241);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 65);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Iniciar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(194, 128);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 2;
            label3.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(194, 25);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = View.Properties.Resources.images__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(585, 475);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
    }
}