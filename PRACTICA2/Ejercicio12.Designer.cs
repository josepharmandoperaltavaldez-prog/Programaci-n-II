namespace PRACTICA2
{
    partial class Ejercicio12
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultadoF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(282, 230);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(114, 20);
            this.txtCelsius.TabIndex = 0;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(363, 149);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(137, 53);
            this.btnConvertir.TabIndex = 1;
            this.btnConvertir.Text = "Convertir a Fahrenheit";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultadoF
            // 
            this.lblResultadoF.AutoSize = true;
            this.lblResultadoF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblResultadoF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoF.Location = new System.Drawing.Point(445, 230);
            this.lblResultadoF.Name = "lblResultadoF";
            this.lblResultadoF.Size = new System.Drawing.Size(107, 20);
            this.lblResultadoF.TabIndex = 2;
            this.lblResultadoF.Text = "Resultado: 0 °F";
            this.lblResultadoF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ejercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultadoF);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtCelsius);
            this.Name = "Ejercicio12";
            this.Text = "Ejercicio12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultadoF;
    }
}