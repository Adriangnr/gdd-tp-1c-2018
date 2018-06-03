namespace FrbaHotel.AbmRol
{
    partial class AltaRol
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
            System.Windows.Forms.TextBox txtAltaRolNombre;
            this.labelAltaRolNombre = new System.Windows.Forms.Label();
            this.labelAltaRolFuncionalidades = new System.Windows.Forms.Label();
            this.chkAltaRolActivo = new System.Windows.Forms.CheckBox();
            this.btnAltaUsuarioCancelar = new System.Windows.Forms.Button();
            this.btnAltaRolGuardar = new System.Windows.Forms.Button();
            this.chkListFuncionalidades = new System.Windows.Forms.CheckedListBox();
            txtAltaRolNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAltaRolNombre
            // 
            txtAltaRolNombre.Location = new System.Drawing.Point(226, 65);
            txtAltaRolNombre.Name = "txtAltaRolNombre";
            txtAltaRolNombre.Size = new System.Drawing.Size(214, 26);
            txtAltaRolNombre.TabIndex = 3;
            txtAltaRolNombre.TextChanged += new System.EventHandler(this.txtAltaRolNombre_TextChanged);
            // 
            // labelAltaRolNombre
            // 
            this.labelAltaRolNombre.AutoSize = true;
            this.labelAltaRolNombre.Location = new System.Drawing.Point(13, 71);
            this.labelAltaRolNombre.Name = "labelAltaRolNombre";
            this.labelAltaRolNombre.Size = new System.Drawing.Size(118, 20);
            this.labelAltaRolNombre.TabIndex = 2;
            this.labelAltaRolNombre.Text = "Nombre del Rol";
            // 
            // labelAltaRolFuncionalidades
            // 
            this.labelAltaRolFuncionalidades.AutoSize = true;
            this.labelAltaRolFuncionalidades.Location = new System.Drawing.Point(13, 124);
            this.labelAltaRolFuncionalidades.Name = "labelAltaRolFuncionalidades";
            this.labelAltaRolFuncionalidades.Size = new System.Drawing.Size(203, 20);
            this.labelAltaRolFuncionalidades.TabIndex = 4;
            this.labelAltaRolFuncionalidades.Text = "Listado de Funcionalidades";
            // 
            // chkAltaRolActivo
            // 
            this.chkAltaRolActivo.AutoSize = true;
            this.chkAltaRolActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAltaRolActivo.Location = new System.Drawing.Point(17, 289);
            this.chkAltaRolActivo.Name = "chkAltaRolActivo";
            this.chkAltaRolActivo.Size = new System.Drawing.Size(78, 24);
            this.chkAltaRolActivo.TabIndex = 12;
            this.chkAltaRolActivo.Text = "Activo";
            this.chkAltaRolActivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkAltaRolActivo.UseVisualStyleBackColor = true;
            // 
            // btnAltaUsuarioCancelar
            // 
            this.btnAltaUsuarioCancelar.Location = new System.Drawing.Point(327, 333);
            this.btnAltaUsuarioCancelar.Name = "btnAltaUsuarioCancelar";
            this.btnAltaUsuarioCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnAltaUsuarioCancelar.TabIndex = 14;
            this.btnAltaUsuarioCancelar.Text = "Cancelar";
            this.btnAltaUsuarioCancelar.UseVisualStyleBackColor = true;
            this.btnAltaUsuarioCancelar.Click += new System.EventHandler(this.btnAltaUsuarioCancelar_Click);
            // 
            // btnAltaRolGuardar
            // 
            this.btnAltaRolGuardar.Location = new System.Drawing.Point(17, 333);
            this.btnAltaRolGuardar.Name = "btnAltaRolGuardar";
            this.btnAltaRolGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnAltaRolGuardar.TabIndex = 13;
            this.btnAltaRolGuardar.Text = "Guardar";
            this.btnAltaRolGuardar.UseVisualStyleBackColor = true;
            this.btnAltaRolGuardar.Click += new System.EventHandler(this.btnAltaRolGuardar_Click);
            // 
            // chkListFuncionalidades
            // 
            this.chkListFuncionalidades.FormattingEnabled = true;
            this.chkListFuncionalidades.Location = new System.Drawing.Point(17, 160);
            this.chkListFuncionalidades.Name = "chkListFuncionalidades";
            this.chkListFuncionalidades.Size = new System.Drawing.Size(199, 109);
            this.chkListFuncionalidades.TabIndex = 15;
            this.chkListFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.chkListFuncionalidades_SelectedIndexChanged);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 389);
            this.Controls.Add(this.chkListFuncionalidades);
            this.Controls.Add(this.btnAltaUsuarioCancelar);
            this.Controls.Add(this.btnAltaRolGuardar);
            this.Controls.Add(this.chkAltaRolActivo);
            this.Controls.Add(this.labelAltaRolFuncionalidades);
            this.Controls.Add(txtAltaRolNombre);
            this.Controls.Add(this.labelAltaRolNombre);
            this.Name = "AltaRol";
            this.Text = "AltaRol";
            this.Controls.SetChildIndex(this.labelAltaRolNombre, 0);
            this.Controls.SetChildIndex(txtAltaRolNombre, 0);
            this.Controls.SetChildIndex(this.labelAltaRolFuncionalidades, 0);
            this.Controls.SetChildIndex(this.chkAltaRolActivo, 0);
            this.Controls.SetChildIndex(this.btnAltaRolGuardar, 0);
            this.Controls.SetChildIndex(this.btnAltaUsuarioCancelar, 0);
            this.Controls.SetChildIndex(this.chkListFuncionalidades, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAltaRolNombre;
        private System.Windows.Forms.Label labelAltaRolFuncionalidades;
        private System.Windows.Forms.CheckBox chkAltaRolActivo;
        private System.Windows.Forms.Button btnAltaUsuarioCancelar;
        private System.Windows.Forms.Button btnAltaRolGuardar;
        private System.Windows.Forms.CheckedListBox chkListFuncionalidades;
    }
}