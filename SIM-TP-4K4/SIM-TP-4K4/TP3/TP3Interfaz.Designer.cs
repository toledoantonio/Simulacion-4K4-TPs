namespace SIM_TP_4K4.TP2
{
    partial class TP3Interfaz
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
            this.TxtTamañoMuestra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIntervalos = new System.Windows.Forms.TextBox();
            this.dgvRandoms = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonExpo = new System.Windows.Forms.RadioButton();
            this.radioButtonPoisson = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.parametro1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Variables = new System.Windows.Forms.TabPage();
            this.Test = new System.Windows.Forms.TabPage();
            this.Grafico = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonCHI = new System.Windows.Forms.RadioButton();
            this.radioButtonKS = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandoms)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Variables.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTamañoMuestra
            // 
            this.TxtTamañoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTamañoMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTamañoMuestra.Location = new System.Drawing.Point(201, 80);
            this.TxtTamañoMuestra.Name = "TxtTamañoMuestra";
            this.TxtTamañoMuestra.Size = new System.Drawing.Size(51, 24);
            this.TxtTamañoMuestra.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tamaño de Muestra (N)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cantidad de Intervalos";
            // 
            // TxtIntervalos
            // 
            this.TxtIntervalos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntervalos.Location = new System.Drawing.Point(201, 31);
            this.TxtIntervalos.Name = "TxtIntervalos";
            this.TxtIntervalos.Size = new System.Drawing.Size(51, 24);
            this.TxtIntervalos.TabIndex = 35;
            // 
            // dgvRandoms
            // 
            this.dgvRandoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandoms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.RND});
            this.dgvRandoms.Location = new System.Drawing.Point(16, 6);
            this.dgvRandoms.Name = "dgvRandoms";
            this.dgvRandoms.Size = new System.Drawing.Size(226, 413);
            this.dgvRandoms.TabIndex = 36;
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteracion";
            this.iteracion.Name = "iteracion";
            // 
            // RND
            // 
            this.RND.HeaderText = "RND";
            this.RND.Name = "RND";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(1038, 96);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 39;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPoisson);
            this.groupBox1.Controls.Add(this.radioButtonExpo);
            this.groupBox1.Controls.Add(this.radioButtonNormal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(298, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribucion";
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(11, 19);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(69, 20);
            this.radioButtonNormal.TabIndex = 0;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonExpo
            // 
            this.radioButtonExpo.AutoSize = true;
            this.radioButtonExpo.Location = new System.Drawing.Point(11, 42);
            this.radioButtonExpo.Name = "radioButtonExpo";
            this.radioButtonExpo.Size = new System.Drawing.Size(99, 20);
            this.radioButtonExpo.TabIndex = 1;
            this.radioButtonExpo.TabStop = true;
            this.radioButtonExpo.Text = "Exponencial";
            this.radioButtonExpo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPoisson
            // 
            this.radioButtonPoisson.AutoSize = true;
            this.radioButtonPoisson.Location = new System.Drawing.Point(11, 65);
            this.radioButtonPoisson.Name = "radioButtonPoisson";
            this.radioButtonPoisson.Size = new System.Drawing.Size(74, 20);
            this.radioButtonPoisson.TabIndex = 2;
            this.radioButtonPoisson.TabStop = true;
            this.radioButtonPoisson.Text = "Poisson";
            this.radioButtonPoisson.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.parametro1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(661, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 92);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // parametro1
            // 
            this.parametro1.AutoSize = true;
            this.parametro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parametro1.Location = new System.Drawing.Point(28, 29);
            this.parametro1.Name = "parametro1";
            this.parametro1.Size = new System.Drawing.Size(68, 18);
            this.parametro1.TabIndex = 35;
            this.parametro1.Text = "ASDSAD";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Variables);
            this.tabControl1.Controls.Add(this.Test);
            this.tabControl1.Controls.Add(this.Grafico);
            this.tabControl1.Location = new System.Drawing.Point(15, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 446);
            this.tabControl1.TabIndex = 42;
            // 
            // Variables
            // 
            this.Variables.Controls.Add(this.dgvRandoms);
            this.Variables.Location = new System.Drawing.Point(4, 22);
            this.Variables.Name = "Variables";
            this.Variables.Padding = new System.Windows.Forms.Padding(3);
            this.Variables.Size = new System.Drawing.Size(1007, 420);
            this.Variables.TabIndex = 0;
            this.Variables.Text = "Variables";
            this.Variables.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(4, 22);
            this.Test.Name = "Test";
            this.Test.Padding = new System.Windows.Forms.Padding(3);
            this.Test.Size = new System.Drawing.Size(360, 271);
            this.Test.TabIndex = 1;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // Grafico
            // 
            this.Grafico.Location = new System.Drawing.Point(4, 22);
            this.Grafico.Name = "Grafico";
            this.Grafico.Padding = new System.Windows.Forms.Padding(3);
            this.Grafico.Size = new System.Drawing.Size(883, 342);
            this.Grafico.TabIndex = 2;
            this.Grafico.Text = "Grafico";
            this.Grafico.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonKS);
            this.groupBox3.Controls.Add(this.radioButtonCHI);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(504, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 92);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prueba de Ajuste";
            // 
            // radioButtonCHI
            // 
            this.radioButtonCHI.AutoSize = true;
            this.radioButtonCHI.Location = new System.Drawing.Point(19, 27);
            this.radioButtonCHI.Name = "radioButtonCHI";
            this.radioButtonCHI.Size = new System.Drawing.Size(107, 20);
            this.radioButtonCHI.TabIndex = 0;
            this.radioButtonCHI.TabStop = true;
            this.radioButtonCHI.Text = "Chi Cuadrado";
            this.radioButtonCHI.UseVisualStyleBackColor = true;
            // 
            // radioButtonKS
            // 
            this.radioButtonKS.AutoSize = true;
            this.radioButtonKS.Location = new System.Drawing.Point(19, 58);
            this.radioButtonKS.Name = "radioButtonKS";
            this.radioButtonKS.Size = new System.Drawing.Size(42, 20);
            this.radioButtonKS.TabIndex = 1;
            this.radioButtonKS.TabStop = true;
            this.radioButtonKS.Text = "KS";
            this.radioButtonKS.UseVisualStyleBackColor = true;
            // 
            // TP3Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.TxtIntervalos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTamañoMuestra);
            this.Controls.Add(this.label1);
            this.Name = "TP3Interfaz";
            this.Text = "TP3Interfaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandoms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Variables.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTamañoMuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIntervalos;
        private System.Windows.Forms.DataGridView dgvRandoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RND;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPoisson;
        private System.Windows.Forms.RadioButton radioButtonExpo;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label parametro1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Variables;
        private System.Windows.Forms.TabPage Test;
        private System.Windows.Forms.TabPage Grafico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonKS;
        private System.Windows.Forms.RadioButton radioButtonCHI;
    }
}