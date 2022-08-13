namespace SIM_TP_4K4
{
    partial class MenuPrincipal
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
            this.btn_menuPrincipal = new System.Windows.Forms.Button();
            this.btn2_MenuPrincipal = new System.Windows.Forms.Button();
            this.btn3_MenuPrincipal = new System.Windows.Forms.Button();
            this.txt_Menu = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_menuPrincipal
            // 
            this.btn_menuPrincipal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_menuPrincipal.Location = new System.Drawing.Point(221, 140);
            this.btn_menuPrincipal.Name = "btn_menuPrincipal";
            this.btn_menuPrincipal.Size = new System.Drawing.Size(170, 54);
            this.btn_menuPrincipal.TabIndex = 13;
            this.btn_menuPrincipal.Text = "TP1";
            this.btn_menuPrincipal.UseVisualStyleBackColor = false;
            this.btn_menuPrincipal.Click += new System.EventHandler(this.btn_menuPrincipal_Click);
            // 
            // btn2_MenuPrincipal
            // 
            this.btn2_MenuPrincipal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn2_MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2_MenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2_MenuPrincipal.Location = new System.Drawing.Point(221, 237);
            this.btn2_MenuPrincipal.Name = "btn2_MenuPrincipal";
            this.btn2_MenuPrincipal.Size = new System.Drawing.Size(170, 58);
            this.btn2_MenuPrincipal.TabIndex = 14;
            this.btn2_MenuPrincipal.Text = "TP2";
            this.btn2_MenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // btn3_MenuPrincipal
            // 
            this.btn3_MenuPrincipal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn3_MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3_MenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3_MenuPrincipal.Location = new System.Drawing.Point(221, 338);
            this.btn3_MenuPrincipal.Name = "btn3_MenuPrincipal";
            this.btn3_MenuPrincipal.Size = new System.Drawing.Size(170, 52);
            this.btn3_MenuPrincipal.TabIndex = 15;
            this.btn3_MenuPrincipal.Text = "TP3";
            this.btn3_MenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // txt_Menu
            // 
            this.txt_Menu.AutoSize = true;
            this.txt_Menu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Menu.Location = new System.Drawing.Point(235, 58);
            this.txt_Menu.Name = "txt_Menu";
            this.txt_Menu.Size = new System.Drawing.Size(156, 30);
            this.txt_Menu.TabIndex = 16;
            this.txt_Menu.Text = "Menu Principal";
            this.txt_Menu.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.AutoSize = true;
            this.txt_Nombres.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombres.Location = new System.Drawing.Point(12, 451);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(268, 30);
            this.txt_Nombres.TabIndex = 17;
            this.txt_Nombres.Text = "NOMBRES DE NOSOTROS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 490);
            this.Controls.Add(this.txt_Nombres);
            this.Controls.Add(this.txt_Menu);
            this.Controls.Add(this.btn3_MenuPrincipal);
            this.Controls.Add(this.btn2_MenuPrincipal);
            this.Controls.Add(this.btn_menuPrincipal);
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_menuPrincipal;
        private System.Windows.Forms.Button btn2_MenuPrincipal;
        private System.Windows.Forms.Button btn3_MenuPrincipal;
        private System.Windows.Forms.Label txt_Menu;
        private System.Windows.Forms.Label txt_Nombres;
    }
}

