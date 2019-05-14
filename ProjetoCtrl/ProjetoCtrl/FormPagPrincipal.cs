using ProjetoCtrl.DAO;
using ProjetoCtrl.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCtrl
{
    public partial class FormPagPrincipal : Form
    {
        public FormPagPrincipal()
        {
            InitializeComponent();
        }

        private void cadCarro_Click(object sender, EventArgs e)
        {
            FormCadCarro frm = new FormCadCarro();
            frm.Show();
        }

        private void cadMoto_Click(object sender, EventArgs e)
        {
            FormCadMot frm = new FormCadMot();
            frm.Show();
        }

        private void editCarro_Click(object sender, EventArgs e)
        {
            FormEditaCar frm = new FormEditaCar();
            frm.Show();
        }

        private void excCarro_Click(object sender, EventArgs e)
        {
            FormExcluiCar frm = new FormExcluiCar();
            frm.Show();
        }

        private void pesqCarro_Click(object sender, EventArgs e)
        {
            FormPesquisaCar frm = new FormPesquisaCar();
            frm.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void editMoto_Click(object sender, EventArgs e)
        {
            FormEditaMot frm = new FormEditaMot();
            frm.Show();
        }

        private void excMoto_Click(object sender, EventArgs e)
        {
            FormExcluiMot frm = new FormExcluiMot();
            frm.Show();
        }

        private void pesqMoto_Click(object sender, EventArgs e)
        {
            FormPesquisaMot frm = new FormPesquisaMot();
            frm.Show();
        }

        private void FormPagPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
