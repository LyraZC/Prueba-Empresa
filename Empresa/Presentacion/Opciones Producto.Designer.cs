namespace Presentacion
{
    partial class Opciones_Producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpciones = new System.Windows.Forms.ComboBox();
            this.btnAgregarOp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgregarOpcion = new System.Windows.Forms.TextBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones del Producto";
            // 
            // cbOpciones
            // 
            this.cbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Location = new System.Drawing.Point(243, 12);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(160, 24);
            this.cbOpciones.TabIndex = 1;
            this.cbOpciones.SelectedIndexChanged += new System.EventHandler(this.cbOpciones_SelectedIndexChanged);
            // 
            // btnAgregarOp
            // 
            this.btnAgregarOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOp.Location = new System.Drawing.Point(243, 199);
            this.btnAgregarOp.Name = "btnAgregarOp";
            this.btnAgregarOp.Size = new System.Drawing.Size(152, 32);
            this.btnAgregarOp.TabIndex = 2;
            this.btnAgregarOp.Text = "Agregar";
            this.btnAgregarOp.UseVisualStyleBackColor = true;
            this.btnAgregarOp.Click += new System.EventHandler(this.btnAgregarOp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregar nueva opcion";
            // 
            // txtAgregarOpcion
            // 
            this.txtAgregarOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarOpcion.Location = new System.Drawing.Point(243, 152);
            this.txtAgregarOpcion.Name = "txtAgregarOpcion";
            this.txtAgregarOpcion.Size = new System.Drawing.Size(152, 24);
            this.txtAgregarOpcion.TabIndex = 4;
            // 
            // txtEditar
            // 
            this.txtEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditar.Location = new System.Drawing.Point(243, 54);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(152, 24);
            this.txtEditar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Editar Opcion Seleccionada";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(243, 101);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(152, 32);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Opciones_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 314);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtAgregarOpcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarOp);
            this.Controls.Add(this.cbOpciones);
            this.Controls.Add(this.label1);
            this.Name = "Opciones_Producto";
            this.Text = "Opciones_Producto";
            this.Load += new System.EventHandler(this.Opciones_Producto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOpciones;
        private System.Windows.Forms.Button btnAgregarOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgregarOpcion;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
    }
}