namespace FrbaHotel.AbmRol
{
    partial class Roles
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
            this.labelFrbaHotelRoles = new System.Windows.Forms.Label();
            this.labelRoles = new System.Windows.Forms.Label();
            this.dataGridRoles = new System.Windows.Forms.DataGridView();
            this.btnRolesCargar = new System.Windows.Forms.Button();
            this.btnAltaRolesCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFrbaHotelRoles
            // 
            this.labelFrbaHotelRoles.AutoSize = true;
            this.labelFrbaHotelRoles.Location = new System.Drawing.Point(13, 13);
            this.labelFrbaHotelRoles.Name = "labelFrbaHotelRoles";
            this.labelFrbaHotelRoles.Size = new System.Drawing.Size(80, 20);
            this.labelFrbaHotelRoles.TabIndex = 0;
            this.labelFrbaHotelRoles.Text = "FrbaHotel";
            // 
            // labelRoles
            // 
            this.labelRoles.AutoSize = true;
            this.labelRoles.Location = new System.Drawing.Point(491, 13);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(50, 20);
            this.labelRoles.TabIndex = 1;
            this.labelRoles.Text = "Roles";
            // 
            // dataGridRoles
            // 
            this.dataGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoles.Location = new System.Drawing.Point(17, 88);
            this.dataGridRoles.Name = "dataGridRoles";
            this.dataGridRoles.RowTemplate.Height = 28;
            this.dataGridRoles.Size = new System.Drawing.Size(524, 224);
            this.dataGridRoles.TabIndex = 2;
            this.dataGridRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoles_CellContentClick);
            // 
            // btnRolesCargar
            // 
            this.btnRolesCargar.Location = new System.Drawing.Point(17, 351);
            this.btnRolesCargar.Name = "btnRolesCargar";
            this.btnRolesCargar.Size = new System.Drawing.Size(163, 41);
            this.btnRolesCargar.TabIndex = 3;
            this.btnRolesCargar.Text = "Cargar nuevo Rol";
            this.btnRolesCargar.UseVisualStyleBackColor = true;
            this.btnRolesCargar.Click += new System.EventHandler(this.btnRolesCargar_Click);
            // 
            // btnAltaRolesCancelar
            // 
            this.btnAltaRolesCancelar.Location = new System.Drawing.Point(424, 351);
            this.btnAltaRolesCancelar.Name = "btnAltaRolesCancelar";
            this.btnAltaRolesCancelar.Size = new System.Drawing.Size(117, 41);
            this.btnAltaRolesCancelar.TabIndex = 4;
            this.btnAltaRolesCancelar.Text = "Cancelar";
            this.btnAltaRolesCancelar.UseVisualStyleBackColor = true;
            this.btnAltaRolesCancelar.Click += new System.EventHandler(this.btnAltaRolesCancelar_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 404);
            this.Controls.Add(this.btnAltaRolesCancelar);
            this.Controls.Add(this.btnRolesCargar);
            this.Controls.Add(this.dataGridRoles);
            this.Controls.Add(this.labelRoles);
            this.Controls.Add(this.labelFrbaHotelRoles);
            this.Name = "Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrbaHotelRoles;
        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.DataGridView dataGridRoles;
        private System.Windows.Forms.Button btnRolesCargar;
        private System.Windows.Forms.Button btnAltaRolesCancelar;
    }
}