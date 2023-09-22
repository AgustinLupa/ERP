namespace SystemERP.View.Employee
{
    partial class EmployeeMenu
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnDeleteEmployee = new Button();
            btnCreateEmployee = new Button();
            btnEmployee = new Button();
            pMenu = new Panel();
            btnUpdateEmplo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 49);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.employee;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(286, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 92);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(btnUpdateEmplo);
            panel2.Controls.Add(btnDeleteEmployee);
            panel2.Controls.Add(btnCreateEmployee);
            panel2.Controls.Add(btnEmployee);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 512);
            panel2.TabIndex = 7;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.Image = Properties.Resources.deleteEmployee;
            btnDeleteEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteEmployee.Location = new Point(0, 146);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(147, 40);
            btnDeleteEmployee.TabIndex = 3;
            btnDeleteEmployee.Text = "Eliminar";
            btnDeleteEmployee.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEmployee.Image = Properties.Resources.NewEmployee;
            btnCreateEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateEmployee.Location = new Point(0, 82);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(147, 40);
            btnCreateEmployee.TabIndex = 2;
            btnCreateEmployee.Text = "Crear";
            btnCreateEmployee.TextAlign = ContentAlignment.MiddleRight;
            btnCreateEmployee.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            btnEmployee.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Image = Properties.Resources.listEmployee1;
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(0, 20);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(147, 40);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Listar";
            btnEmployee.TextAlign = ContentAlignment.MiddleRight;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // pMenu
            // 
            pMenu.BackColor = SystemColors.GradientActiveCaption;
            pMenu.Dock = DockStyle.Fill;
            pMenu.Location = new Point(147, 49);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(546, 512);
            pMenu.TabIndex = 8;
            // 
            // btnUpdateEmplo
            // 
            btnUpdateEmplo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmplo.Image = Properties.Resources.editar;
            btnUpdateEmplo.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdateEmplo.Location = new Point(0, 208);
            btnUpdateEmplo.Name = "btnUpdateEmplo";
            btnUpdateEmplo.Size = new Size(147, 40);
            btnUpdateEmplo.TabIndex = 4;
            btnUpdateEmplo.Text = "Modificar";
            btnUpdateEmplo.TextAlign = ContentAlignment.MiddleRight;
            btnUpdateEmplo.UseVisualStyleBackColor = true;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 561);
            Controls.Add(pMenu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnEmployee;
        private Panel pMenu;
        private Button btnDeleteEmployee;
        private Button btnCreateEmployee;
        private Button btnUpdateEmplo;
    }
}