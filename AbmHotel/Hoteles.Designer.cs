namespace FrbaHotel.AbmHotel
{
    partial class Hoteles
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
            this.btnHotelesCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHotelesCancelar
            // 
            this.btnHotelesCancelar.Location = new System.Drawing.Point(635, 392);
            this.btnHotelesCancelar.Name = "btnHotelesCancelar";
            this.btnHotelesCancelar.Size = new System.Drawing.Size(153, 46);
            this.btnHotelesCancelar.TabIndex = 0;
            this.btnHotelesCancelar.Text = "Cancelar";
            this.btnHotelesCancelar.UseVisualStyleBackColor = true;
            this.btnHotelesCancelar.Click += new System.EventHandler(this.btnHotelesSalir_Click);
            // 
            // Hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHotelesCancelar);
            this.Name = "Hoteles";
            this.Text = "Hoteles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHotelesCancelar;
    }
}