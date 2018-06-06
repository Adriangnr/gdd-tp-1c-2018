namespace FrbaHotel.Login
{
    partial class LoginPerfil
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
            this.labelLoginPerfil = new System.Windows.Forms.Label();
            this.comboLoginPerfil = new System.Windows.Forms.ComboBox();
            this.btnLoginPerfilContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginPerfil
            // 
            this.labelLoginPerfil.AutoSize = true;
            this.labelLoginPerfil.Location = new System.Drawing.Point(90, 46);
            this.labelLoginPerfil.Name = "labelLoginPerfil";
            this.labelLoginPerfil.Size = new System.Drawing.Size(146, 20);
            this.labelLoginPerfil.TabIndex = 0;
            this.labelLoginPerfil.Text = "Seleccione su perfil";
            this.labelLoginPerfil.Click += new System.EventHandler(this.labelLoginPerfil_Click);
            // 
            // comboLoginPerfil
            // 
            this.comboLoginPerfil.FormattingEnabled = true;
            this.comboLoginPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista"});
            this.comboLoginPerfil.Location = new System.Drawing.Point(66, 69);
            this.comboLoginPerfil.Name = "comboLoginPerfil";
            this.comboLoginPerfil.Size = new System.Drawing.Size(198, 28);
            this.comboLoginPerfil.TabIndex = 1;
            this.comboLoginPerfil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnLoginPerfilContinuar
            // 
            this.btnLoginPerfilContinuar.Location = new System.Drawing.Point(94, 165);
            this.btnLoginPerfilContinuar.Name = "btnLoginPerfilContinuar";
            this.btnLoginPerfilContinuar.Size = new System.Drawing.Size(142, 39);
            this.btnLoginPerfilContinuar.TabIndex = 2;
            this.btnLoginPerfilContinuar.Text = "Continuar";
            this.btnLoginPerfilContinuar.UseVisualStyleBackColor = true;
            this.btnLoginPerfilContinuar.Click += new System.EventHandler(this.btnLoginPerfilContinuar_Click);
            // 
            // LoginPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 228);
            this.Controls.Add(this.btnLoginPerfilContinuar);
            this.Controls.Add(this.comboLoginPerfil);
            this.Controls.Add(this.labelLoginPerfil);
            this.Name = "LoginPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPerfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginPerfil;
        private System.Windows.Forms.ComboBox comboLoginPerfil;
        private System.Windows.Forms.Button btnLoginPerfilContinuar;
    }
}