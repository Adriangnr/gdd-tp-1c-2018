namespace FrbaHotel.AbmCliente
{
    partial class Clientes
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
            this.btnClientesCancelar = new System.Windows.Forms.Button();
            this.btnClientesCargar = new System.Windows.Forms.Button();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.labelClientesListado = new System.Windows.Forms.Label();
            this.btnClientesLimpiar = new System.Windows.Forms.Button();
            this.btnClientesBuscar = new System.Windows.Forms.Button();
            this.labelFrbaHotelClientes = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelClientesNombre = new System.Windows.Forms.Label();
            this.labelClientesApellido = new System.Windows.Forms.Label();
            this.txtClientesNombre = new System.Windows.Forms.TextBox();
            this.txtClientesApellido = new System.Windows.Forms.TextBox();
            this.labelClientesTipoId = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelClienteNId = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelClientesEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientesCancelar
            // 
            this.btnClientesCancelar.Location = new System.Drawing.Point(659, 499);
            this.btnClientesCancelar.Name = "btnClientesCancelar";
            this.btnClientesCancelar.Size = new System.Drawing.Size(129, 45);
            this.btnClientesCancelar.TabIndex = 0;
            this.btnClientesCancelar.Text = "Cancelar";
            this.btnClientesCancelar.UseVisualStyleBackColor = true;
            this.btnClientesCancelar.Click += new System.EventHandler(this.btnClientesSalir_Click);
            // 
            // btnClientesCargar
            // 
            this.btnClientesCargar.Location = new System.Drawing.Point(13, 499);
            this.btnClientesCargar.Name = "btnClientesCargar";
            this.btnClientesCargar.Size = new System.Drawing.Size(152, 45);
            this.btnClientesCargar.TabIndex = 1;
            this.btnClientesCargar.Text = "Cargar Cliente";
            this.btnClientesCargar.UseVisualStyleBackColor = true;
            this.btnClientesCargar.Click += new System.EventHandler(this.btnClientesCargar_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(12, 246);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowTemplate.Height = 28;
            this.dataGridClientes.Size = new System.Drawing.Size(776, 247);
            this.dataGridClientes.TabIndex = 2;
            // 
            // labelClientesListado
            // 
            this.labelClientesListado.AutoSize = true;
            this.labelClientesListado.Location = new System.Drawing.Point(13, 220);
            this.labelClientesListado.Name = "labelClientesListado";
            this.labelClientesListado.Size = new System.Drawing.Size(61, 20);
            this.labelClientesListado.TabIndex = 3;
            this.labelClientesListado.Text = "Listado";
            // 
            // btnClientesLimpiar
            // 
            this.btnClientesLimpiar.Location = new System.Drawing.Point(12, 164);
            this.btnClientesLimpiar.Name = "btnClientesLimpiar";
            this.btnClientesLimpiar.Size = new System.Drawing.Size(148, 42);
            this.btnClientesLimpiar.TabIndex = 4;
            this.btnClientesLimpiar.Text = "Limpiar";
            this.btnClientesLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnClientesBuscar
            // 
            this.btnClientesBuscar.Location = new System.Drawing.Point(660, 164);
            this.btnClientesBuscar.Name = "btnClientesBuscar";
            this.btnClientesBuscar.Size = new System.Drawing.Size(128, 42);
            this.btnClientesBuscar.TabIndex = 5;
            this.btnClientesBuscar.Text = "Buscar";
            this.btnClientesBuscar.UseVisualStyleBackColor = true;
            // 
            // labelFrbaHotelClientes
            // 
            this.labelFrbaHotelClientes.AutoSize = true;
            this.labelFrbaHotelClientes.Location = new System.Drawing.Point(13, 13);
            this.labelFrbaHotelClientes.Name = "labelFrbaHotelClientes";
            this.labelFrbaHotelClientes.Size = new System.Drawing.Size(80, 20);
            this.labelFrbaHotelClientes.TabIndex = 6;
            this.labelFrbaHotelClientes.Text = "FrbaHotel";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Location = new System.Drawing.Point(722, 9);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(66, 20);
            this.labelClientes.TabIndex = 7;
            this.labelClientes.Text = "Clientes";
            // 
            // labelClientesNombre
            // 
            this.labelClientesNombre.AutoSize = true;
            this.labelClientesNombre.Location = new System.Drawing.Point(13, 53);
            this.labelClientesNombre.Name = "labelClientesNombre";
            this.labelClientesNombre.Size = new System.Drawing.Size(65, 20);
            this.labelClientesNombre.TabIndex = 8;
            this.labelClientesNombre.Text = "Nombre";
            // 
            // labelClientesApellido
            // 
            this.labelClientesApellido.AutoSize = true;
            this.labelClientesApellido.Location = new System.Drawing.Point(13, 99);
            this.labelClientesApellido.Name = "labelClientesApellido";
            this.labelClientesApellido.Size = new System.Drawing.Size(65, 20);
            this.labelClientesApellido.TabIndex = 9;
            this.labelClientesApellido.Text = "Apellido";
            // 
            // txtClientesNombre
            // 
            this.txtClientesNombre.Location = new System.Drawing.Point(85, 47);
            this.txtClientesNombre.Name = "txtClientesNombre";
            this.txtClientesNombre.Size = new System.Drawing.Size(169, 26);
            this.txtClientesNombre.TabIndex = 10;
            // 
            // txtClientesApellido
            // 
            this.txtClientesApellido.Location = new System.Drawing.Point(85, 93);
            this.txtClientesApellido.Name = "txtClientesApellido";
            this.txtClientesApellido.Size = new System.Drawing.Size(169, 26);
            this.txtClientesApellido.TabIndex = 11;
            // 
            // labelClientesTipoId
            // 
            this.labelClientesTipoId.AutoSize = true;
            this.labelClientesTipoId.Location = new System.Drawing.Point(283, 53);
            this.labelClientesTipoId.Name = "labelClientesTipoId";
            this.labelClientesTipoId.Size = new System.Drawing.Size(159, 20);
            this.labelClientesTipoId.TabIndex = 12;
            this.labelClientesTipoId.Text = "Tipo de Identificacion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(449, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // LabelClienteNId
            // 
            this.LabelClienteNId.AutoSize = true;
            this.LabelClienteNId.Location = new System.Drawing.Point(559, 54);
            this.LabelClienteNId.Name = "LabelClienteNId";
            this.LabelClienteNId.Size = new System.Drawing.Size(65, 20);
            this.LabelClienteNId.TabIndex = 14;
            this.LabelClienteNId.Text = "Numero";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 26);
            this.textBox1.TabIndex = 15;
            // 
            // labelClientesEmail
            // 
            this.labelClientesEmail.AutoSize = true;
            this.labelClientesEmail.Location = new System.Drawing.Point(287, 93);
            this.labelClientesEmail.Name = "labelClientesEmail";
            this.labelClientesEmail.Size = new System.Drawing.Size(48, 20);
            this.labelClientesEmail.TabIndex = 16;
            this.labelClientesEmail.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 26);
            this.textBox2.TabIndex = 17;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelClientesEmail);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelClienteNId);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelClientesTipoId);
            this.Controls.Add(this.txtClientesApellido);
            this.Controls.Add(this.txtClientesNombre);
            this.Controls.Add(this.labelClientesApellido);
            this.Controls.Add(this.labelClientesNombre);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.labelFrbaHotelClientes);
            this.Controls.Add(this.btnClientesBuscar);
            this.Controls.Add(this.btnClientesLimpiar);
            this.Controls.Add(this.labelClientesListado);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.btnClientesCargar);
            this.Controls.Add(this.btnClientesCancelar);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientesCancelar;
        private System.Windows.Forms.Button btnClientesCargar;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.Label labelClientesListado;
        private System.Windows.Forms.Button btnClientesLimpiar;
        private System.Windows.Forms.Button btnClientesBuscar;
        private System.Windows.Forms.Label labelFrbaHotelClientes;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelClientesNombre;
        private System.Windows.Forms.Label labelClientesApellido;
        private System.Windows.Forms.TextBox txtClientesNombre;
        private System.Windows.Forms.TextBox txtClientesApellido;
        private System.Windows.Forms.Label labelClientesTipoId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelClienteNId;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelClientesEmail;
        private System.Windows.Forms.TextBox textBox2;
    }
}