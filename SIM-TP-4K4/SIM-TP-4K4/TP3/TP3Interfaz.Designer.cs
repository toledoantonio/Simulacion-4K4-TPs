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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TP3Interfaz));
            this.TxtTamañoMuestra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIntervalos = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPoisson = new System.Windows.Forms.RadioButton();
            this.radioButtonExpo = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtParametro2 = new System.Windows.Forms.TextBox();
            this.txtParametro1 = new System.Windows.Forms.TextBox();
            this.lblParametro2 = new System.Windows.Forms.Label();
            this.lblParametro1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Variables = new System.Windows.Forms.TabPage();
            this.dvgVariable = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgRandoms = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test = new System.Windows.Forms.TabPage();
            this.dvgPrueba = new System.Windows.Forms.DataGridView();
            this.li = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grafico = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonKS = new System.Windows.Forms.RadioButton();
            this.radioButtonCHI = new System.Windows.Forms.RadioButton();
            this.btn_volverMenu = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.Cmb_intervalos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Variables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRandoms)).BeginInit();
            this.Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrueba)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTamañoMuestra
            // 
            this.TxtTamañoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTamañoMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTamañoMuestra.Location = new System.Drawing.Point(197, 79);
            this.TxtTamañoMuestra.Name = "TxtTamañoMuestra";
            this.TxtTamañoMuestra.Size = new System.Drawing.Size(51, 24);
            this.TxtTamañoMuestra.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tamaño de Muestra (N)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cantidad de Intervalos";
            // 
            // TxtIntervalos
            // 
            this.TxtIntervalos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIntervalos.Location = new System.Drawing.Point(19, 4);
            this.TxtIntervalos.Name = "TxtIntervalos";
            this.TxtIntervalos.Size = new System.Drawing.Size(51, 24);
            this.TxtIntervalos.TabIndex = 35;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(966, 21);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(175, 40);
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
            this.groupBox1.Location = new System.Drawing.Point(270, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribucion";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParametro2);
            this.groupBox2.Controls.Add(this.txtParametro1);
            this.groupBox2.Controls.Add(this.lblParametro2);
            this.groupBox2.Controls.Add(this.lblParametro1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(661, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 92);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // txtParametro2
            // 
            this.txtParametro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro2.Location = new System.Drawing.Point(164, 59);
            this.txtParametro2.Name = "txtParametro2";
            this.txtParametro2.Size = new System.Drawing.Size(51, 22);
            this.txtParametro2.TabIndex = 45;
            this.txtParametro2.Visible = false;
            // 
            // txtParametro1
            // 
            this.txtParametro1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro1.Location = new System.Drawing.Point(164, 27);
            this.txtParametro1.Name = "txtParametro1";
            this.txtParametro1.Size = new System.Drawing.Size(51, 22);
            this.txtParametro1.TabIndex = 44;
            this.txtParametro1.Visible = false;
            // 
            // lblParametro2
            // 
            this.lblParametro2.AutoSize = true;
            this.lblParametro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro2.Location = new System.Drawing.Point(57, 61);
            this.lblParametro2.Name = "lblParametro2";
            this.lblParametro2.Size = new System.Drawing.Size(77, 16);
            this.lblParametro2.TabIndex = 36;
            this.lblParametro2.Text = "Parametro2";
            this.lblParametro2.Visible = false;
            // 
            // lblParametro1
            // 
            this.lblParametro1.AutoSize = true;
            this.lblParametro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro1.Location = new System.Drawing.Point(57, 29);
            this.lblParametro1.Name = "lblParametro1";
            this.lblParametro1.Size = new System.Drawing.Size(77, 16);
            this.lblParametro1.TabIndex = 35;
            this.lblParametro1.Text = "Parametro1";
            this.lblParametro1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Variables);
            this.tabControl1.Controls.Add(this.Test);
            this.tabControl1.Controls.Add(this.Grafico);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 446);
            this.tabControl1.TabIndex = 42;
            // 
            // Variables
            // 
            this.Variables.Controls.Add(this.dvgVariable);
            this.Variables.Controls.Add(this.dvgRandoms);
            this.Variables.Location = new System.Drawing.Point(4, 25);
            this.Variables.Name = "Variables";
            this.Variables.Padding = new System.Windows.Forms.Padding(3);
            this.Variables.Size = new System.Drawing.Size(1132, 417);
            this.Variables.TabIndex = 0;
            this.Variables.Text = "Variables";
            this.Variables.UseVisualStyleBackColor = true;
            // 
            // dvgVariable
            // 
            this.dvgVariable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgVariable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgVariable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgVariable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgVariable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgVariable.ColumnHeadersHeight = 29;
            this.dvgVariable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable});
            this.dvgVariable.Location = new System.Drawing.Point(286, 3);
            this.dvgVariable.Name = "dvgVariable";
            this.dvgVariable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgVariable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgVariable.RowHeadersVisible = false;
            this.dvgVariable.RowHeadersWidth = 51;
            this.dvgVariable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgVariable.Size = new System.Drawing.Size(101, 413);
            this.dvgVariable.TabIndex = 39;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            // 
            // dvgRandoms
            // 
            this.dvgRandoms.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgRandoms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgRandoms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgRandoms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgRandoms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgRandoms.ColumnHeadersHeight = 29;
            this.dvgRandoms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.random});
            this.dvgRandoms.Location = new System.Drawing.Point(7, 6);
            this.dvgRandoms.Name = "dvgRandoms";
            this.dvgRandoms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgRandoms.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgRandoms.RowHeadersVisible = false;
            this.dvgRandoms.RowHeadersWidth = 51;
            this.dvgRandoms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgRandoms.Size = new System.Drawing.Size(251, 413);
            this.dvgRandoms.TabIndex = 37;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.MinimumWidth = 6;
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.Width = 125;
            // 
            // random
            // 
            this.random.HeaderText = "RND";
            this.random.MinimumWidth = 6;
            this.random.Name = "random";
            this.random.Width = 125;
            // 
            // Test
            // 
            this.Test.Controls.Add(this.dvgPrueba);
            this.Test.Location = new System.Drawing.Point(4, 22);
            this.Test.Name = "Test";
            this.Test.Padding = new System.Windows.Forms.Padding(3);
            this.Test.Size = new System.Drawing.Size(1132, 420);
            this.Test.TabIndex = 1;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // dvgPrueba
            // 
            this.dvgPrueba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPrueba.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgPrueba.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgPrueba.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgPrueba.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPrueba.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgPrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.li,
            this.ls,
            this.Fo,
            this.FE});
            this.dvgPrueba.Location = new System.Drawing.Point(7, 6);
            this.dvgPrueba.Name = "dvgPrueba";
            this.dvgPrueba.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPrueba.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgPrueba.RowHeadersVisible = false;
            this.dvgPrueba.RowHeadersWidth = 51;
            this.dvgPrueba.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgPrueba.Size = new System.Drawing.Size(1119, 395);
            this.dvgPrueba.TabIndex = 43;
            // 
            // li
            // 
            this.li.FillWeight = 80F;
            this.li.HeaderText = "Lim inf";
            this.li.Name = "li";
            // 
            // ls
            // 
            this.ls.FillWeight = 80F;
            this.ls.HeaderText = "Lim sup";
            this.ls.Name = "ls";
            // 
            // Fo
            // 
            this.Fo.HeaderText = "FO";
            this.Fo.Name = "Fo";
            // 
            // FE
            // 
            this.FE.HeaderText = "FE";
            this.FE.Name = "FE";
            // 
            // Grafico
            // 
            this.Grafico.Location = new System.Drawing.Point(4, 22);
            this.Grafico.Name = "Grafico";
            this.Grafico.Padding = new System.Windows.Forms.Padding(3);
            this.Grafico.Size = new System.Drawing.Size(1132, 420);
            this.Grafico.TabIndex = 2;
            this.Grafico.Text = "Grafico";
            this.Grafico.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonKS);
            this.groupBox3.Controls.Add(this.radioButtonCHI);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(490, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 92);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prueba de Ajuste";
            // 
            // radioButtonKS
            // 
            this.radioButtonKS.AutoSize = true;
            this.radioButtonKS.Location = new System.Drawing.Point(19, 58);
            this.radioButtonKS.Name = "radioButtonKS";
            this.radioButtonKS.Size = new System.Drawing.Size(42, 20);
            this.radioButtonKS.TabIndex = 1;
            this.radioButtonKS.Text = "KS";
            this.radioButtonKS.UseVisualStyleBackColor = true;
            // 
            // radioButtonCHI
            // 
            this.radioButtonCHI.AutoSize = true;
            this.radioButtonCHI.Location = new System.Drawing.Point(19, 27);
            this.radioButtonCHI.Name = "radioButtonCHI";
            this.radioButtonCHI.Size = new System.Drawing.Size(107, 20);
            this.radioButtonCHI.TabIndex = 0;
            this.radioButtonCHI.Text = "Chi Cuadrado";
            this.radioButtonCHI.UseVisualStyleBackColor = true;
            // 
            // btn_volverMenu
            // 
            this.btn_volverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volverMenu.Location = new System.Drawing.Point(1061, 71);
            this.btn_volverMenu.Name = "btn_volverMenu";
            this.btn_volverMenu.Size = new System.Drawing.Size(80, 42);
            this.btn_volverMenu.TabIndex = 44;
            this.btn_volverMenu.Text = "Volver al Menu";
            this.btn_volverMenu.UseVisualStyleBackColor = true;
            this.btn_volverMenu.Click += new System.EventHandler(this.btn_volverMenu_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(966, 72);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(80, 41);
            this.btn_limpiar.TabIndex = 45;
            this.btn_limpiar.Text = "Limpiar Campos";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // Cmb_intervalos
            // 
            this.Cmb_intervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_intervalos.FormattingEnabled = true;
            this.Cmb_intervalos.Items.AddRange(new object[] {
            "8",
            "10",
            "15",
            "20"});
            this.Cmb_intervalos.Location = new System.Drawing.Point(197, 30);
            this.Cmb_intervalos.Name = "Cmb_intervalos";
            this.Cmb_intervalos.Size = new System.Drawing.Size(51, 26);
            this.Cmb_intervalos.TabIndex = 46;
            // 
            // TP3Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 583);
            this.Controls.Add(this.Cmb_intervalos);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_volverMenu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.TxtIntervalos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTamañoMuestra);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TP3Interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP3 - Variables Aleatorias Continuas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Variables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRandoms)).EndInit();
            this.Test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPrueba)).EndInit();
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
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPoisson;
        private System.Windows.Forms.RadioButton radioButtonExpo;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblParametro1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Variables;
        private System.Windows.Forms.TabPage Test;
        private System.Windows.Forms.TabPage Grafico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonKS;
        private System.Windows.Forms.RadioButton radioButtonCHI;
        private System.Windows.Forms.TextBox txtParametro2;
        private System.Windows.Forms.TextBox txtParametro1;
        private System.Windows.Forms.Label lblParametro2;
        private System.Windows.Forms.DataGridView dvgRandoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn random;
        private System.Windows.Forms.DataGridView dvgVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridView dvgPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn li;
        private System.Windows.Forms.DataGridViewTextBoxColumn ls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.Button btn_volverMenu;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ComboBox Cmb_intervalos;
    }
}