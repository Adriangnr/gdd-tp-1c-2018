namespace FrbaHotel.Login
{
    partial class Login
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(55, 68);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 20);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Location = new System.Drawing.Point(55, 133);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(92, 20);
            this.labelContrasenia.TabIndex = 1;
            this.labelContrasenia.Text = "Contraseña";
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(178, 62);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(152, 26);
            this.txtLoginUsuario.TabIndex = 2;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(178, 127);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(152, 26);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(59, 235);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginCancelar
            // 
            this.btnLoginCancelar.Location = new System.Drawing.Point(211, 235);
            this.btnLoginCancelar.Name = "btnLoginCancelar";
            this.btnLoginCancelar.Size = new System.Drawing.Size(119, 34);
            this.btnLoginCancelar.TabIndex = 5;
            this.btnLoginCancelar.Text = "Cancelar";
            this.btnLoginCancelar.UseVisualStyleBackColor = true;
            this.btnLoginCancelar.Click += new System.EventHandler(this.btnLoginCancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 326);
            this.Controls.Add(this.btnLoginCancelar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.labelUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.Controls.SetChildIndex(this.labelUsuario, 0);
            this.Controls.SetChildIndex(this.labelContrasenia, 0);
            this.Controls.SetChildIndex(this.txtLoginUsuario, 0);
            this.Controls.SetChildIndex(this.txtLoginPassword, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.btnLoginCancelar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginCancelar;
    }
}