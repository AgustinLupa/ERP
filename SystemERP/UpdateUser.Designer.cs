namespace SystemERP.View
{
    partial class UpdateUser
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
            panel1 = new Panel();
            label5 = new Label();
            txtFilter = new TextBox();
            cbChangePass = new CheckBox();
            rbDisable = new RadioButton();
            rbEnable = new RadioButton();
            lbUsers = new ListBox();
            btnUpdateUser = new Button();
            lvDescrip = new ListView();
            DescriptRol = new ColumnHeader();
            label4 = new Label();
            cbRole = new ComboBox();
            txtNewPassword = new TextBox();
            label3 = new Label();
            txtNewNameUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFilter);
            panel1.Controls.Add(cbChangePass);
            panel1.Controls.Add(rbDisable);
            panel1.Controls.Add(rbEnable);
            panel1.Controls.Add(lbUsers);
            panel1.Controls.Add(btnUpdateUser);
            panel1.Controls.Add(lvDescrip);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbRole);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNewNameUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 473);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 11);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 20;
            label5.Text = "Filtrar por nombre";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(166, 12);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(387, 23);
            txtFilter.TabIndex = 19;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // cbChangePass
            // 
            cbChangePass.AutoSize = true;
            cbChangePass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbChangePass.Location = new Point(24, 213);
            cbChangePass.Name = "cbChangePass";
            cbChangePass.Size = new Size(103, 19);
            cbChangePass.TabIndex = 18;
            cbChangePass.Text = "Cambiar Clave";
            cbChangePass.UseVisualStyleBackColor = true;
            cbChangePass.CheckedChanged += cbChangePass_CheckedChanged;
            // 
            // rbDisable
            // 
            rbDisable.AutoSize = true;
            rbDisable.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbDisable.Location = new Point(400, 287);
            rbDisable.Name = "rbDisable";
            rbDisable.Size = new Size(112, 24);
            rbDisable.TabIndex = 6;
            rbDisable.TabStop = true;
            rbDisable.Text = "Desabilitado";
            rbDisable.TextAlign = ContentAlignment.MiddleCenter;
            rbDisable.UseVisualStyleBackColor = true;
            // 
            // rbEnable
            // 
            rbEnable.AutoSize = true;
            rbEnable.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbEnable.Location = new Point(230, 287);
            rbEnable.Name = "rbEnable";
            rbEnable.Size = new Size(98, 24);
            rbEnable.TabIndex = 5;
            rbEnable.TabStop = true;
            rbEnable.Text = "Habilitado";
            rbEnable.UseVisualStyleBackColor = true;
            // 
            // lbUsers
            // 
            lbUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsers.FormattingEnabled = true;
            lbUsers.HorizontalScrollbar = true;
            lbUsers.ItemHeight = 17;
            lbUsers.Location = new Point(23, 72);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(530, 72);
            lbUsers.TabIndex = 17;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateUser.Location = new Point(400, 420);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(153, 45);
            btnUpdateUser.TabIndex = 7;
            btnUpdateUser.Text = "Modificar usuario";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // lvDescrip
            // 
            lvDescrip.BackColor = SystemColors.GradientInactiveCaption;
            lvDescrip.Columns.AddRange(new ColumnHeader[] { DescriptRol });
            lvDescrip.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lvDescrip.Location = new Point(24, 317);
            lvDescrip.Name = "lvDescrip";
            lvDescrip.Size = new Size(529, 97);
            lvDescrip.TabIndex = 15;
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
            label4.Location = new Point(151, 252);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 14;
            label4.Text = "Asignar Rol";
            // 
            // cbRole
            // 
            cbRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(256, 250);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(297, 28);
            cbRole.TabIndex = 4;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = SystemColors.Menu;
            txtNewPassword.Enabled = false;
            txtNewPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(256, 207);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(297, 27);
            txtNewPassword.TabIndex = 3;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(151, 209);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 12;
            label3.Text = "Nueva Clave";
            // 
            // txtNewNameUser
            // 
            txtNewNameUser.BackColor = SystemColors.Menu;
            txtNewNameUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNewNameUser.Location = new Point(230, 169);
            txtNewNameUser.Name = "txtNewNameUser";
            txtNewNameUser.Size = new Size(323, 27);
            txtNewNameUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 171);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 9;
            label2.Text = "Nuevo nombre de usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 48);
            label1.Name = "label1";
            label1.Size = new Size(304, 21);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el usuario o fltre por nombre";
            // 
            // UpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 473);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateUser";
            Text = "UpdateUser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListView lvDescrip;
        private ColumnHeader DescriptRol;
        private Label label4;
        private ComboBox cbRole;
        private TextBox txtNewPassword;
        private Label label3;
        private TextBox txtNewNameUser;
        private Label label2;
        private Button btnUpdateUser;
        private ListBox lbUsers;
        private RadioButton rbDisable;
        private RadioButton rbEnable;
        private CheckBox cbChangePass;
        private Label label5;
        private TextBox txtFilter;
    }
}