namespace PRACTICA2
{
    partial class Ejercicio11
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnMostrarFecha = new System.Windows.Forms.Button();
            this.lblFechaResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(281, 146);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // btnMostrarFecha
            // 
            this.btnMostrarFecha.Location = new System.Drawing.Point(170, 197);
            this.btnMostrarFecha.Name = "btnMostrarFecha";
            this.btnMostrarFecha.Size = new System.Drawing.Size(190, 23);
            this.btnMostrarFecha.TabIndex = 1;
            this.btnMostrarFecha.Text = "Mostrar Fecha Seleccionada";
            this.btnMostrarFecha.UseVisualStyleBackColor = true;
            this.btnMostrarFecha.Click += new System.EventHandler(this.btnMostrarFecha_Click);
            // 
            // lblFechaResultado
            // 
            this.lblFechaResultado.AutoSize = true;
            this.lblFechaResultado.BackColor = System.Drawing.Color.Lime;
            this.lblFechaResultado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaResultado.Location = new System.Drawing.Point(416, 200);
            this.lblFechaResultado.Name = "lblFechaResultado";
            this.lblFechaResultado.Size = new System.Drawing.Size(64, 20);
            this.lblFechaResultado.TabIndex = 2;
            this.lblFechaResultado.Text = "La fecha";
            this.lblFechaResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ejercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaResultado);
            this.Controls.Add(this.btnMostrarFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "Ejercicio11";
            this.Text = "Ejercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnMostrarFecha;
        private System.Windows.Forms.Label lblFechaResultado;
    }
}