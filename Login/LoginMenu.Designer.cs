namespace FrbaHotel.Login
{
    partial class LoginMenu
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
            this.btnLoginMenuSalir = new System.Windows.Forms.Button();
            this.btnLoginMenuClientes = new System.Windows.Forms.Button();
            this.btnLoginMenuHabitaciones = new System.Windows.Forms.Button();
            this.btnLoginMenuRegimenes = new System.Windows.Forms.Button();
            this.btnLoginMenuUsuarios = new System.Windows.Forms.Button();
            this.btnLoginMenuReservas = new System.Windows.Forms.Button();
            this.btnLoginMenuEstadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginMenuSalir
            // 
            this.btnLoginMenuSalir.Location = new System.Drawing.Point(76, 411);
            this.btnLoginMenuSalir.Name = "btnLoginMenuSalir";
            this.btnLoginMenuSalir.Size = new System.Drawing.Size(133, 49);
            this.btnLoginMenuSalir.TabIndex = 0;
            this.btnLoginMenuSalir.Text = "Salir";
            this.btnLoginMenuSalir.UseVisualStyleBackColor = true;
            this.btnLoginMenuSalir.Click += new System.EventHandler(this.btnLoginMenuSalir_Click);
            // 
            // btnLoginMenuClientes
            // 
            this.btnLoginMenuClientes.Location = new System.Drawing.Point(27, 16);
            this.btnLoginMenuClientes.Name = "btnLoginMenuClientes";
            this.btnLoginMenuClientes.Size = new System.Drawing.Size(247, 54);
            this.btnLoginMenuClientes.TabIndex = 1;
            this.btnLoginMenuClientes.Text = "Clientes";
            this.btnLoginMenuClientes.UseVisualStyleBackColor = true;
            this.btnLoginMenuClientes.Click += new System.EventHandler(this.btnLoginMenuClientes_Click);
            // 
            // btnLoginMenuHabitaciones
            // 
            this.btnLoginMenuHabitaciones.Location = new System.Drawing.Point(27, 76);
            this.btnLoginMenuHabitaciones.Name = "btnLoginMenuHabitaciones";
            this.btnLoginMenuHabitaciones.Size = new System.Drawing.Size(247, 54);
            this.btnLoginMenuHabitaciones.TabIndex = 2;
            this.btnLoginMenuHabitaciones.Text = "Habitaciones";
            this.btnLoginMenuHabitaciones.UseVisualStyleBackColor = true;
            // 
            // btnLoginMenuRegimenes
            // 
            this.btnLoginMenuRegimenes.Location = new System.Drawing.Point(27, 255);
            this.btnLoginMenuRegimenes.Name = "btnLoginMenuRegimenes";
            this.btnLoginMenuRegimenes.Size = new System.Drawing.Size(247, 54);
            this.btnLoginMenuRegimenes.TabIndex = 3;
            this.btnLoginMenuRegimenes.Text = "Regimenes";
            this.btnLoginMenuRegimenes.UseVisualStyleBackColor = true;
            // 
            // btnLoginMenuUsuarios
            // 
            this.btnLoginMenuUsuarios.Location = new System.Drawing.Point(27, 136);
            this.btnLoginMenuUsuarios.Name = "btnLoginMenuUsuarios";
            this.btnLoginMenuUsuarios.Size = new System.Drawing.Size(247, 54);
            this.btnLoginMenuUsuarios.TabIndex = 4;
            this.btnLoginMenuUsuarios.Text = "Usuarios";
            this.btnLoginMenuUsuarios.UseVisualStyleBackColor = true;
            this.btnLoginMenuUsuarios.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLoginMenuReservas
            // 
            this.btnLoginMenuReservas.Location = new System.Drawing.Point(27, 195);
            this.btnLoginMenuReservas.Name = "btnLoginMenuReservas";
            this.btnLoginMenuReservas.Size = new System.Drawing.Size(247, 54);
            this.btnLoginMenuReservas.TabIndex = 5;
            this.btnLoginMenuReservas.Text = "Reservas";
            this.btnLoginMenuReservas.UseVisualStyleBackColor = true;
            // 
            // btnLoginMenuEstadisticas
            // 
            this.btnLoginMenuEstadisticas.Location = new System.Drawing.Point(27, 315);
            this.btnLoginMenuEstadisticas.Name = "btnLoginMenuEstadisticas";
            this.btnLoginMenuEstadisticas.Size = new System.Drawing.Size(247, 54);
            this.btnLoginMenuEstadisticas.TabIndex = 6;
            this.btnLoginMenuEstadisticas.Text = "Estadisticas";
            this.btnLoginMenuEstadisticas.UseVisualStyleBackColor = true;
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 472);
            this.Controls.Add(this.btnLoginMenuEstadisticas);
            this.Controls.Add(this.btnLoginMenuReservas);
            this.Controls.Add(this.btnLoginMenuUsuarios);
            this.Controls.Add(this.btnLoginMenuRegimenes);
            this.Controls.Add(this.btnLoginMenuHabitaciones);
            this.Controls.Add(this.btnLoginMenuClientes);
            this.Controls.Add(this.btnLoginMenuSalir);
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginMenuSalir;
        private System.Windows.Forms.Button btnLoginMenuClientes;
        private System.Windows.Forms.Button btnLoginMenuHabitaciones;
        private System.Windows.Forms.Button btnLoginMenuRegimenes;
        private System.Windows.Forms.Button btnLoginMenuUsuarios;
        private System.Windows.Forms.Button btnLoginMenuReservas;
        private System.Windows.Forms.Button btnLoginMenuEstadisticas;
    }
}