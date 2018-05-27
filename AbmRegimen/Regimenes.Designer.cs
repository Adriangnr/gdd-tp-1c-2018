namespace FrbaHotel.AbmRegimen
{
    partial class Regimenes
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
            this.btnRegimenesCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegimenesCancelar
            // 
            this.btnRegimenesCancelar.Location = new System.Drawing.Point(238, 250);
            this.btnRegimenesCancelar.Name = "btnRegimenesCancelar";
            this.btnRegimenesCancelar.Size = new System.Drawing.Size(123, 47);
            this.btnRegimenesCancelar.TabIndex = 0;
            this.btnRegimenesCancelar.Text = "Cancelar";
            this.btnRegimenesCancelar.UseVisualStyleBackColor = true;
            this.btnRegimenesCancelar.Click += new System.EventHandler(this.btnRegimenesSalir_Click);
            // 
            // Regimenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 309);
            this.Controls.Add(this.btnRegimenesCancelar);
            this.Name = "Regimenes";
            this.Text = "Regimenes";
            this.Load += new System.EventHandler(this.Regimenes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegimenesCancelar;
    }
}