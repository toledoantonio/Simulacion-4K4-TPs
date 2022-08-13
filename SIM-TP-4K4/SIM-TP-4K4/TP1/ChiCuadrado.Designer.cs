namespace SIM_TP_4K4.TP1
{
    partial class ChiCuadrado
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvChiCuadrado = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.li = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fefo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblVCalculado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVtabulado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.generadorControladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generadorControladorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiCuadrado
            // 
            this.dgvChiCuadrado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChiCuadrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChiCuadrado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvChiCuadrado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiCuadrado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.li,
            this.ls,
            this.Fo,
            this.FE,
            this.fefo,
            this.C,
            this.C2,
            this.aca});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiCuadrado.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChiCuadrado.Location = new System.Drawing.Point(5, 12);
            this.dgvChiCuadrado.Name = "dgvChiCuadrado";
            this.dgvChiCuadrado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiCuadrado.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChiCuadrado.RowHeadersVisible = false;
            this.dgvChiCuadrado.RowHeadersWidth = 51;
            this.dgvChiCuadrado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChiCuadrado.Size = new System.Drawing.Size(964, 294);
            this.dgvChiCuadrado.TabIndex = 42;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.generadorControladorBindingSource;
            this.chart1.Location = new System.Drawing.Point(23, 303);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(414, 292);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart";
            // 
            // li
            // 
            this.li.HeaderText = "Lim inf";
            this.li.Name = "li";
            // 
            // ls
            // 
            this.ls.HeaderText = "Lim sup";
            this.ls.Name = "ls";
            // 
            // Fo
            // 
            this.Fo.HeaderText = "FO";
            this.Fo.Name = "Fo";
            this.Fo.Width = 120;
            // 
            // FE
            // 
            this.FE.HeaderText = "FE";
            this.FE.Name = "FE";
            this.FE.Width = 120;
            // 
            // fefo
            // 
            this.fefo.HeaderText = "FE - FO";
            this.fefo.Name = "fefo";
            this.fefo.Width = 120;
            // 
            // C
            // 
            this.C.HeaderText = "(FE - FO) ^ 2";
            this.C.Name = "C";
            this.C.Width = 120;
            // 
            // C2
            // 
            this.C2.HeaderText = "(FE - FO) ^ 2 / FE";
            this.C2.Name = "C2";
            this.C2.Width = 150;
            // 
            // aca
            // 
            this.aca.HeaderText = "Acumulado";
            this.aca.Name = "aca";
            this.aca.Width = 120;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(575, 320);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(144, 18);
            this.lblNivel.TabIndex = 44;
            this.lblNivel.Text = "Nivel de significancia";
            // 
            // lblVCalculado
            // 
            this.lblVCalculado.AutoSize = true;
            this.lblVCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVCalculado.Location = new System.Drawing.Point(622, 408);
            this.lblVCalculado.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblVCalculado.Name = "lblVCalculado";
            this.lblVCalculado.Size = new System.Drawing.Size(50, 18);
            this.lblVCalculado.TabIndex = 45;
            this.lblVCalculado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Valor tabulado";
            // 
            // lblVtabulado
            // 
            this.lblVtabulado.AutoSize = true;
            this.lblVtabulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVtabulado.Location = new System.Drawing.Point(622, 469);
            this.lblVtabulado.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblVtabulado.Name = "lblVtabulado";
            this.lblVtabulado.Size = new System.Drawing.Size(50, 18);
            this.lblVtabulado.TabIndex = 47;
            this.lblVtabulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Valor calculado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(536, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Resultado de la prueba de ajuste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(622, 349);
            this.label5.MinimumSize = new System.Drawing.Size(50, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 50;
            this.label5.Text = "5%";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(536, 541);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 18);
            this.lblResultado.TabIndex = 51;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generadorControladorBindingSource
            // 
            this.generadorControladorBindingSource.DataSource = typeof(SIM_TP_4K4.Generador.GeneradorControlador);
            // 
            // ChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 616);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVtabulado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVCalculado);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvChiCuadrado);
            this.Name = "ChiCuadrado";
            this.Text = "ChiCuadrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generadorControladorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiCuadrado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource generadorControladorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn li;
        private System.Windows.Forms.DataGridViewTextBoxColumn ls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn fefo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn aca;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblVCalculado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVtabulado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultado;
    }
}