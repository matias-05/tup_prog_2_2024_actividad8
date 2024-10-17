namespace Actividad8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.btVerCuentas = new System.Windows.Forms.Button();
            this.btImportar = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            this.btResguardar = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(12, 12);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(487, 199);
            this.tbInfo.TabIndex = 0;
            // 
            // btVerCuentas
            // 
            this.btVerCuentas.Location = new System.Drawing.Point(505, 12);
            this.btVerCuentas.Name = "btVerCuentas";
            this.btVerCuentas.Size = new System.Drawing.Size(178, 35);
            this.btVerCuentas.TabIndex = 1;
            this.btVerCuentas.Text = "1- Ver cuentas";
            this.btVerCuentas.UseVisualStyleBackColor = true;
            this.btVerCuentas.Click += new System.EventHandler(this.btVerCuentas_Click);
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(505, 53);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(178, 35);
            this.btImportar.TabIndex = 2;
            this.btImportar.Text = "2- Importar cuentas";
            this.btImportar.UseVisualStyleBackColor = true;
            this.btImportar.Click += new System.EventHandler(this.btImportar_Click);
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(505, 94);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(178, 35);
            this.btExportar.TabIndex = 3;
            this.btExportar.Text = "3- Exportar cuentas";
            this.btExportar.UseVisualStyleBackColor = true;
            // 
            // btResguardar
            // 
            this.btResguardar.Location = new System.Drawing.Point(505, 135);
            this.btResguardar.Name = "btResguardar";
            this.btResguardar.Size = new System.Drawing.Size(178, 35);
            this.btResguardar.TabIndex = 4;
            this.btResguardar.Text = "4- Resguardar (Backup)";
            this.btResguardar.UseVisualStyleBackColor = true;
            // 
            // btRestaurar
            // 
            this.btRestaurar.Location = new System.Drawing.Point(505, 176);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(178, 35);
            this.btRestaurar.TabIndex = 5;
            this.btRestaurar.Text = "5- Restaurar (Restore)";
            this.btRestaurar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 220);
            this.Controls.Add(this.btRestaurar);
            this.Controls.Add(this.btResguardar);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btImportar);
            this.Controls.Add(this.btVerCuentas);
            this.Controls.Add(this.tbInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Button btVerCuentas;
        private System.Windows.Forms.Button btImportar;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Button btResguardar;
        private System.Windows.Forms.Button btRestaurar;
    }
}

