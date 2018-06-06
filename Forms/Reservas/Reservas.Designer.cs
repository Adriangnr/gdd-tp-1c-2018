namespace FrbaHotel.Reservas
{
    partial class Reservas
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
            this.btnReservasCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReservasCancelar
            // 
            this.btnReservasCancelar.Location = new System.Drawing.Point(640, 394);
            this.btnReservasCancelar.Name = "btnReservasCancelar";
            this.btnReservasCancelar.Size = new System.Drawing.Size(148, 44);
            this.btnReservasCancelar.TabIndex = 0;
            this.btnReservasCancelar.Text = "Cancelar";
            this.btnReservasCancelar.UseVisualStyleBackColor = true;
            this.btnReservasCancelar.Click += new System.EventHandler(this.btnReservasCancelar_Click);
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservasCancelar);
            this.Name = "Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReservasCancelar;
    }
}