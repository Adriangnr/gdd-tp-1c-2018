namespace FrbaHotel.AbmUsuario
{
    partial class AltaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chckHabilitadoAltaUsuario = new System.Windows.Forms.CheckBox();
            this.txtAltaUsuarioUsername = new System.Windows.Forms.TextBox();
            this.txtAltaUsuarioContrasenia = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAltaUsuarioGuardar = new System.Windows.Forms.Button();
            this.btnAltaUsuarioCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar Contraseña";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chckHabilitadoAltaUsuario
            // 
            this.chckHabilitadoAltaUsuario.AutoSize = true;
            this.chckHabilitadoAltaUsuario.Location = new System.Drawing.Point(21, 244);
            this.chckHabilitadoAltaUsuario.Name = "chckHabilitadoAltaUsuario";
            this.chckHabilitadoAltaUsuario.Size = new System.Drawing.Size(106, 24);
            this.chckHabilitadoAltaUsuario.TabIndex = 5;
            this.chckHabilitadoAltaUsuario.Text = "Habilitado";
            this.chckHabilitadoAltaUsuario.UseVisualStyleBackColor = true;
            // 
            // txtAltaUsuarioUsername
            // 
            this.txtAltaUsuarioUsername.Location = new System.Drawing.Point(208, 66);
            this.txtAltaUsuarioUsername.Name = "txtAltaUsuarioUsername";
            this.txtAltaUsuarioUsername.Size = new System.Drawing.Size(158, 26);
            this.txtAltaUsuarioUsername.TabIndex = 6;
            // 
            // txtAltaUsuarioContrasenia
            // 
            this.txtAltaUsuarioContrasenia.Location = new System.Drawing.Point(208, 125);
            this.txtAltaUsuarioContrasenia.Name = "txtAltaUsuarioContrasenia";
            this.txtAltaUsuarioContrasenia.Size = new System.Drawing.Size(158, 26);
            this.txtAltaUsuarioContrasenia.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 26);
            this.textBox3.TabIndex = 8;
            // 
            // btnAltaUsuarioGuardar
            // 
            this.btnAltaUsuarioGuardar.Location = new System.Drawing.Point(17, 290);
            this.btnAltaUsuarioGuardar.Name = "btnAltaUsuarioGuardar";
            this.btnAltaUsuarioGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnAltaUsuarioGuardar.TabIndex = 9;
            this.btnAltaUsuarioGuardar.Text = "Guardar";
            this.btnAltaUsuarioGuardar.UseVisualStyleBackColor = true;
            this.btnAltaUsuarioGuardar.Click += new System.EventHandler(this.btnAltaUsuarioGuardar_Click);
            // 
            // btnAltaUsuarioCancelar
            // 
            this.btnAltaUsuarioCancelar.Location = new System.Drawing.Point(256, 290);
            this.btnAltaUsuarioCancelar.Name = "btnAltaUsuarioCancelar";
            this.btnAltaUsuarioCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnAltaUsuarioCancelar.TabIndex = 10;
            this.btnAltaUsuarioCancelar.Text = "Cancelar";
            this.btnAltaUsuarioCancelar.UseVisualStyleBackColor = true;
            this.btnAltaUsuarioCancelar.Click += new System.EventHandler(this.btnAltaUsuarioCancelar_Click);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 342);
            this.Controls.Add(this.btnAltaUsuarioCancelar);
            this.Controls.Add(this.btnAltaUsuarioGuardar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtAltaUsuarioContrasenia);
            this.Controls.Add(this.txtAltaUsuarioUsername);
            this.Controls.Add(this.chckHabilitadoAltaUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chckHabilitadoAltaUsuario;
        private System.Windows.Forms.TextBox txtAltaUsuarioUsername;
        private System.Windows.Forms.TextBox txtAltaUsuarioContrasenia;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAltaUsuarioGuardar;
        private System.Windows.Forms.Button btnAltaUsuarioCancelar;
    }
}