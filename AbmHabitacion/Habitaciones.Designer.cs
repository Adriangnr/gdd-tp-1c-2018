namespace FrbaHotel.AbmHabitacion
{
    partial class Habitaciones
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
            this.btnHabitacionesCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHabitacionesCancelar
            // 
            this.btnHabitacionesCancelar.Location = new System.Drawing.Point(241, 245);
            this.btnHabitacionesCancelar.Name = "btnHabitacionesCancelar";
            this.btnHabitacionesCancelar.Size = new System.Drawing.Size(129, 44);
            this.btnHabitacionesCancelar.TabIndex = 0;
            this.btnHabitacionesCancelar.Text = "Cancelar";
            this.btnHabitacionesCancelar.UseVisualStyleBackColor = true;
            this.btnHabitacionesCancelar.Click += new System.EventHandler(this.btnHabitacionesSalir_Click);
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 301);
            this.Controls.Add(this.btnHabitacionesCancelar);
            this.Name = "Habitaciones";
            this.Text = "Habitaciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHabitacionesCancelar;
    }
}