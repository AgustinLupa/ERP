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
            rbDelete = new RadioButton();
            rbEdit = new RadioButton();
            rbCreate = new RadioButton();
            pformCreate = new Panel();
            rbCreateRole = new RadioButton();
            rbUpdateRole = new RadioButton();
            rbDeleteRole = new RadioButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 49);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(rbDeleteRole);
            panel2.Controls.Add(rbUpdateRole);
            panel2.Controls.Add(rbCreateRole);
            panel2.Controls.Add(rbDelete);
            panel2.Controls.Add(rbEdit);
            panel2.Controls.Add(rbCreate);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 473);
            panel2.TabIndex = 2;
            // 
            // rbDelete
            // 
            rbDelete.AutoSize = true;
            rbDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbDelete.Location = new Point(3, 110);
            rbDelete.Name = "rbDelete";
            rbDelete.Size = new Size(77, 21);
            rbDelete.TabIndex = 2;
            rbDelete.Text = "Eliminar";
            rbDelete.UseVisualStyleBackColor = true;
            rbDelete.CheckedChanged += rbEdit_CheckedChanged;
            // 
            // rbEdit
            // 
            rbEdit.AutoSize = true;
            rbEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbEdit.Location = new Point(3, 70);
            rbEdit.Name = "rbEdit";
            rbEdit.Size = new Size(85, 21);
            rbEdit.TabIndex = 1;
            rbEdit.Text = "Modificar";
            rbEdit.UseVisualStyleBackColor = true;
            rbEdit.CheckedChanged += rbEdit_CheckedChanged;
            // 
            // rbCreate
            // 
            rbCreate.AutoSize = true;
            rbCreate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbCreate.Location = new Point(3, 30);
            rbCreate.Name = "rbCreate";
            rbCreate.Size = new Size(63, 20);
            rbCreate.TabIndex = 0;
            rbCreate.Text = "Crear";
            rbCreate.UseVisualStyleBackColor = true;
            rbCreate.CheckedChanged += rbEdit_CheckedChanged;
            // 
            // pformCreate
            // 
            pformCreate.Dock = DockStyle.Fill;
            pformCreate.Location = new Point(112, 49);
            pformCreate.Name = "pformCreate";
            pformCreate.Size = new Size(565, 473);
            pformCreate.TabIndex = 3;
            // 
            // rbCreateRole
            // 
            rbCreateRole.AutoSize = true;
            rbCreateRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbCreateRole.Location = new Point(3, 150);
            rbCreateRole.Name = "rbCreateRole";
            rbCreateRole.Size = new Size(82, 21);
            rbCreateRole.TabIndex = 3;
            rbCreateRole.Text = "Crear Rol";
            rbCreateRole.UseVisualStyleBackColor = true;
            rbCreateRole.CheckedChanged += rbEdit_CheckedChanged;
            // 
            // rbUpdateRole
            // 
            rbUpdateRole.AutoSize = true;
            rbUpdateRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbUpdateRole.Location = new Point(3, 190);
            rbUpdateRole.Name = "rbUpdateRole";
            rbUpdateRole.Size = new Size(109, 21);
            rbUpdateRole.TabIndex = 4;
            rbUpdateRole.Text = "Modificar Rol";
            rbUpdateRole.UseVisualStyleBackColor = true;
            rbUpdateRole.CheckedChanged += rbEdit_CheckedChanged;
            // 
            // rbDeleteRole
            // 
            rbDeleteRole.AutoSize = true;
            rbDeleteRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbDeleteRole.Location = new Point(3, 230);
            rbDeleteRole.Name = "rbDeleteRole";
            rbDeleteRole.Size = new Size(101, 21);
            rbDeleteRole.TabIndex = 5;
            rbDeleteRole.Text = "Eliminar Rol";
            rbDeleteRole.UseVisualStyleBackColor = true;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(677, 522);
            ControlBox = false;
            Controls.Add(pformCreate);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMenu";
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private RadioButton rbDelete;
        private RadioButton rbEdit;
        private RadioButton rbCreate;
        private Panel pformCreate;
        private RadioButton rbUpdateRole;
        private RadioButton rbCreateRole;
        private RadioButton rbDeleteRole;
    }
}