namespace FrbaHotel.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.btnListadoEstadisticoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListadoEstadisticoCancelar
            // 
            this.btnListadoEstadisticoCancelar.Location = new System.Drawing.Point(290, 254);
            this.btnListadoEstadisticoCancelar.Name = "btnListadoEstadisticoCancelar";
            this.btnListadoEstadisticoCancelar.Size = new System.Drawing.Size(141, 44);
            this.btnListadoEstadisticoCancelar.TabIndex = 0;
            this.btnListadoEstadisticoCancelar.Text = "Cancelar";
            this.btnListadoEstadisticoCancelar.UseVisualStyleBackColor = true;
            this.btnListadoEstadisticoCancelar.Click += new System.EventHandler(this.btnListadoEstadisticoCancelar_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 310);
            this.Controls.Add(this.btnListadoEstadisticoCancelar);
            this.Name = "ListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Estadistico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListadoEstadisticoCancelar;
    }
}