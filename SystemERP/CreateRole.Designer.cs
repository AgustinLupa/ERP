namespace SystemERP.View
{
    partial class CreateRole
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRole));
            panel1 = new Panel();
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
            ilDelete = new ImageList(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
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
            // lbPermissions
            // 
            lbPermissions.DrawMode = DrawMode.OwnerDrawVariable;
            lbPermissions.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbPermissions.FormattingEnabled = true;
            lbPermissions.HorizontalScrollbar = true;
            lbPermissions.ItemHeight = 17;
            lbPermissions.Location = new Point(38, 177);
            lbPermissions.Name = "lbPermissions";
            lbPermissions.Size = new Size(502, 225);
            lbPermissions.TabIndex = 8;
            lbPermissions.MouseClick += lbPermissions_MouseClick;
            lbPermissions.DrawItem += lbPermissions_DrawItem;
            // 
            // btnCreateRole
            // 
            btnCreateRole.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateRole.Location = new Point(436, 414);
            btnCreateRole.Name = "btnCreateRole";
            btnCreateRole.Size = new Size(104, 47);
            btnCreateRole.TabIndex = 7;
            btnCreateRole.Text = "Crear Rol";
            btnCreateRole.UseVisualStyleBackColor = true;
            btnCreateRole.Click += btnCreateRole_Click;
            // 
            // cbDelete
            // 
            cbDelete.AutoSize = true;
            cbDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbDelete.Location = new Point(255, 122);
            cbDelete.Name = "cbDelete";
            cbDelete.Size = new Size(84, 24);
            cbDelete.TabIndex = 5;
            cbDelete.Text = "Eliminar";
            cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            cbUpdate.AutoSize = true;
            cbUpdate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbUpdate.Location = new Point(139, 122);
            cbUpdate.Name = "cbUpdate";
            cbUpdate.Size = new Size(94, 24);
            cbUpdate.TabIndex = 4;
            cbUpdate.Text = "Modificar";
            cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbAdd
            // 
            cbAdd.AutoSize = true;
            cbAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbAdd.Location = new Point(38, 122);
            cbAdd.Name = "cbAdd";
            cbAdd.Size = new Size(84, 24);
            cbAdd.TabIndex = 3;
            cbAdd.Text = "Agregar";
            cbAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddPermission
            // 
            btnAddPermission.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPermission.Location = new Point(402, 122);
            btnAddPermission.Name = "btnAddPermission";
            btnAddPermission.Size = new Size(138, 37);
            btnAddPermission.TabIndex = 6;
            btnAddPermission.Text = "Agregar Permiso";
            btnAddPermission.UseVisualStyleBackColor = true;
            btnAddPermission.Click += btnAddPermission_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 74);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 3;
            label1.Text = "Seleccione Permiso";
            // 
            // cbPermission
            // 
            cbPermission.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbPermission.FormattingEnabled = true;
            cbPermission.Location = new Point(187, 72);
            cbPermission.Name = "cbPermission";
            cbPermission.Size = new Size(242, 28);
            cbPermission.TabIndex = 2;
            cbPermission.SelectedIndexChanged += cbPermission_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 15);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Rol";
            // 
            // txtRoleName
            // 
            txtRoleName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoleName.Location = new Point(162, 12);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(378, 29);
            txtRoleName.TabIndex = 1;
            // 
            // ilDelete
            // 
            ilDelete.ColorDepth = ColorDepth.Depth8Bit;
            ilDelete.ImageStream = (ImageListStreamer)resources.GetObject("ilDelete.ImageStream");
            ilDelete.TransparentColor = Color.Transparent;
            ilDelete.Images.SetKeyName(0, "Delete-x.png");
            // 
            // CreateRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 473);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateRole";
            Text = "p;loooo09ooooooooooooooo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtRoleName;
        private Button btnAddPermission;
        private Label label1;
        private ComboBox cbPermission;
        private Label label2;
        private CheckBox cbDelete;
        private CheckBox cbUpdate;
        private CheckBox cbAdd;
        private Button btnCreateRole;
        private ImageList ilDelete;
        private ListBox lbPermissions;
    }
}