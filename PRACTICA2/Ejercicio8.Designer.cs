namespace PRACTICA2
{
    partial class Ejercicio8
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
            this.btnContar = new System.Windows.Forms.Button();
            this.lblConteo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContar.Location = new System.Drawing.Point(310, 169);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(148, 33);
            this.btnContar.TabIndex = 0;
            this.btnContar.Text = "Presionar";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteo.Location = new System.Drawing.Point(295, 225);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(179, 25);
            this.lblConteo.TabIndex = 1;
            this.lblConteo.Text = "Veces presionado: 0";
            // 
            // Ejercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.btnContar);
            this.Name = "Ejercicio8";
            this.Text = "Ejercicio8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblConteo;
    }
}