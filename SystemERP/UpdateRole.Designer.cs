namespace SystemERP.View
{
    partial class UpdateRole
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
            label3 = new Label();
            lbRole = new ListBox();
            lbPermissions = new ListBox();
            btnCreateRole = new Button();
            cbDelete = new CheckBox();
            cbUpdate = new CheckBox();
            cbAdd = new CheckBox();
            btnAddPermission = new Button();
            label1 = new Label();
            cbPermission = new ComboBox();
            label2 = new Label();
            txtRoleName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbRole);
            panel1.Controls.Add(lbPermissions);
            panel1.Controls.Add(btnCreateRole);
            panel1.Controls.Add(cbDelete);
            panel1.Controls.Add(cbUpdate);
            panel1.Controls.Add(cbAdd);
            panel1.Controls.Add(btnAddPermission);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbPermission);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtRoleName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 473);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 9);
            label3.Name = "label3";
            label3.Size = new Size(216, 21);
            label3.TabIndex = 20;
            label3.Text = "Seleccione el rol a modificar";
            // 
            // lbRole
            // 
            lbRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRole.FormattingEnabled = true;
            lbRole.HorizontalScrollbar = true;
            lbRole.ItemHeight = 21;
            lbRole.Location = new Point(27, 33);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(510, 88);
            lbRole.TabIndex = 19;
            lbRole.SelectedIndexChanged += lbRole_SelectedIndexChanged;
            // 
            // lbPermissions
            // 
            lbPermissions.DrawMode = DrawMode.OwnerDrawVariable;
            lbPermissions.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbPermissions.FormattingEnabled = true;
            lbPermissions.HorizontalScrollbar = true;
            lbPermissions.ItemHeight = 17;
            lbPermissions.Location = new Point(35, 313);
            lbPermissions.Name = "lbPermissions";
            lbPermissions.Size = new Size(502, 106);
            lbPermissions.TabIndex = 18;
            lbPermissions.MouseClick += lbPermissions_MouseClick;
            lbPermissions.DrawItem += lbPermissions_DrawItem;
            // 
            // btnCreateRole
            // 
            btnCreateRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateRole.Location = new Point(417, 423);
            btnCreateRole.Name = "btnCreateRole";
            btnCreateRole.Size = new Size(120, 47);
            btnCreateRole.TabIndex = 17;
            btnCreateRole.Text = "Modificar Rol";
            btnCreateRole.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            cbDelete.AutoSize = true;
            cbDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbDelete.Location = new Point(252, 266);
            cbDelete.Name = "cbDelete";
            cbDelete.Size = new Size(84, 24);
            cbDelete.TabIndex = 15;
            cbDelete.Text = "Eliminar";
            cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            cbUpdate.AutoSize = true;
            cbUpdate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbUpdate.Location = new Point(136, 266);
            cbUpdate.Name = "cbUpdate";
            cbUpdate.Size = new Size(94, 24);
            cbUpdate.TabIndex = 14;
            cbUpdate.Text = "Modificar";
            cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbAdd
            // 
            cbAdd.AutoSize = true;
            cbAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbAdd.Location = new Point(35, 266);
            cbAdd.Name = "cbAdd";
            cbAdd.Size = new Size(84, 24);
            cbAdd.TabIndex = 12;
            cbAdd.Text = "Agregar";
            cbAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddPermission
            // 
            btnAddPermission.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPermission.Location = new Point(399, 266);
            btnAddPermission.Name = "btnAddPermission";
            btnAddPermission.Size = new Size(138, 37);
            btnAddPermission.TabIndex = 16;
            btnAddPermission.Text = "Agregar Permiso";
            btnAddPermission.UseVisualStyleBackColor = true;
            btnAddPermission.Click += btnAddPermission_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 218);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 13;
            label1.Text = "Seleccione Permiso";
            // 
            // cbPermission
            // 
            cbPermission.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbPermission.FormattingEnabled = true;
            cbPermission.Location = new Point(184, 216);
            cbPermission.Name = "cbPermission";
            cbPermission.Size = new Size(242, 28);
            cbPermission.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 159);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 9;
            label2.Text = "Nombre del Rol";
            // 
            // txtRoleName
            // 
            txtRoleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoleName.Location = new Point(159, 156);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(378, 29);
            txtRoleName.TabIndex = 10;
            // 
            // UpdateRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 473);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateRole";
            Text = "UpdateRole";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ListBox lbRole;
        private ListBox lbPermissions;
        private Button btnCreateRole;
        private CheckBox cbDelete;
        private CheckBox cbUpdate;
        private CheckBox cbAdd;
        private Button btnAddPermission;
        private Label label1;
        private ComboBox cbPermission;
        private Label label2;
        private TextBox txtRoleName;
    }
}