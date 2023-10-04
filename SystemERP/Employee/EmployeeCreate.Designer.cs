namespace SystemERP.View.Employee
{
    partial class EmployeeCreate
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
            lResult = new Label();
            pbVerifyCod = new PictureBox();
            mtbDni = new MaskedTextBox();
            btnCreate = new Button();
            numCodEmplo = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVerifyCod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCodEmplo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(lResult);
            panel1.Controls.Add(pbVerifyCod);
            panel1.Controls.Add(mtbDni);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(numCodEmplo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 512);
            panel1.TabIndex = 0;
            // 
            // lResult
            // 
            lResult.AutoSize = true;
            lResult.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lResult.Location = new Point(392, 169);
            lResult.Name = "lResult";
            lResult.Size = new Size(43, 17);
            lResult.TabIndex = 12;
            lResult.Text = "label5";
            lResult.Visible = false;
            // 
            // pbVerifyCod
            // 
            pbVerifyCod.BackgroundImage = Properties.Resources.ok;
            pbVerifyCod.BackgroundImageLayout = ImageLayout.Stretch;
            pbVerifyCod.Location = new Point(341, 165);
            pbVerifyCod.Name = "pbVerifyCod";
            pbVerifyCod.Size = new Size(30, 29);
            pbVerifyCod.TabIndex = 11;
            pbVerifyCod.TabStop = false;
            pbVerifyCod.Visible = false;
            // 
            // mtbDni
            // 
            mtbDni.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mtbDni.Location = new Point(202, 117);
            mtbDni.Mask = "999999999";
            mtbDni.Name = "mtbDni";
            mtbDni.Size = new Size(120, 29);
            mtbDni.TabIndex = 10;
            mtbDni.TextAlign = HorizontalAlignment.Center;
            mtbDni.ValidatingType = typeof(int);
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ButtonFace;
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(364, 429);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 55);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Crear Empleado";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // numCodEmplo
            // 
            numCodEmplo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numCodEmplo.Location = new Point(202, 162);
            numCodEmplo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCodEmplo.Name = "numCodEmplo";
            numCodEmplo.Size = new Size(120, 29);
            numCodEmplo.TabIndex = 8;
            numCodEmplo.TextAlign = HorizontalAlignment.Center;
            numCodEmplo.ValueChanged += numCodEmplo_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 165);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 7;
            label4.Text = "Cod. empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 120);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 15);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(202, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(312, 29);
            txtLastName.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(202, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 29);
            txtName.TabIndex = 0;
            // 
            // EmployeeCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeCreate";
            Text = "EmployeeCreate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVerifyCod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCodEmplo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtName;
        private Button btnCreate;
        private NumericUpDown numCodEmplo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private Label lResult;
        private PictureBox pbVerifyCod;
        private MaskedTextBox mtbDni;
    }
}