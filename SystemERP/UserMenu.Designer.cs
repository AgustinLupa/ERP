namespace SystemERP.View
{
    partial class UserMenu
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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel3 = new Panel();
            lvDescrip = new ListView();
            label4 = new Label();
            cbRole = new ComboBox();
            btnNewUser = new Button();
            txtNewPassword = new TextBox();
            label3 = new Label();
            txtNewNameUser = new TextBox();
            label2 = new Label();
            DescriptRol = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 49);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 473);
            panel2.TabIndex = 2;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.Location = new Point(10, 161);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(86, 25);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Mostrar";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(10, 121);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(85, 25);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Eliminar";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(10, 81);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 25);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Modificar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(10, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 25);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Crear";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvDescrip);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cbRole);
            panel3.Controls.Add(btnNewUser);
            panel3.Controls.Add(txtNewPassword);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtNewNameUser);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(115, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(547, 341);
            panel3.TabIndex = 3;
            // 
            // lvDescrip
            // 
            lvDescrip.BackColor = SystemColors.GradientInactiveCaption;
            lvDescrip.Columns.AddRange(new ColumnHeader[] { DescriptRol });
            lvDescrip.Location = new Point(16, 143);
            lvDescrip.Name = "lvDescrip";
            lvDescrip.Size = new Size(528, 132);
            lvDescrip.TabIndex = 8;
            lvDescrip.UseCompatibleStateImageBehavior = false;
            lvDescrip.View = System.Windows.Forms.View.Details;
            lvDescrip.Visible = false;
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
            cbRole.Size = new Size(128, 28);
            cbRole.TabIndex = 3;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // btnNewUser
            // 
            btnNewUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewUser.Location = new Point(421, 291);
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
            txtNewPassword.Size = new Size(254, 27);
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
            txtNewNameUser.Size = new Size(254, 27);
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
            // DescriptRol
            // 
            DescriptRol.Text = "Descripcion del rol";
            DescriptRol.Width = 520;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(677, 522);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMenu";
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel3;
        private Button btnNewUser;
        private TextBox txtNewPassword;
        private Label label3;
        private TextBox txtNewNameUser;
        private Label label2;
        private Label label4;
        private ComboBox cbRole;
        private ListView lvDescrip;
        private ColumnHeader DescriptRol;
    }
}