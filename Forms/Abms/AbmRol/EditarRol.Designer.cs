namespace FrbaHotel.AbmRol
{
    partial class EditarRol
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
            System.Windows.Forms.TextBox txtEditarRolNombre;
            this.chkListFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.btnEditarRolCancelar = new System.Windows.Forms.Button();
            this.btnEditarRolGuardar = new System.Windows.Forms.Button();
            this.chkEditarRolActivo = new System.Windows.Forms.CheckBox();
            this.labelAltaRolFuncionalidades = new System.Windows.Forms.Label();
            this.labelAltaRolNombre = new System.Windows.Forms.Label();
            this.labelEditarRolId = new System.Windows.Forms.Label();
            this.labelIdValue = new System.Windows.Forms.Label();
            txtEditarRolNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEditarRolNombre
            // 
            txtEditarRolNombre.Location = new System.Drawing.Point(227, 50);
            txtEditarRolNombre.Name = "txtEditarRolNombre";
            txtEditarRolNombre.Size = new System.Drawing.Size(214, 26);
            txtEditarRolNombre.TabIndex = 17;
            // 
            // chkListFuncionalidades
            // 
            this.chkListFuncionalidades.FormattingEnabled = true;
            this.chkListFuncionalidades.Location = new System.Drawing.Point(17, 157);
            this.chkListFuncionalidades.Name = "chkListFuncionalidades";
            this.chkListFuncionalidades.Size = new System.Drawing.Size(199, 109);
            this.chkListFuncionalidades.TabIndex = 22;
            // 
            // btnEditarRolCancelar
            // 
            this.btnEditarRolCancelar.Location = new System.Drawing.Point(327, 330);
            this.btnEditarRolCancelar.Name = "btnEditarRolCancelar";
            this.btnEditarRolCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnEditarRolCancelar.TabIndex = 21;
            this.btnEditarRolCancelar.Text = "Cancelar";
            this.btnEditarRolCancelar.UseVisualStyleBackColor = true;
            this.btnEditarRolCancelar.Click += new System.EventHandler(this.btnEditarRolCancelar_Click);
            // 
            // btnEditarRolGuardar
            // 
            this.btnEditarRolGuardar.Location = new System.Drawing.Point(17, 330);
            this.btnEditarRolGuardar.Name = "btnEditarRolGuardar";
            this.btnEditarRolGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnEditarRolGuardar.TabIndex = 20;
            this.btnEditarRolGuardar.Text = "Guardar";
            this.btnEditarRolGuardar.UseVisualStyleBackColor = true;
            this.btnEditarRolGuardar.Click += new System.EventHandler(this.btnEditarRolGuardar_Click);
            // 
            // chkEditarRolActivo
            // 
            this.chkEditarRolActivo.AutoSize = true;
            this.chkEditarRolActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkEditarRolActivo.Location = new System.Drawing.Point(17, 286);
            this.chkEditarRolActivo.Name = "chkEditarRolActivo";
            this.chkEditarRolActivo.Size = new System.Drawing.Size(78, 24);
            this.chkEditarRolActivo.TabIndex = 19;
            this.chkEditarRolActivo.Text = "Activo";
            this.chkEditarRolActivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkEditarRolActivo.UseVisualStyleBackColor = true;
            // 
            // labelAltaRolFuncionalidades
            // 
            this.labelAltaRolFuncionalidades.AutoSize = true;
            this.labelAltaRolFuncionalidades.Location = new System.Drawing.Point(13, 121);
            this.labelAltaRolFuncionalidades.Name = "labelAltaRolFuncionalidades";
            this.labelAltaRolFuncionalidades.Size = new System.Drawing.Size(203, 20);
            this.labelAltaRolFuncionalidades.TabIndex = 18;
            this.labelAltaRolFuncionalidades.Text = "Listado de Funcionalidades";
            // 
            // labelAltaRolNombre
            // 
            this.labelAltaRolNombre.AutoSize = true;
            this.labelAltaRolNombre.Location = new System.Drawing.Point(14, 56);
            this.labelAltaRolNombre.Name = "labelAltaRolNombre";
            this.labelAltaRolNombre.Size = new System.Drawing.Size(118, 20);
            this.labelAltaRolNombre.TabIndex = 16;
            this.labelAltaRolNombre.Text = "Nombre del Rol";
            // 
            // labelEditarRolId
            // 
            this.labelEditarRolId.AutoSize = true;
            this.labelEditarRolId.Location = new System.Drawing.Point(14, 89);
            this.labelEditarRolId.Name = "labelEditarRolId";
            this.labelEditarRolId.Size = new System.Drawing.Size(23, 20);
            this.labelEditarRolId.TabIndex = 23;
            this.labelEditarRolId.Text = "Id";
            // 
            // labelIdValue
            // 
            this.labelIdValue.AutoSize = true;
            this.labelIdValue.Location = new System.Drawing.Point(44, 89);
            this.labelIdValue.Name = "labelIdValue";
            this.labelIdValue.Size = new System.Drawing.Size(51, 20);
            this.labelIdValue.TabIndex = 24;
            this.labelIdValue.Text = "label1";
            this.labelIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 392);
            this.Controls.Add(this.labelIdValue);
            this.Controls.Add(this.labelEditarRolId);
            this.Controls.Add(this.chkListFuncionalidades);
            this.Controls.Add(this.btnEditarRolCancelar);
            this.Controls.Add(this.btnEditarRolGuardar);
            this.Controls.Add(this.chkEditarRolActivo);
            this.Controls.Add(this.labelAltaRolFuncionalidades);
            this.Controls.Add(txtEditarRolNombre);
            this.Controls.Add(this.labelAltaRolNombre);
            this.Name = "EditarRol";
            this.Text = "EditarRol";
            this.Load += new System.EventHandler(this.EditarRol_Load);
            this.Controls.SetChildIndex(this.labelAltaRolNombre, 0);
            this.Controls.SetChildIndex(txtEditarRolNombre, 0);
            this.Controls.SetChildIndex(this.labelAltaRolFuncionalidades, 0);
            this.Controls.SetChildIndex(this.chkEditarRolActivo, 0);
            this.Controls.SetChildIndex(this.btnEditarRolGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditarRolCancelar, 0);
            this.Controls.SetChildIndex(this.chkListFuncionalidades, 0);
            this.Controls.SetChildIndex(this.labelEditarRolId, 0);
            this.Controls.SetChildIndex(this.labelIdValue, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListFuncionalidades;
        private System.Windows.Forms.Button btnEditarRolCancelar;
        private System.Windows.Forms.Button btnEditarRolGuardar;
        private System.Windows.Forms.CheckBox chkEditarRolActivo;
        private System.Windows.Forms.Label labelAltaRolFuncionalidades;
        private System.Windows.Forms.Label labelAltaRolNombre;
        private System.Windows.Forms.Label labelEditarRolId;
        private System.Windows.Forms.Label labelIdValue;
    }
}