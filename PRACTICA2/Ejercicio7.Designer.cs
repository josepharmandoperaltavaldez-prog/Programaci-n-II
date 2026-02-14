namespace PRACTICA2
{
    partial class Ejercicio7
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNuevoElemento = new System.Windows.Forms.TextBox();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(310, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar a la Lista";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNuevoElemento
            // 
            this.txtNuevoElemento.Location = new System.Drawing.Point(331, 237);
            this.txtNuevoElemento.Name = "txtNuevoElemento";
            this.txtNuevoElemento.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoElemento.TabIndex = 2;
            this.txtNuevoElemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.Location = new System.Drawing.Point(275, 285);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(207, 69);
            this.lstElementos.TabIndex = 3;
            // 
            // Ejercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.txtNuevoElemento);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Ejercicio7";
            this.Text = "Ejercicio7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNuevoElemento;
        private System.Windows.Forms.ListBox lstElementos;
    }
}