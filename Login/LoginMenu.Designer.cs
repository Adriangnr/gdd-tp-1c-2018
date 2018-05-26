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
            this.SuspendLayout();
            // 
            // btnLoginMenuSalir
            // 
            this.btnLoginMenuSalir.Location = new System.Drawing.Point(655, 389);
            this.btnLoginMenuSalir.Name = "btnLoginMenuSalir";
            this.btnLoginMenuSalir.Size = new System.Drawing.Size(133, 49);
            this.btnLoginMenuSalir.TabIndex = 0;
            this.btnLoginMenuSalir.Text = "Salir";
            this.btnLoginMenuSalir.UseVisualStyleBackColor = true;
            this.btnLoginMenuSalir.Click += new System.EventHandler(this.btnLoginMenuSalir_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoginMenuSalir);
            this.Name = "LoginMenu";
            this.Text = "LoginMenu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginMenuSalir;
    }
}