namespace ProjetoCtrl
{
    partial class FormEditaCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditaCar));
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEditar = new System.Windows.Forms.DataGridView();
            this.txtEditKmCar = new System.Windows.Forms.TextBox();
            this.txtEditPrecoCar = new System.Windows.Forms.TextBox();
            this.chkEditAlcoolCar = new System.Windows.Forms.CheckBox();
            this.chkEditGasolinaCar = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEditAnoCar = new System.Windows.Forms.ComboBox();
            this.cbxEditCambioCar = new System.Windows.Forms.ComboBox();
            this.cbxEditModeloCar = new System.Windows.Forms.ComboBox();
            this.cbxEditCorCar = new System.Windows.Forms.ComboBox();
            this.cbxEditMarcaCar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditCarCancelar = new System.Windows.Forms.Button();
            this.btnEditCarResetar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEditBlindadoCar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1143, 289);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(190, 68);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Alterar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEditar);
            this.panel1.Controls.Add(this.txtEditKmCar);
            this.panel1.Controls.Add(this.txtEditPrecoCar);
            this.panel1.Controls.Add(this.chkEditAlcoolCar);
            this.panel1.Controls.Add(this.chkEditGasolinaCar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxEditAnoCar);
            this.panel1.Controls.Add(this.cbxEditCambioCar);
            this.panel1.Controls.Add(this.cbxEditModeloCar);
            this.panel1.Controls.Add(this.cbxEditCorCar);
            this.panel1.Controls.Add(this.cbxEditMarcaCar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 749);
            this.panel1.TabIndex = 3;
            this.panel1.Enter += new System.EventHandler(this.panel1_Enter);
            // 
            // dgvEditar
            // 
            this.dgvEditar.AllowDrop = true;
            this.dgvEditar.AllowUserToAddRows = false;
            this.dgvEditar.AllowUserToDeleteRows = false;
            this.dgvEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEditar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvEditar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEditar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditar.ColumnHeadersHeight = 30;
            this.dgvEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEditar.EnableHeadersVisualStyles = false;
            this.dgvEditar.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEditar.Location = new System.Drawing.Point(16, 389);
            this.dgvEditar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dgvEditar.Name = "dgvEditar";
            this.dgvEditar.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEditar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditar.Size = new System.Drawing.Size(1338, 343);
            this.dgvEditar.TabIndex = 44;
            this.dgvEditar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditar_CellClick_1);
            // 
            // txtEditKmCar
            // 
            this.txtEditKmCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditKmCar.Location = new System.Drawing.Point(370, 306);
            this.txtEditKmCar.Name = "txtEditKmCar";
            this.txtEditKmCar.Size = new System.Drawing.Size(254, 27);
            this.txtEditKmCar.TabIndex = 42;
            // 
            // txtEditPrecoCar
            // 
            this.txtEditPrecoCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPrecoCar.Location = new System.Drawing.Point(721, 106);
            this.txtEditPrecoCar.Name = "txtEditPrecoCar";
            this.txtEditPrecoCar.Size = new System.Drawing.Size(221, 27);
            this.txtEditPrecoCar.TabIndex = 41;
            // 
            // chkEditAlcoolCar
            // 
            this.chkEditAlcoolCar.AutoSize = true;
            this.chkEditAlcoolCar.BackColor = System.Drawing.Color.SteelBlue;
            this.chkEditAlcoolCar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditAlcoolCar.ForeColor = System.Drawing.Color.White;
            this.chkEditAlcoolCar.Location = new System.Drawing.Point(690, 234);
            this.chkEditAlcoolCar.Name = "chkEditAlcoolCar";
            this.chkEditAlcoolCar.Size = new System.Drawing.Size(75, 24);
            this.chkEditAlcoolCar.TabIndex = 40;
            this.chkEditAlcoolCar.Text = "Álcool";
            this.chkEditAlcoolCar.UseVisualStyleBackColor = false;
            // 
            // chkEditGasolinaCar
            // 
            this.chkEditGasolinaCar.AutoSize = true;
            this.chkEditGasolinaCar.BackColor = System.Drawing.Color.SteelBlue;
            this.chkEditGasolinaCar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditGasolinaCar.ForeColor = System.Drawing.Color.White;
            this.chkEditGasolinaCar.Location = new System.Drawing.Point(690, 266);
            this.chkEditGasolinaCar.Name = "chkEditGasolinaCar";
            this.chkEditGasolinaCar.Size = new System.Drawing.Size(92, 24);
            this.chkEditGasolinaCar.TabIndex = 39;
            this.chkEditGasolinaCar.Text = "Gasolina";
            this.chkEditGasolinaCar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(366, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Quilometragem";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SteelBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(366, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Câmbio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.SteelBlue;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(686, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(686, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(686, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Combustível";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(366, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ano do Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Modelo";
            // 
            // cbxEditAnoCar
            // 
            this.cbxEditAnoCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditAnoCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEditAnoCar.FormattingEnabled = true;
            this.cbxEditAnoCar.Items.AddRange(new object[] {
            " ",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950"});
            this.cbxEditAnoCar.Location = new System.Drawing.Point(53, 303);
            this.cbxEditAnoCar.Name = "cbxEditAnoCar";
            this.cbxEditAnoCar.Size = new System.Drawing.Size(254, 29);
            this.cbxEditAnoCar.TabIndex = 27;
            // 
            // cbxEditCambioCar
            // 
            this.cbxEditCambioCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditCambioCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEditCambioCar.FormattingEnabled = true;
            this.cbxEditCambioCar.Items.AddRange(new object[] {
            " ",
            "Automático",
            "Manual",
            "Semi-Automático"});
            this.cbxEditCambioCar.Location = new System.Drawing.Point(370, 204);
            this.cbxEditCambioCar.Name = "cbxEditCambioCar";
            this.cbxEditCambioCar.Size = new System.Drawing.Size(254, 29);
            this.cbxEditCambioCar.TabIndex = 26;
            // 
            // cbxEditModeloCar
            // 
            this.cbxEditModeloCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditModeloCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEditModeloCar.FormattingEnabled = true;
            this.cbxEditModeloCar.Location = new System.Drawing.Point(53, 205);
            this.cbxEditModeloCar.Name = "cbxEditModeloCar";
            this.cbxEditModeloCar.Size = new System.Drawing.Size(254, 29);
            this.cbxEditModeloCar.TabIndex = 25;
            // 
            // cbxEditCorCar
            // 
            this.cbxEditCorCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditCorCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEditCorCar.FormattingEnabled = true;
            this.cbxEditCorCar.Items.AddRange(new object[] {
            " ",
            "Amarelo",
            "Azul",
            "Bege",
            "Branco",
            "Bronze",
            "Cinza",
            "Dourado",
            "Indefinida",
            "Laranja",
            "Marrom",
            "Prata",
            "Preto",
            "Rosa",
            "Roxo",
            "Verde",
            "Vermelho",
            "Vinho"});
            this.cbxEditCorCar.Location = new System.Drawing.Point(370, 106);
            this.cbxEditCorCar.Name = "cbxEditCorCar";
            this.cbxEditCorCar.Size = new System.Drawing.Size(254, 29);
            this.cbxEditCorCar.TabIndex = 28;
            // 
            // cbxEditMarcaCar
            // 
            this.cbxEditMarcaCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditMarcaCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEditMarcaCar.FormattingEnabled = true;
            this.cbxEditMarcaCar.Location = new System.Drawing.Point(53, 106);
            this.cbxEditMarcaCar.Name = "cbxEditMarcaCar";
            this.cbxEditMarcaCar.Size = new System.Drawing.Size(254, 29);
            this.cbxEditMarcaCar.TabIndex = 24;
            this.cbxEditMarcaCar.SelectedIndexChanged += new System.EventHandler(this.cbxEditMarcaCar_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnEditCarCancelar);
            this.groupBox1.Controls.Add(this.btnEditCarResetar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkEditBlindadoCar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 365);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Carro";
            // 
            // btnEditCarCancelar
            // 
            this.btnEditCarCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCarCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnEditCarCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCarCancelar.Location = new System.Drawing.Point(746, 289);
            this.btnEditCarCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCarCancelar.Name = "btnEditCarCancelar";
            this.btnEditCarCancelar.Size = new System.Drawing.Size(190, 68);
            this.btnEditCarCancelar.TabIndex = 2;
            this.btnEditCarCancelar.Text = "Cancelar";
            this.btnEditCarCancelar.UseVisualStyleBackColor = false;
            this.btnEditCarCancelar.Click += new System.EventHandler(this.btnEditCarCancelar_Click);
            // 
            // btnEditCarResetar
            // 
            this.btnEditCarResetar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCarResetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnEditCarResetar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCarResetar.Location = new System.Drawing.Point(944, 289);
            this.btnEditCarResetar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCarResetar.Name = "btnEditCarResetar";
            this.btnEditCarResetar.Size = new System.Drawing.Size(190, 68);
            this.btnEditCarResetar.TabIndex = 2;
            this.btnEditCarResetar.Text = "Resetar";
            this.btnEditCarResetar.UseVisualStyleBackColor = false;
            this.btnEditCarResetar.Click += new System.EventHandler(this.btnEditCarResetar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Marca";
            // 
            // chkEditBlindadoCar
            // 
            this.chkEditBlindadoCar.AutoSize = true;
            this.chkEditBlindadoCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditBlindadoCar.Location = new System.Drawing.Point(676, 146);
            this.chkEditBlindadoCar.Name = "chkEditBlindadoCar";
            this.chkEditBlindadoCar.Size = new System.Drawing.Size(97, 25);
            this.chkEditBlindadoCar.TabIndex = 38;
            this.chkEditBlindadoCar.Text = "Blindado";
            this.chkEditBlindadoCar.UseVisualStyleBackColor = true;
            // 
            // FormEditaCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormEditaCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Carro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEditaCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEditKmCar;
        private System.Windows.Forms.TextBox txtEditPrecoCar;
        private System.Windows.Forms.CheckBox chkEditAlcoolCar;
        private System.Windows.Forms.CheckBox chkEditGasolinaCar;
        private System.Windows.Forms.CheckBox chkEditBlindadoCar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxEditAnoCar;
        private System.Windows.Forms.ComboBox cbxEditCambioCar;
        private System.Windows.Forms.ComboBox cbxEditModeloCar;
        private System.Windows.Forms.ComboBox cbxEditCorCar;
        private System.Windows.Forms.ComboBox cbxEditMarcaCar;
        private System.Windows.Forms.Button btnEditCarCancelar;
        private System.Windows.Forms.Button btnEditCarResetar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEditar;
    }
}