namespace SystemERP.View.CashRegisterMenu
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
            label1 = new Label();
            panel2 = new Panel();
            btnAddPurchase = new Button();
            button1 = new Button();
            btnCloseResgister = new Button();
            btnOperRegister = new Button();
            btnNewSale = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(677, 49);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "Caja";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnAddPurchase);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnCloseResgister);
            panel2.Controls.Add(btnOperRegister);
            panel2.Controls.Add(btnNewSale);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 473);
            panel2.TabIndex = 3;
            // 
            // btnAddPurchase
            // 
            btnAddPurchase.Enabled = false;
            btnAddPurchase.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPurchase.Image = Properties.Resources.bolsa_de_la_compra;
            btnAddPurchase.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddPurchase.Location = new Point(0, 158);
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
            button1.Location = new Point(0, 112);
            button1.Name = "button1";
            button1.Size = new Size(147, 40);
            button1.TabIndex = 9;
            button1.Text = "Listado ventas";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCloseResgister
            // 
            btnCloseResgister.Enabled = false;
            btnCloseResgister.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseResgister.Image = Properties.Resources.close_padlock;
            btnCloseResgister.ImageAlign = ContentAlignment.MiddleLeft;
            btnCloseResgister.Location = new Point(0, 301);
            btnCloseResgister.Name = "btnCloseResgister";
            btnCloseResgister.Size = new Size(147, 40);
            btnCloseResgister.TabIndex = 8;
            btnCloseResgister.Text = "Cerrar Caja";
            btnCloseResgister.TextAlign = ContentAlignment.MiddleRight;
            btnCloseResgister.UseVisualStyleBackColor = true;
            // 
            // btnOperRegister
            // 
            btnOperRegister.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOperRegister.Image = Properties.Resources.desbloquear1;
            btnOperRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnOperRegister.Location = new Point(0, 20);
            btnOperRegister.Name = "btnOperRegister";
            btnOperRegister.Size = new Size(147, 40);
            btnOperRegister.TabIndex = 7;
            btnOperRegister.Text = "Abrir Caja";
            btnOperRegister.TextAlign = ContentAlignment.MiddleRight;
            btnOperRegister.UseVisualStyleBackColor = true;
            // 
            // btnNewSale
            // 
            btnNewSale.Enabled = false;
            btnNewSale.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewSale.Image = Properties.Resources.carrito;
            btnNewSale.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewSale.Location = new Point(0, 66);
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
            panel3.Size = new Size(530, 473);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.Gasto1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 204);
            button2.Name = "button2";
            button2.Size = new Size(147, 40);
            button2.TabIndex = 11;
            button2.Text = "Nuevo gasto";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // CashRegisterMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 522);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashRegisterMenu";
            Text = "CashRegisterMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnNewSale;
        private Panel panel3;
        private Button btnAddPurchase;
        private Button button1;
        private Button btnCloseResgister;
        private Button btnOperRegister;
        private Button button2;
    }
}