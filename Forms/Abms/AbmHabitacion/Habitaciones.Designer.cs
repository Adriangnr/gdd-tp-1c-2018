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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHabitHotel = new System.Windows.Forms.TextBox();
            this.txtHabitNum = new System.Windows.Forms.TextBox();
            this.comboHabitUbic = new System.Windows.Forms.ComboBox();
            this.comboHabitTipo = new System.Windows.Forms.ComboBox();
            this.txtHabitComodidades = new System.Windows.Forms.TextBox();
            this.btnHabitacionLimpiar = new System.Windows.Forms.Button();
            this.btnHabitacionBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHabitacionesCancelar
            // 
            this.btnHabitacionesCancelar.Location = new System.Drawing.Point(541, 494);
            this.btnHabitacionesCancelar.Name = "btnHabitacionesCancelar";
            this.btnHabitacionesCancelar.Size = new System.Drawing.Size(129, 44);
            this.btnHabitacionesCancelar.TabIndex = 0;
            this.btnHabitacionesCancelar.Text = "Cancelar";
            this.btnHabitacionesCancelar.UseVisualStyleBackColor = true;
            this.btnHabitacionesCancelar.Click += new System.EventHandler(this.btnHabitacionesSalir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar Habitación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FrbaHotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Habitaciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(658, 211);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Listado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero de Habitación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hotel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ubicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Habitación";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Comodidades";
            // 
            // txtHabitHotel
            // 
            this.txtHabitHotel.Location = new System.Drawing.Point(182, 59);
            this.txtHabitHotel.Name = "txtHabitHotel";
            this.txtHabitHotel.Size = new System.Drawing.Size(166, 26);
            this.txtHabitHotel.TabIndex = 13;
            // 
            // txtHabitNum
            // 
            this.txtHabitNum.Location = new System.Drawing.Point(182, 100);
            this.txtHabitNum.Name = "txtHabitNum";
            this.txtHabitNum.Size = new System.Drawing.Size(81, 26);
            this.txtHabitNum.TabIndex = 14;
            // 
            // comboHabitUbic
            // 
            this.comboHabitUbic.FormattingEnabled = true;
            this.comboHabitUbic.Location = new System.Drawing.Point(182, 137);
            this.comboHabitUbic.Name = "comboHabitUbic";
            this.comboHabitUbic.Size = new System.Drawing.Size(166, 28);
            this.comboHabitUbic.TabIndex = 15;
            // 
            // comboHabitTipo
            // 
            this.comboHabitTipo.FormattingEnabled = true;
            this.comboHabitTipo.Location = new System.Drawing.Point(504, 57);
            this.comboHabitTipo.Name = "comboHabitTipo";
            this.comboHabitTipo.Size = new System.Drawing.Size(166, 28);
            this.comboHabitTipo.TabIndex = 16;
            // 
            // txtHabitComodidades
            // 
            this.txtHabitComodidades.Location = new System.Drawing.Point(361, 138);
            this.txtHabitComodidades.Name = "txtHabitComodidades";
            this.txtHabitComodidades.Size = new System.Drawing.Size(309, 26);
            this.txtHabitComodidades.TabIndex = 17;
            // 
            // btnHabitacionLimpiar
            // 
            this.btnHabitacionLimpiar.Location = new System.Drawing.Point(12, 198);
            this.btnHabitacionLimpiar.Name = "btnHabitacionLimpiar";
            this.btnHabitacionLimpiar.Size = new System.Drawing.Size(136, 35);
            this.btnHabitacionLimpiar.TabIndex = 18;
            this.btnHabitacionLimpiar.Text = "Limpiar";
            this.btnHabitacionLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnHabitacionBuscar
            // 
            this.btnHabitacionBuscar.Location = new System.Drawing.Point(534, 198);
            this.btnHabitacionBuscar.Name = "btnHabitacionBuscar";
            this.btnHabitacionBuscar.Size = new System.Drawing.Size(136, 35);
            this.btnHabitacionBuscar.TabIndex = 19;
            this.btnHabitacionBuscar.Text = "Buscar";
            this.btnHabitacionBuscar.UseVisualStyleBackColor = true;
            // 
            // Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 546);
            this.Controls.Add(this.btnHabitacionBuscar);
            this.Controls.Add(this.btnHabitacionLimpiar);
            this.Controls.Add(this.txtHabitComodidades);
            this.Controls.Add(this.comboHabitTipo);
            this.Controls.Add(this.comboHabitUbic);
            this.Controls.Add(this.txtHabitNum);
            this.Controls.Add(this.txtHabitHotel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHabitacionesCancelar);
            this.Name = "Habitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHabitacionesCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHabitHotel;
        private System.Windows.Forms.TextBox txtHabitNum;
        private System.Windows.Forms.ComboBox comboHabitUbic;
        private System.Windows.Forms.ComboBox comboHabitTipo;
        private System.Windows.Forms.TextBox txtHabitComodidades;
        private System.Windows.Forms.Button btnHabitacionLimpiar;
        private System.Windows.Forms.Button btnHabitacionBuscar;
    }
}