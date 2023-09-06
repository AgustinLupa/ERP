namespace SystemERP.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            btnCashRegister = new Button();
            btnLogout = new Button();
            btnUser = new Button();
            btnBank = new Button();
            btnSales = new Button();
            btnEmployee = new Button();
            btnSupplier = new Button();
            btnProduct = new Button();
            btnTurnOver = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pMenu = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnCashRegister);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnBank);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnSupplier);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnTurnOver);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 561);
            panel1.TabIndex = 0;
            // 
            // btnCashRegister
            // 
            btnCashRegister.BackColor = SystemColors.Menu;
            btnCashRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCashRegister.Image = Properties.Resources.cash_register;
            btnCashRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnCashRegister.Location = new Point(3, 123);
            btnCashRegister.Name = "btnCashRegister";
            btnCashRegister.Size = new Size(218, 49);
            btnCashRegister.TabIndex = 2;
            btnCashRegister.Text = "Caja";
            btnCashRegister.UseVisualStyleBackColor = false;
            btnCashRegister.Click += btnCashRegister_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Menu;
            btnLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 466);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(218, 49);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = SystemColors.Menu;
            btnUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.Image = Properties.Resources.usuarios;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(3, 417);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(218, 49);
            btnUser.TabIndex = 8;
            btnUser.Text = "Usuarios";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnBank
            // 
            btnBank.BackColor = SystemColors.Menu;
            btnBank.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBank.Image = Properties.Resources.banco;
            btnBank.ImageAlign = ContentAlignment.MiddleLeft;
            btnBank.Location = new Point(3, 368);
            btnBank.Name = "btnBank";
            btnBank.Size = new Size(218, 49);
            btnBank.TabIndex = 7;
            btnBank.Text = "Bancos";
            btnBank.UseVisualStyleBackColor = false;
            // 
            // btnSales
            // 
            btnSales.BackColor = SystemColors.Menu;
            btnSales.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSales.Image = Properties.Resources.sale;
            btnSales.ImageAlign = ContentAlignment.MiddleLeft;
            btnSales.Location = new Point(3, 319);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(218, 49);
            btnSales.TabIndex = 6;
            btnSales.Text = "Ventas";
            btnSales.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = SystemColors.Menu;
            btnEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Image = Properties.Resources.empleados;
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(3, 270);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(218, 49);
            btnEmployee.TabIndex = 5;
            btnEmployee.Text = "Empleados";
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = SystemColors.Menu;
            btnSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupplier.Image = Properties.Resources.proveedor;
            btnSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplier.Location = new Point(3, 221);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(218, 49);
            btnSupplier.TabIndex = 4;
            btnSupplier.Text = "Proveedores";
            btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = SystemColors.Menu;
            btnProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.Image = Properties.Resources.package1;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(3, 172);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(218, 49);
            btnProduct.TabIndex = 3;
            btnProduct.Text = "Productos";
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnTurnOver
            // 
            btnTurnOver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTurnOver.BackColor = SystemColors.Menu;
            btnTurnOver.BackgroundImageLayout = ImageLayout.Stretch;
            btnTurnOver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTurnOver.Image = (Image)resources.GetObject("btnTurnOver.Image");
            btnTurnOver.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurnOver.Location = new Point(3, 74);
            btnTurnOver.Name = "btnTurnOver";
            btnTurnOver.Size = new Size(218, 49);
            btnTurnOver.TabIndex = 1;
            btnTurnOver.Text = "Facturacion";
            btnTurnOver.UseVisualStyleBackColor = false;
            btnTurnOver.Visible = false;
            btnTurnOver.KeyPress += Menu_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.proyecto;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 29);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 0;
            label1.Text = "Isekai Technology ©";
            // 
            // pMenu
            // 
            pMenu.BackColor = SystemColors.GradientInactiveCaption;
            pMenu.Dock = DockStyle.Fill;
            pMenu.Location = new Point(221, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(693, 561);
            pMenu.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 561);
            ControlBox = false;
            Controls.Add(pMenu);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            FormClosing += Menu_FormClosing;
            KeyPress += Menu_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTurnOver;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pMenu;
        private Button btnUser;
        private Button btnBank;
        private Button btnSales;
        private Button btnEmployee;
        private Button btnSupplier;
        private Button btnCashRegister;
        private Button btnProduct;
        private Button btnLogout;
    }
}