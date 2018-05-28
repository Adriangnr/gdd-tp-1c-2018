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
            this.btnHotelesCargar = new System.Windows.Forms.Button();
            this.dataHotelesListado = new System.Windows.Forms.DataGridView();
            this.labelHotelesListado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHoteles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHotelesNombre = new System.Windows.Forms.TextBox();
            this.txtHotelesEstrellas = new System.Windows.Forms.TextBox();
            this.txtHotelesPais = new System.Windows.Forms.TextBox();
            this.txtHotelesCiudad = new System.Windows.Forms.TextBox();
            this.btnHotelesLimpiar = new System.Windows.Forms.Button();
            this.btnHotelesBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelesListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHotelesCancelar
            // 
            this.btnHotelesCancelar.Location = new System.Drawing.Point(635, 467);
            this.btnHotelesCancelar.Name = "btnHotelesCancelar";
            this.btnHotelesCancelar.Size = new System.Drawing.Size(153, 46);
            this.btnHotelesCancelar.TabIndex = 0;
            this.btnHotelesCancelar.Text = "Cancelar";
            this.btnHotelesCancelar.UseVisualStyleBackColor = true;
            this.btnHotelesCancelar.Click += new System.EventHandler(this.btnHotelesSalir_Click);
            // 
            // btnHotelesCargar
            // 
            this.btnHotelesCargar.Location = new System.Drawing.Point(13, 467);
            this.btnHotelesCargar.Name = "btnHotelesCargar";
            this.btnHotelesCargar.Size = new System.Drawing.Size(148, 45);
            this.btnHotelesCargar.TabIndex = 1;
            this.btnHotelesCargar.Text = "Cargar Hotel";
            this.btnHotelesCargar.UseVisualStyleBackColor = true;
            this.btnHotelesCargar.Click += new System.EventHandler(this.btnHotelesCargar_Click);
            // 
            // dataHotelesListado
            // 
            this.dataHotelesListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHotelesListado.Location = new System.Drawing.Point(12, 251);
            this.dataHotelesListado.Name = "dataHotelesListado";
            this.dataHotelesListado.RowTemplate.Height = 28;
            this.dataHotelesListado.Size = new System.Drawing.Size(776, 210);
            this.dataHotelesListado.TabIndex = 2;
            // 
            // labelHotelesListado
            // 
            this.labelHotelesListado.AutoSize = true;
            this.labelHotelesListado.Location = new System.Drawing.Point(12, 225);
            this.labelHotelesListado.Name = "labelHotelesListado";
            this.labelHotelesListado.Size = new System.Drawing.Size(61, 20);
            this.labelHotelesListado.TabIndex = 3;
            this.labelHotelesListado.Text = "Listado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "FrbaHotel";
            // 
            // labelHoteles
            // 
            this.labelHoteles.AutoSize = true;
            this.labelHoteles.Location = new System.Drawing.Point(724, 9);
            this.labelHoteles.Name = "labelHoteles";
            this.labelHoteles.Size = new System.Drawing.Size(64, 20);
            this.labelHoteles.TabIndex = 5;
            this.labelHoteles.Text = "Hoteles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estrellas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pais";
            // 
            // txtHotelesNombre
            // 
            this.txtHotelesNombre.Location = new System.Drawing.Point(103, 63);
            this.txtHotelesNombre.Name = "txtHotelesNombre";
            this.txtHotelesNombre.Size = new System.Drawing.Size(217, 26);
            this.txtHotelesNombre.TabIndex = 10;
            // 
            // txtHotelesEstrellas
            // 
            this.txtHotelesEstrellas.Location = new System.Drawing.Point(103, 104);
            this.txtHotelesEstrellas.Name = "txtHotelesEstrellas";
            this.txtHotelesEstrellas.Size = new System.Drawing.Size(217, 26);
            this.txtHotelesEstrellas.TabIndex = 11;
            // 
            // txtHotelesPais
            // 
            this.txtHotelesPais.Location = new System.Drawing.Point(560, 104);
            this.txtHotelesPais.Name = "txtHotelesPais";
            this.txtHotelesPais.Size = new System.Drawing.Size(228, 26);
            this.txtHotelesPais.TabIndex = 12;
            // 
            // txtHotelesCiudad
            // 
            this.txtHotelesCiudad.Location = new System.Drawing.Point(560, 63);
            this.txtHotelesCiudad.Name = "txtHotelesCiudad";
            this.txtHotelesCiudad.Size = new System.Drawing.Size(228, 26);
            this.txtHotelesCiudad.TabIndex = 13;
            // 
            // btnHotelesLimpiar
            // 
            this.btnHotelesLimpiar.Location = new System.Drawing.Point(12, 158);
            this.btnHotelesLimpiar.Name = "btnHotelesLimpiar";
            this.btnHotelesLimpiar.Size = new System.Drawing.Size(128, 38);
            this.btnHotelesLimpiar.TabIndex = 14;
            this.btnHotelesLimpiar.Text = "Limpiar";
            this.btnHotelesLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnHotelesBuscar
            // 
            this.btnHotelesBuscar.Location = new System.Drawing.Point(660, 158);
            this.btnHotelesBuscar.Name = "btnHotelesBuscar";
            this.btnHotelesBuscar.Size = new System.Drawing.Size(128, 38);
            this.btnHotelesBuscar.TabIndex = 15;
            this.btnHotelesBuscar.Text = "Buscar";
            this.btnHotelesBuscar.UseVisualStyleBackColor = true;
            // 
            // Hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnHotelesBuscar);
            this.Controls.Add(this.btnHotelesLimpiar);
            this.Controls.Add(this.txtHotelesCiudad);
            this.Controls.Add(this.txtHotelesPais);
            this.Controls.Add(this.txtHotelesEstrellas);
            this.Controls.Add(this.txtHotelesNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHoteles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHotelesListado);
            this.Controls.Add(this.dataHotelesListado);
            this.Controls.Add(this.btnHotelesCargar);
            this.Controls.Add(this.btnHotelesCancelar);
            this.Name = "Hoteles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoteles";
            ((System.ComponentModel.ISupportInitialize)(this.dataHotelesListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHotelesCancelar;
        private System.Windows.Forms.Button btnHotelesCargar;
        private System.Windows.Forms.DataGridView dataHotelesListado;
        private System.Windows.Forms.Label labelHotelesListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHoteles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHotelesNombre;
        private System.Windows.Forms.TextBox txtHotelesEstrellas;
        private System.Windows.Forms.TextBox txtHotelesPais;
        private System.Windows.Forms.TextBox txtHotelesCiudad;
        private System.Windows.Forms.Button btnHotelesLimpiar;
        private System.Windows.Forms.Button btnHotelesBuscar;
    }
}