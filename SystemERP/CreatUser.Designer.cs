namespace SystemERP.View
{
    partial class CreatUser
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
            pCreate = new Panel();
            lvDescrip = new ListView();
            DescriptRol = new ColumnHeader();
            label4 = new Label();
            cbRole = new ComboBox();
            btnNewUser = new Button();
            txtNewPassword = new TextBox();
            label3 = new Label();
            txtNewNameUser = new TextBox();
            label2 = new Label();
            pCreate.SuspendLayout();
            SuspendLayout();
            // 
            // pCreate
            // 
            pCreate.BackColor = SystemColors.GradientActiveCaption;
            pCreate.Controls.Add(lvDescrip);
            pCreate.Controls.Add(label4);
            pCreate.Controls.Add(cbRole);
            pCreate.Controls.Add(btnNewUser);
            pCreate.Controls.Add(txtNewPassword);
            pCreate.Controls.Add(label3);
            pCreate.Controls.Add(txtNewNameUser);
            pCreate.Controls.Add(label2);
            pCreate.Dock = DockStyle.Fill;
            pCreate.Location = new Point(0, 0);
            pCreate.Name = "pCreate";
            pCreate.Size = new Size(565, 473);
            pCreate.TabIndex = 4;
            // 
            // lvDescrip
            // 
            lvDescrip.BackColor = SystemColors.GradientInactiveCaption;
            lvDescrip.Columns.AddRange(new ColumnHeader[] { DescriptRol });
            lvDescrip.Location = new Point(16, 143);
            lvDescrip.Name = "lvDescrip";
            lvDescrip.Size = new Size(528, 221);
            lvDescrip.TabIndex = 8;
            lvDescrip.UseCompatibleStateImageBehavior = false;
            lvDescrip.View = System.Windows.Forms.View.Details;
            lvDescrip.Visible = false;
            // 
            // DescriptRol
            // 
            DescriptRol.Text = "Descripcion del rol";
            DescriptRol.Width = 520;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 97);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 5;
            label4.Text = "Asignar Rol";
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(173, 97);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(262, 28);
            cbRole.TabIndex = 3;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // btnNewUser
            // 
            btnNewUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewUser.Location = new Point(421, 402);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(123, 42);
            btnNewUser.TabIndex = 4;
            btnNewUser.Text = "Crear usuario";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.Menu;
            txtNewPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(173, 52);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(371, 27);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 54);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 2;
            label3.Text = "Clave";
            // 
            // txtNewNameUser
            // 
            txtNewNameUser.BackColor = SystemColors.Menu;
            txtNewNameUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNewNameUser.Location = new Point(173, 16);
            txtNewNameUser.Name = "txtNewNameUser";
            txtNewNameUser.Size = new Size(371, 27);
            txtNewNameUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 0;
            label2.Text = "Nombre de usuario";
            // 
            // CreatUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 473);
            Controls.Add(pCreate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreatUser";
            Text = "CreatUser";
            pCreate.ResumeLayout(false);
            pCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pCreate;
        private ListView lvDescrip;
        private ColumnHeader DescriptRol;
        private Label label4;
        private ComboBox cbRole;
        private Button btnNewUser;
        private TextBox txtNewPassword;
        private Label label3;
        private TextBox txtNewNameUser;
        private Label label2;
    }
}