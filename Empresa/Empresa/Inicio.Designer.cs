namespace Empresa
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtListaProductos = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lstEstado = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dtListaProductos).BeginInit();
            SuspendLayout();
            // 
            // dtListaProductos
            // 
            dtListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtListaProductos.Location = new Point(41, 140);
            dtListaProductos.Name = "dtListaProductos";
            dtListaProductos.RowTemplate.Height = 29;
            dtListaProductos.Size = new Size(719, 242);
            dtListaProductos.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.Location = new Point(245, 49);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(96, 28);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(41, 49);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(198, 27);
            txtBuscar.TabIndex = 2;
            // 
            // lstEstado
            // 
            lstEstado.FormattingEnabled = true;
            lstEstado.ItemHeight = 20;
            lstEstado.Location = new Point(41, 82);
            lstEstado.Name = "lstEstado";
            lstEstado.Size = new Size(125, 24);
            lstEstado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 533);
            Controls.Add(lstEstado);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(dtListaProductos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtListaProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtListaProductos;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private ListBox lstEstado;
    }
}