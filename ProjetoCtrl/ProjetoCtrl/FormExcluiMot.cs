using ProjetoCtrl.DAO;
using ProjetoCtrl.MODEL;
using System;
using System.Collections.Generic;
//acrescentando o using Collections
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCtrl
{
    public partial class FormExcluiMot : Form
    {
        public FormExcluiMot()
        {
            InitializeComponent();
        }
        public int CarroID { get; set; }

        private void FormExcluiMot_Load(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            dgvExcluirMoto.DataSource = mot.ListaGridMoto();
        }

        private void btnExcluirMoto_Click(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            ArrayList arr = new ArrayList();
            try
            {
                int cod_moto = int.Parse(txtExcluirMoto.Text);
                //Se todos os campos forem inseridos dentro do array
                if (mot.DeletarMoto(cod_moto))
                {
                    MessageBox.Show("Apagado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormExcluiMot_Load(e, e);
                }
                else
                {
                    MessageBox.Show("Erro ao Apagar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"{erro} Erro Ocorrido");
            }
        }
        private void dgvExcluirMoto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CarroID = Convert.ToInt32(dgvExcluirMoto.SelectedRows[0].Cells[0].Value);
            txtExcluirMoto.Text = CarroID.ToString();
        }
    }
}
