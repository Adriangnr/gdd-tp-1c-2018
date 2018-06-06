namespace FrbaHotel.AbmRegimenes
{
    partial class Regimenes
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
            this.btnRegimenesCargar = new System.Windows.Forms.Button();
            this.btnRegimenesCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegimenesBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegimenesCargar
            // 
            this.btnRegimenesCargar.Location = new System.Drawing.Point(13, 392);
            this.btnRegimenesCargar.Name = "btnRegimenesCargar";
            this.btnRegimenesCargar.Size = new System.Drawing.Size(147, 46);
            this.btnRegimenesCargar.TabIndex = 0;
            this.btnRegimenesCargar.Text = "Cargar Régimen";
            this.btnRegimenesCargar.UseVisualStyleBackColor = true;
            this.btnRegimenesCargar.Click += new System.EventHandler(this.btnRegimenesCargar_Click);
            // 
            // btnRegimenesCancelar
            // 
            this.btnRegimenesCancelar.Location = new System.Drawing.Point(393, 392);
            this.btnRegimenesCancelar.Name = "btnRegimenesCancelar";
            this.btnRegimenesCancelar.Size = new System.Drawing.Size(147, 46);
            this.btnRegimenesCancelar.TabIndex = 1;
            this.btnRegimenesCancelar.Text = "Cancelar";
            this.btnRegimenesCancelar.UseVisualStyleBackColor = true;
            this.btnRegimenesCancelar.Click += new System.EventHandler(this.btnRegimenesCancelar_Click);
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
            this.label2.Location = new System.Drawing.Point(450, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Régimenes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código de Régimen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 5;
            // 
            // btnRegimenesBuscar
            // 
            this.btnRegimenesBuscar.Location = new System.Drawing.Point(415, 67);
            this.btnRegimenesBuscar.Name = "btnRegimenesBuscar";
            this.btnRegimenesBuscar.Size = new System.Drawing.Size(125, 33);
            this.btnRegimenesBuscar.TabIndex = 6;
            this.btnRegimenesBuscar.Text = "Buscar";
            this.btnRegimenesBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Listado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(527, 216);
            this.dataGridView1.TabIndex = 8;
            // 
            // Regimenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegimenesBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegimenesCancelar);
            this.Controls.Add(this.btnRegimenesCargar);
            this.Name = "Regimenes";
            this.Text = "Regimenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegimenesCargar;
        private System.Windows.Forms.Button btnRegimenesCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegimenesBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}