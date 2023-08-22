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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRole));
            panel1 = new Panel();
            button1 = new Button();
            dgvPermission = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            DeleteColum = new DataGridViewImageColumn();
            descriptioncolum = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermission).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dgvPermission);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 473);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(446, 111);
            button1.Name = "button1";
            button1.Size = new Size(86, 37);
            button1.TabIndex = 5;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvPermission
            // 
            dgvPermission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermission.Columns.AddRange(new DataGridViewColumn[] { DeleteColum, descriptioncolum });
            dgvPermission.Location = new Point(30, 164);
            dgvPermission.Name = "dgvPermission";
            dgvPermission.RowTemplate.Height = 25;
            dgvPermission.Size = new Size(502, 187);
            dgvPermission.TabIndex = 4;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(187, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 23);
            comboBox1.TabIndex = 2;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(187, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(345, 29);
            textBox1.TabIndex = 0;
            // 
            // DeleteColum
            // 
            DeleteColum.HeaderText = "";
            DeleteColum.Image = (Image)resources.GetObject("DeleteColum.Image");
            DeleteColum.Name = "DeleteColum";
            DeleteColum.ToolTipText = "Sacar Permiso De La lista";
            DeleteColum.Width = 50;
            // 
            // descriptioncolum
            // 
            descriptioncolum.HeaderText = "Descripcion del permiso";
            descriptioncolum.Name = "descriptioncolum";
            descriptioncolum.ReadOnly = true;
            descriptioncolum.Width = 408;
            // 
            // CreateRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 473);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateRole";
            Text = "CreateRole";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermission).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dgvPermission;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private DataGridViewImageColumn DeleteColum;
        private DataGridViewTextBoxColumn descriptioncolum;
    }
}