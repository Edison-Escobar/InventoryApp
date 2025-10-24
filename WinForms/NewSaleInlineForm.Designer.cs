namespace InventoryApp.WinForms
{
    partial class NewSaleInlineForm
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
            cmbCliente = new ComboBox();
            btnConfirmarVenta = new Button();
            lblTotal = new Label();
            gridCart = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cmbCliente);
            panel1.Controls.Add(btnConfirmarVenta);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(gridCart);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1287, 749);
            panel1.TabIndex = 0;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(13, 145);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(260, 28);
            cmbCliente.TabIndex = 3;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(1176, 271);
            btnConfirmarVenta.Margin = new Padding(3, 4, 3, 4);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(86, 31);
            btnConfirmarVenta.TabIndex = 2;
            btnConfirmarVenta.Text = "Confirmar";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(13, 259);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(182, 41);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total: Q 0.00";
            // 
            // gridCart
            // 
            gridCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCart.Location = new Point(13, 327);
            gridCart.Margin = new Padding(3, 4, 3, 4);
            gridCart.Name = "gridCart";
            gridCart.RowHeadersWidth = 51;
            gridCart.Size = new Size(1265, 411);
            gridCart.TabIndex = 0;
            gridCart.CellContentClick += gridCart_CellContentClick;
            // 
            // NewSaleInlineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 755);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewSaleInlineForm";
            Text = "NewSaleInlineForm";
            Load += NewSaleInlineForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbCliente;
        private Button btnConfirmarVenta;
        private Label lblTotal;
        private DataGridView gridCart;
    }
}