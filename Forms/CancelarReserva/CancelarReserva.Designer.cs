namespace FrbaHotel.CancelarReserva
{
    partial class CancelarReserva
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
            this.btnCancelarReservaCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelarReservaCancelar
            // 
            this.btnCancelarReservaCancelar.Location = new System.Drawing.Point(247, 254);
            this.btnCancelarReservaCancelar.Name = "btnCancelarReservaCancelar";
            this.btnCancelarReservaCancelar.Size = new System.Drawing.Size(131, 45);
            this.btnCancelarReservaCancelar.TabIndex = 0;
            this.btnCancelarReservaCancelar.Text = "Cancelar";
            this.btnCancelarReservaCancelar.UseVisualStyleBackColor = true;
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 311);
            this.Controls.Add(this.btnCancelarReservaCancelar);
            this.Name = "CancelarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Reserva";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarReservaCancelar;
    }
}