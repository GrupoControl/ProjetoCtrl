namespace ProjetoCtrl
{
    partial class FormPagPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.cadCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.cadMoto = new System.Windows.Forms.ToolStripMenuItem();
            this.editar = new System.Windows.Forms.ToolStripMenuItem();
            this.editCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.editMoto = new System.Windows.Forms.ToolStripMenuItem();
            this.excluir = new System.Windows.Forms.ToolStripMenuItem();
            this.excCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.excMoto = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.pesqCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.pesqMoto = new System.Windows.Forms.ToolStripMenuItem();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrar,
            this.editar,
            this.excluir,
            this.pesquisar,
            this.sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.cadastrar;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrar
            // 
            this.cadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadCarro,
            this.cadMoto});
            this.cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("cadastrar.Image")));
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(131, 26);
            this.cadastrar.Text = "Cadastrar";
            // 
            // cadCarro
            // 
            this.cadCarro.Name = "cadCarro";
            this.cadCarro.Size = new System.Drawing.Size(132, 26);
            this.cadCarro.Text = "Carro";
            this.cadCarro.Click += new System.EventHandler(this.cadCarro_Click);
            // 
            // cadMoto
            // 
            this.cadMoto.Name = "cadMoto";
            this.cadMoto.Size = new System.Drawing.Size(132, 26);
            this.cadMoto.Text = "Moto";
            this.cadMoto.Click += new System.EventHandler(this.cadMoto_Click);
            // 
            // editar
            // 
            this.editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCarro,
            this.editMoto});
            this.editar.Image = global::ProjetoCtrl.Properties.Resources.savedisk_floppydisk_guardar_15432;
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(90, 26);
            this.editar.Text = "Editar";
            // 
            // editCarro
            // 
            this.editCarro.Name = "editCarro";
            this.editCarro.Size = new System.Drawing.Size(132, 26);
            this.editCarro.Text = "Carro";
            this.editCarro.Click += new System.EventHandler(this.editCarro_Click);
            // 
            // editMoto
            // 
            this.editMoto.Name = "editMoto";
            this.editMoto.Size = new System.Drawing.Size(132, 26);
            this.editMoto.Text = "Moto";
            this.editMoto.Click += new System.EventHandler(this.editMoto_Click);
            // 
            // excluir
            // 
            this.excluir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excCarro,
            this.excMoto});
            this.excluir.Image = global::ProjetoCtrl.Properties.Resources.remove_delete_exit_close_15451;
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(93, 26);
            this.excluir.Text = "Excluir";
            // 
            // excCarro
            // 
            this.excCarro.Name = "excCarro";
            this.excCarro.Size = new System.Drawing.Size(132, 26);
            this.excCarro.Text = "Carro";
            this.excCarro.Click += new System.EventHandler(this.excCarro_Click);
            // 
            // excMoto
            // 
            this.excMoto.Name = "excMoto";
            this.excMoto.Size = new System.Drawing.Size(132, 26);
            this.excMoto.Text = "Moto";
            this.excMoto.Click += new System.EventHandler(this.excMoto_Click);
            // 
            // pesquisar
            // 
            this.pesquisar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesqCarro,
            this.pesqMoto});
            this.pesquisar.Image = global::ProjetoCtrl.Properties.Resources.search_find_lupa_218891;
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(122, 26);
            this.pesquisar.Text = "Pesquisar";
            // 
            // pesqCarro
            // 
            this.pesqCarro.Name = "pesqCarro";
            this.pesqCarro.Size = new System.Drawing.Size(132, 26);
            this.pesqCarro.Text = "Carro";
            this.pesqCarro.Click += new System.EventHandler(this.pesqCarro_Click);
            // 
            // pesqMoto
            // 
            this.pesqMoto.Name = "pesqMoto";
            this.pesqMoto.Size = new System.Drawing.Size(132, 26);
            this.pesqMoto.Text = "Moto";
            this.pesqMoto.Click += new System.EventHandler(this.pesqMoto_Click);
            // 
            // sair
            // 
            this.sair.Image = global::ProjetoCtrl.Properties.Resources._7_128x1282;
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(69, 26);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProjetoCtrl.Properties.Resources.Sem_título1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1023, 698);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPagPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPagPrincipal";
            this.Text = "Página Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPagPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrar;
        private System.Windows.Forms.ToolStripMenuItem editar;
        private System.Windows.Forms.ToolStripMenuItem excluir;
        private System.Windows.Forms.ToolStripMenuItem pesquisar;
        private System.Windows.Forms.ToolStripMenuItem cadCarro;
        private System.Windows.Forms.ToolStripMenuItem cadMoto;
        private System.Windows.Forms.ToolStripMenuItem editCarro;
        private System.Windows.Forms.ToolStripMenuItem editMoto;
        private System.Windows.Forms.ToolStripMenuItem excCarro;
        private System.Windows.Forms.ToolStripMenuItem excMoto;
        private System.Windows.Forms.ToolStripMenuItem pesqCarro;
        private System.Windows.Forms.ToolStripMenuItem pesqMoto;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}