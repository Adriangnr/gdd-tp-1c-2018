namespace FrbaHotel.AbmEmpleados
{
    partial class AltaEmpleado
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
            this.btnAltaEmpleadosGuardar = new System.Windows.Forms.Button();
            this.btnAltaEmpleadoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaEmpleadosGuardar
            // 
            this.btnAltaEmpleadosGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAltaEmpleadosGuardar.Location = new System.Drawing.Point(13, 393);
            this.btnAltaEmpleadosGuardar.Name = "btnAltaEmpleadosGuardar";
            this.btnAltaEmpleadosGuardar.Size = new System.Drawing.Size(129, 45);
            this.btnAltaEmpleadosGuardar.TabIndex = 0;
            this.btnAltaEmpleadosGuardar.Text = "Guardar";
            this.btnAltaEmpleadosGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAltaEmpleadoCancelar
            // 
            this.btnAltaEmpleadoCancelar.Location = new System.Drawing.Point(346, 393);
            this.btnAltaEmpleadoCancelar.Name = "btnAltaEmpleadoCancelar";
            this.btnAltaEmpleadoCancelar.Size = new System.Drawing.Size(126, 45);
            this.btnAltaEmpleadoCancelar.TabIndex = 1;
            this.btnAltaEmpleadoCancelar.Text = "Cancelar";
            this.btnAltaEmpleadoCancelar.UseVisualStyleBackColor = true;
            this.btnAltaEmpleadoCancelar.Click += new System.EventHandler(this.btnAltaEmpleadoCancelar_Click);
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btnAltaEmpleadoCancelar);
            this.Controls.Add(this.btnAltaEmpleadosGuardar);
            this.Name = "AltaEmpleado";
            this.Text = "AltaEmpleado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaEmpleadosGuardar;
        private System.Windows.Forms.Button btnAltaEmpleadoCancelar;
    }
}