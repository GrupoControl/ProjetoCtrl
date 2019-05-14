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
    public partial class FormExcluiCar : Form
    {
        public FormExcluiCar()
        {
            InitializeComponent();
        }
        public int CarroID { get; set; }

        private void btnExcluirCar_Click(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            ArrayList arr = new ArrayList();
            /*[id_car] [marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]*/
            try
            {
                int cod_car = int.Parse(txtExcluirCar.Text);
                //Se todos os campos forem inseridos dentro do array
                if (car.DeletarCarro(cod_car))
                {
                    MessageBox.Show("Apagado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormExcluiCar_Load(e, e);
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

        private void FormExcluiCar_Load(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            dgvExcluir.DataSource = car.ListaGridCarro();
        }
        private void dgvExcluir_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CarroID = Convert.ToInt32(dgvExcluir.SelectedRows[0].Cells[0].Value);
            txtExcluirCar.Text = CarroID.ToString();
        }
    }
}
