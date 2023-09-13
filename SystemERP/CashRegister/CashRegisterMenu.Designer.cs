namespace SystemERP.View
{
    partial class CashRegisterMenu
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
            button3 = new Button();
            button2 = new Button();
            btnAddPurchase = new Button();
            button1 = new Button();
            btnCloseResgister = new Button();
            btnOpenRegister = new Button();
            btnNewSale = new Button();
            panel3 = new Panel();
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
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Caja_titulo1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(312, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 92);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnAddPurchase);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnCloseResgister);
            panel2.Controls.Add(btnOpenRegister);
            panel2.Controls.Add(btnNewSale);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 512);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.atrasado2;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 320);
            button3.Name = "button3";
            button3.Size = new Size(147, 40);
            button3.TabIndex = 12;
            button3.Text = "Nuevo deuda";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.Gasto1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 260);
            button2.Name = "button2";
            button2.Size = new Size(147, 40);
            button2.TabIndex = 11;
            button2.Text = "Nuevo gasto";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAddPurchase
            // 
            btnAddPurchase.Enabled = false;
            btnAddPurchase.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPurchase.Image = Properties.Resources.bolsa_de_la_compra;
            btnAddPurchase.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddPurchase.Location = new Point(0, 200);
            btnAddPurchase.Name = "btnAddPurchase";
            btnAddPurchase.Size = new Size(147, 40);
            btnAddPurchase.TabIndex = 10;
            btnAddPurchase.Text = "Nueva compra";
            btnAddPurchase.TextAlign = ContentAlignment.MiddleRight;
            btnAddPurchase.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.lista_de_verificacion1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 140);
            button1.Name = "button1";
            button1.Size = new Size(147, 40);
            button1.TabIndex = 9;
            button1.Text = "Mostrar listado";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCloseResgister
            // 
            btnCloseResgister.Enabled = false;
            btnCloseResgister.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseResgister.Image = Properties.Resources.close_padlock;
            btnCloseResgister.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseResgister.Location = new Point(0, 380);
            btnCloseResgister.Name = "btnCloseResgister";
            btnCloseResgister.Size = new Size(147, 40);
            btnCloseResgister.TabIndex = 8;
            btnCloseResgister.Text = "Cerrar Caja";
            btnCloseResgister.TextAlign = ContentAlignment.MiddleRight;
            btnCloseResgister.UseVisualStyleBackColor = true;
            // 
            // btnOpenRegister
            // 
            btnOpenRegister.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenRegister.Image = Properties.Resources.desbloquear1;
            btnOpenRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpenRegister.Location = new Point(0, 20);
            btnOpenRegister.Name = "btnOpenRegister";
            btnOpenRegister.Size = new Size(147, 40);
            btnOpenRegister.TabIndex = 7;
            btnOpenRegister.Text = "Abrir Caja";
            btnOpenRegister.TextAlign = ContentAlignment.MiddleRight;
            btnOpenRegister.UseVisualStyleBackColor = true;
            // 
            // btnNewSale
            // 
            btnNewSale.Enabled = false;
            btnNewSale.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewSale.Image = Properties.Resources.carrito;
            btnNewSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewSale.Location = new Point(0, 80);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(147, 40);
            btnNewSale.TabIndex = 5;
            btnNewSale.Text = "Nueva venta";
            btnNewSale.TextAlign = ContentAlignment.MiddleRight;
            btnNewSale.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(147, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(546, 512);
            panel3.TabIndex = 7;
            // 
            // CashRegisterMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashRegisterMenu";
            Text = "CashRegister";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button2;
        private Button btnAddPurchase;
        private Button button1;
        private Button btnCloseResgister;
        private Button btnOpenRegister;
        private Button btnNewSale;
        private Panel panel3;
        private Button button3;
    }
}