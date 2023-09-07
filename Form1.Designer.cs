namespace SIMPA_3D
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
            this.tab_ayuda = new System.Windows.Forms.TabControl();
            this.tab_principal = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_acerca_de = new System.Windows.Forms.TabPage();
            this.tab_ayuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_ayuda
            // 
            this.tab_ayuda.Controls.Add(this.tab_principal);
            this.tab_ayuda.Controls.Add(this.tabPage2);
            this.tab_ayuda.Controls.Add(this.tab_acerca_de);
            this.tab_ayuda.Location = new System.Drawing.Point(12, 3);
            this.tab_ayuda.Name = "tab_ayuda";
            this.tab_ayuda.SelectedIndex = 0;
            this.tab_ayuda.Size = new System.Drawing.Size(969, 610);
            this.tab_ayuda.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tab_ayuda.TabIndex = 0;
            // 
            // tab_principal
            // 
            this.tab_principal.Location = new System.Drawing.Point(4, 29);
            this.tab_principal.Name = "tab_principal";
            this.tab_principal.Padding = new System.Windows.Forms.Padding(3);
            this.tab_principal.Size = new System.Drawing.Size(961, 577);
            this.tab_principal.TabIndex = 0;
            this.tab_principal.Text = "Vista Principal";
            this.tab_principal.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ayuda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab_acerca_de
            // 
            this.tab_acerca_de.Location = new System.Drawing.Point(4, 29);
            this.tab_acerca_de.Name = "tab_acerca_de";
            this.tab_acerca_de.Padding = new System.Windows.Forms.Padding(3);
            this.tab_acerca_de.Size = new System.Drawing.Size(961, 577);
            this.tab_acerca_de.TabIndex = 2;
            this.tab_acerca_de.Text = "Acerca de";
            this.tab_acerca_de.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 615);
            this.Controls.Add(this.tab_ayuda);
            this.Name = "Form1";
            this.Text = "Simulador";
            this.tab_ayuda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ayuda;
        private System.Windows.Forms.TabPage tab_principal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tab_acerca_de;
    }
}

