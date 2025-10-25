namespace InventoryApp.WinForms
{
    partial class ClientesForm
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
            dataGridViewClients = new DataGridView();
            txtNombre = new TextBox();
            txtNit = new TextBox();
            txtBuscar = new TextBox();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(28, 269);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 82;
            dataGridViewClients.Size = new Size(1181, 449);
            dataGridViewClients.TabIndex = 0;
            dataGridViewClients.CellClick += dataGridViewClients_CellClick;
            dataGridViewClients.UserDeletingRow += dataGridViewClients_UserDeletingRow;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(241, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 39);
            txtNombre.TabIndex = 1;
            // 
            // txtNit
            // 
            txtNit.Location = new Point(241, 107);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(252, 39);
            txtNit.TabIndex = 2;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(241, 171);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(252, 39);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(1000, 40);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 58);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "SAVE";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1000, 138);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(85, 72);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "NEW";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 46);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 99);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 7;
            label2.Text = "NIT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 169);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 8;
            label3.Text = "Buscar:";
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 745);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(txtBuscar);
            Controls.Add(txtNit);
            Controls.Add(txtNombre);
            Controls.Add(dataGridViewClients);
            Name = "ClientesForm";
            Text = "ClientesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewClients;
        private TextBox txtNombre;
        private TextBox txtNit;
        private TextBox txtBuscar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}