namespace ProjetoCtrl
{
    partial class FormPesquisaMot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaMot));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesquisarMot = new System.Windows.Forms.TextBox();
            this.btnPesquisarMot = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbPorCodigoMot = new System.Windows.Forms.RadioButton();
            this.rdbPorNomeMot = new System.Windows.Forms.RadioButton();
            this.dgvPesquisarMot = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarMot)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.txtPesquisarMot);
            this.groupBox1.Controls.Add(this.btnPesquisarMot);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Size = new System.Drawing.Size(1233, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Moto";
            // 
            // txtPesquisarMot
            // 
            this.txtPesquisarMot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarMot.Location = new System.Drawing.Point(15, 76);
            this.txtPesquisarMot.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtPesquisarMot.Name = "txtPesquisarMot";
            this.txtPesquisarMot.Size = new System.Drawing.Size(718, 27);
            this.txtPesquisarMot.TabIndex = 1;
            // 
            // btnPesquisarMot
            // 
            this.btnPesquisarMot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnPesquisarMot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarMot.Location = new System.Drawing.Point(747, 59);
            this.btnPesquisarMot.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnPesquisarMot.Name = "btnPesquisarMot";
            this.btnPesquisarMot.Size = new System.Drawing.Size(178, 61);
            this.btnPesquisarMot.TabIndex = 2;
            this.btnPesquisarMot.Text = "Pesquisar";
            this.btnPesquisarMot.UseVisualStyleBackColor = false;
            this.btnPesquisarMot.Click += new System.EventHandler(this.btnPesquisarMot_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.rdbPorCodigoMot);
            this.groupBox2.Controls.Add(this.rdbPorNomeMot);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(956, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox2.Size = new System.Drawing.Size(210, 122);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Pesquisa";
            // 
            // rdbPorCodigoMot
            // 
            this.rdbPorCodigoMot.AutoSize = true;
            this.rdbPorCodigoMot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPorCodigoMot.Location = new System.Drawing.Point(14, 86);
            this.rdbPorCodigoMot.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rdbPorCodigoMot.Name = "rdbPorCodigoMot";
            this.rdbPorCodigoMot.Size = new System.Drawing.Size(110, 24);
            this.rdbPorCodigoMot.TabIndex = 4;
            this.rdbPorCodigoMot.Text = "Por Código";
            this.rdbPorCodigoMot.UseVisualStyleBackColor = true;
            // 
            // rdbPorNomeMot
            // 
            this.rdbPorNomeMot.AutoSize = true;
            this.rdbPorNomeMot.Checked = true;
            this.rdbPorNomeMot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPorNomeMot.Location = new System.Drawing.Point(14, 46);
            this.rdbPorNomeMot.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rdbPorNomeMot.Name = "rdbPorNomeMot";
            this.rdbPorNomeMot.Size = new System.Drawing.Size(99, 24);
            this.rdbPorNomeMot.TabIndex = 3;
            this.rdbPorNomeMot.TabStop = true;
            this.rdbPorNomeMot.Text = "Por Nome";
            this.rdbPorNomeMot.UseVisualStyleBackColor = true;
            // 
            // dgvPesquisarMot
            // 
            this.dgvPesquisarMot.AllowDrop = true;
            this.dgvPesquisarMot.AllowUserToAddRows = false;
            this.dgvPesquisarMot.AllowUserToDeleteRows = false;
            this.dgvPesquisarMot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPesquisarMot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesquisarMot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPesquisarMot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPesquisarMot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisarMot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPesquisarMot.ColumnHeadersHeight = 30;
            this.dgvPesquisarMot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPesquisarMot.EnableHeadersVisualStyles = false;
            this.dgvPesquisarMot.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPesquisarMot.Location = new System.Drawing.Point(16, 207);
            this.dgvPesquisarMot.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dgvPesquisarMot.Name = "dgvPesquisarMot";
            this.dgvPesquisarMot.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPesquisarMot.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPesquisarMot.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPesquisarMot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisarMot.Size = new System.Drawing.Size(1233, 525);
            this.dgvPesquisarMot.TabIndex = 25;
            // 
            // FormPesquisaMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 749);
            this.Controls.Add(this.dgvPesquisarMot);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormPesquisaMot";
            this.Text = "Pesquisar Moto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPesquisaMot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarMot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesquisarMot;
        private System.Windows.Forms.Button btnPesquisarMot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPorCodigoMot;
        private System.Windows.Forms.RadioButton rdbPorNomeMot;
        private System.Windows.Forms.DataGridView dgvPesquisarMot;
    }
}