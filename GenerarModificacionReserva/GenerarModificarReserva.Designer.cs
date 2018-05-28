namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarModificarReserva
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
            System.Windows.Forms.DateTimePicker fechaHasta;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerarModificarReservaLimpiar = new System.Windows.Forms.Button();
            this.btnGenerarModificarReservaBuscar = new System.Windows.Forms.Button();
            this.labelHotel = new System.Windows.Forms.Label();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHuespedes = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.txtHuespedes = new System.Windows.Forms.TextBox();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.labelMasFiltros = new System.Windows.Forms.Label();
            this.btnGenerarModificarReservaMasFiltros = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtFiltros = new System.Windows.Forms.TextBox();
            this.comboRegimen = new System.Windows.Forms.ComboBox();
            this.btnGenerarModificarReservaReservar = new System.Windows.Forms.Button();
            this.btnGenerarModificarReservaSalir = new System.Windows.Forms.Button();
            this.btnGenerarModificarReservaModificar = new System.Windows.Forms.Button();
            fechaHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaHasta
            // 
            fechaHasta.Location = new System.Drawing.Point(610, 119);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.Size = new System.Drawing.Size(293, 26);
            fechaHasta.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(886, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGenerarModificarReservaLimpiar
            // 
            this.btnGenerarModificarReservaLimpiar.Location = new System.Drawing.Point(16, 235);
            this.btnGenerarModificarReservaLimpiar.Name = "btnGenerarModificarReservaLimpiar";
            this.btnGenerarModificarReservaLimpiar.Size = new System.Drawing.Size(142, 45);
            this.btnGenerarModificarReservaLimpiar.TabIndex = 1;
            this.btnGenerarModificarReservaLimpiar.Text = "Limpiar";
            this.btnGenerarModificarReservaLimpiar.UseVisualStyleBackColor = true;
            this.btnGenerarModificarReservaLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerarModificarReservaBuscar
            // 
            this.btnGenerarModificarReservaBuscar.Location = new System.Drawing.Point(774, 235);
            this.btnGenerarModificarReservaBuscar.Name = "btnGenerarModificarReservaBuscar";
            this.btnGenerarModificarReservaBuscar.Size = new System.Drawing.Size(128, 45);
            this.btnGenerarModificarReservaBuscar.TabIndex = 2;
            this.btnGenerarModificarReservaBuscar.Text = "Buscar";
            this.btnGenerarModificarReservaBuscar.UseVisualStyleBackColor = true;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(12, 75);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(47, 20);
            this.labelHotel.TabIndex = 3;
            this.labelHotel.Text = "Hotel";
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(12, 125);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(56, 20);
            this.labelDesde.TabIndex = 4;
            this.labelDesde.Text = "Desde";
            // 
            // labelHuespedes
            // 
            this.labelHuespedes.AutoSize = true;
            this.labelHuespedes.Location = new System.Drawing.Point(12, 176);
            this.labelHuespedes.Name = "labelHuespedes";
            this.labelHuespedes.Size = new System.Drawing.Size(91, 20);
            this.labelHuespedes.TabIndex = 5;
            this.labelHuespedes.Text = "Huespedes";
            // 
            // txtHotel
            // 
            this.txtHotel.Location = new System.Drawing.Point(124, 69);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(292, 26);
            this.txtHotel.TabIndex = 6;
            // 
            // txtHuespedes
            // 
            this.txtHuespedes.Location = new System.Drawing.Point(125, 170);
            this.txtHuespedes.Name = "txtHuespedes";
            this.txtHuespedes.Size = new System.Drawing.Size(45, 26);
            this.txtHuespedes.TabIndex = 8;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(124, 119);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(293, 26);
            this.fechaDesde.TabIndex = 9;
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Location = new System.Drawing.Point(518, 72);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(73, 20);
            this.labelRegimen.TabIndex = 12;
            this.labelRegimen.Text = "Régimen";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(518, 124);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(52, 20);
            this.labelHasta.TabIndex = 13;
            this.labelHasta.Text = "Hasta";
            // 
            // labelMasFiltros
            // 
            this.labelMasFiltros.AutoSize = true;
            this.labelMasFiltros.Location = new System.Drawing.Point(518, 173);
            this.labelMasFiltros.Name = "labelMasFiltros";
            this.labelMasFiltros.Size = new System.Drawing.Size(86, 20);
            this.labelMasFiltros.TabIndex = 14;
            this.labelMasFiltros.Text = "Mas Filtros";
            // 
            // btnGenerarModificarReservaMasFiltros
            // 
            this.btnGenerarModificarReservaMasFiltros.Location = new System.Drawing.Point(767, 165);
            this.btnGenerarModificarReservaMasFiltros.Name = "btnGenerarModificarReservaMasFiltros";
            this.btnGenerarModificarReservaMasFiltros.Size = new System.Drawing.Size(135, 31);
            this.btnGenerarModificarReservaMasFiltros.TabIndex = 15;
            this.btnGenerarModificarReservaMasFiltros.Text = "Seleccionar";
            this.btnGenerarModificarReservaMasFiltros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerarModificarReservaMasFiltros.UseVisualStyleBackColor = true;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(725, 12);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(177, 35);
            this.btnIniciarSesion.TabIndex = 16;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(80, 20);
            this.labelTitulo.TabIndex = 17;
            this.labelTitulo.Text = "FrbaHotel";
            // 
            // txtFiltros
            // 
            this.txtFiltros.Location = new System.Drawing.Point(610, 167);
            this.txtFiltros.Name = "txtFiltros";
            this.txtFiltros.Size = new System.Drawing.Size(135, 26);
            this.txtFiltros.TabIndex = 18;
            this.txtFiltros.TextChanged += new System.EventHandler(this.txtFiltros_TextChanged);
            // 
            // comboRegimen
            // 
            this.comboRegimen.FormattingEnabled = true;
            this.comboRegimen.Location = new System.Drawing.Point(610, 64);
            this.comboRegimen.Name = "comboRegimen";
            this.comboRegimen.Size = new System.Drawing.Size(290, 28);
            this.comboRegimen.TabIndex = 19;
            // 
            // btnGenerarModificarReservaReservar
            // 
            this.btnGenerarModificarReservaReservar.Location = new System.Drawing.Point(16, 625);
            this.btnGenerarModificarReservaReservar.Name = "btnGenerarModificarReservaReservar";
            this.btnGenerarModificarReservaReservar.Size = new System.Drawing.Size(163, 45);
            this.btnGenerarModificarReservaReservar.TabIndex = 20;
            this.btnGenerarModificarReservaReservar.Text = "Reservar";
            this.btnGenerarModificarReservaReservar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarModificarReservaSalir
            // 
            this.btnGenerarModificarReservaSalir.Location = new System.Drawing.Point(740, 625);
            this.btnGenerarModificarReservaSalir.Name = "btnGenerarModificarReservaSalir";
            this.btnGenerarModificarReservaSalir.Size = new System.Drawing.Size(163, 45);
            this.btnGenerarModificarReservaSalir.TabIndex = 21;
            this.btnGenerarModificarReservaSalir.Text = "Salir";
            this.btnGenerarModificarReservaSalir.UseVisualStyleBackColor = true;
            this.btnGenerarModificarReservaSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarModificarReservaModificar
            // 
            this.btnGenerarModificarReservaModificar.Location = new System.Drawing.Point(379, 626);
            this.btnGenerarModificarReservaModificar.Name = "btnGenerarModificarReservaModificar";
            this.btnGenerarModificarReservaModificar.Size = new System.Drawing.Size(168, 44);
            this.btnGenerarModificarReservaModificar.TabIndex = 22;
            this.btnGenerarModificarReservaModificar.Text = "Modificar Reserva";
            this.btnGenerarModificarReservaModificar.UseVisualStyleBackColor = true;
            this.btnGenerarModificarReservaModificar.Click += new System.EventHandler(this.btnGenerarModificarReservaModificar_Click);
            // 
            // GenerarModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 682);
            this.Controls.Add(this.btnGenerarModificarReservaModificar);
            this.Controls.Add(this.btnGenerarModificarReservaSalir);
            this.Controls.Add(this.btnGenerarModificarReservaReservar);
            this.Controls.Add(this.comboRegimen);
            this.Controls.Add(this.txtFiltros);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnGenerarModificarReservaMasFiltros);
            this.Controls.Add(this.labelMasFiltros);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.labelRegimen);
            this.Controls.Add(fechaHasta);
            this.Controls.Add(this.fechaDesde);
            this.Controls.Add(this.txtHuespedes);
            this.Controls.Add(this.txtHotel);
            this.Controls.Add(this.labelHuespedes);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.btnGenerarModificarReservaBuscar);
            this.Controls.Add(this.btnGenerarModificarReservaLimpiar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GenerarModificarReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarModificarReserva";
            this.Load += new System.EventHandler(this.GenerarModificarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerarModificarReservaLimpiar;
        private System.Windows.Forms.Button btnGenerarModificarReservaBuscar;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.Label labelHuespedes;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.TextBox txtHuespedes;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Label labelMasFiltros;
        private System.Windows.Forms.Button btnGenerarModificarReservaMasFiltros;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtFiltros;
        private System.Windows.Forms.ComboBox comboRegimen;
        private System.Windows.Forms.Button btnGenerarModificarReservaReservar;
        private System.Windows.Forms.Button btnGenerarModificarReservaSalir;
        private System.Windows.Forms.Button btnGenerarModificarReservaModificar;
    }
}