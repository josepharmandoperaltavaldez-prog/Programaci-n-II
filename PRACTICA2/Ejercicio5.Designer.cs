namespace PRACTICA2
{
    partial class Ejercicio5
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
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion1.Location = new System.Drawing.Point(307, 149);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(87, 22);
            this.rbOpcion1.TabIndex = 0;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "Opción A";
            this.rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion2.Location = new System.Drawing.Point(421, 149);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(88, 22);
            this.rbOpcion2.TabIndex = 1;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "Opción B";
            this.rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion3.Location = new System.Drawing.Point(534, 149);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(89, 22);
            this.rbOpcion3.TabIndex = 2;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "Opción C";
            this.rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAceptar.Location = new System.Drawing.Point(307, 210);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 39);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(436, 219);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(108, 18);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "                    ";
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Name = "Ejercicio5";
            this.Text = "Ejercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblResultado;
    }
}