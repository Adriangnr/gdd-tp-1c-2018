namespace FrbaHotel.AbmEmpleados
{
    partial class Empleados
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
            this.btnEmpleadosCancelar = new System.Windows.Forms.Button();
            this.btnEmpleadosCargarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleadosCancelar
            // 
            this.btnEmpleadosCancelar.Location = new System.Drawing.Point(409, 392);
            this.btnEmpleadosCancelar.Name = "btnEmpleadosCancelar";
            this.btnEmpleadosCancelar.Size = new System.Drawing.Size(119, 46);
            this.btnEmpleadosCancelar.TabIndex = 0;
            this.btnEmpleadosCancelar.Text = "Cancelar";
            this.btnEmpleadosCancelar.UseVisualStyleBackColor = true;
            this.btnEmpleadosCancelar.Click += new System.EventHandler(this.btnEmpleadosCancelar_Click);
            // 
            // btnEmpleadosCargarEmpleado
            // 
            this.btnEmpleadosCargarEmpleado.Location = new System.Drawing.Point(13, 392);
            this.btnEmpleadosCargarEmpleado.Name = "btnEmpleadosCargarEmpleado";
            this.btnEmpleadosCargarEmpleado.Size = new System.Drawing.Size(156, 46);
            this.btnEmpleadosCargarEmpleado.TabIndex = 1;
            this.btnEmpleadosCargarEmpleado.Text = "Cargar Empleado";
            this.btnEmpleadosCargarEmpleado.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btnEmpleadosCargarEmpleado);
            this.Controls.Add(this.btnEmpleadosCancelar);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleadosCancelar;
        private System.Windows.Forms.Button btnEmpleadosCargarEmpleado;
    }
}