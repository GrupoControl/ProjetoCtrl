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
using System.Data.SqlClient;

namespace ProjetoCtrl
{
    public partial class FormEditaCar : Form
    {
        public FormEditaCar()
        {
            InitializeComponent();
        }
        private int carroID;

        public void Resetar()
        {
            cbxEditMarcaCar.Text = null;
            cbxEditModeloCar.Text = null;
            cbxEditAnoCar.Text = null;
            chkEditAlcoolCar.Checked = false;
            chkEditGasolinaCar.Checked = false;
            txtEditKmCar.Text = null;
            cbxEditCambioCar.Text = null;
            chkEditBlindadoCar.Checked = false;
            cbxEditCorCar.Text = null;
            txtEditPrecoCar.Text = null;
        }

        private void dgvEditar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Carro carModel = new Carro();
            /*[id_car] [marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]*/
            carroID = Convert.ToInt32(dgvEditar.SelectedRows[0].Cells[0].Value);
            cbxEditMarcaCar.Text = dgvEditar.SelectedRows[0].Cells[1].Value.ToString();
            cbxEditModeloCar.Text = dgvEditar.SelectedRows[0].Cells[2].Value.ToString();
            cbxEditAnoCar.Text = dgvEditar.SelectedRows[0].Cells[3].Value.ToString();
            carModel.Combustivel = dgvEditar.SelectedRows[0].Cells[4].Value.ToString();
            if (carModel.Combustivel == "Álcool e Gasolina")
            {
                chkEditAlcoolCar.Checked = true;
                chkEditGasolinaCar.Checked = true;
            }
            else if (carModel.Combustivel == "Álcool")
            {
                chkEditAlcoolCar.Checked = true;
                chkEditGasolinaCar.Checked = false;
            }
            else if (carModel.Combustivel == "Gasolina")
            {
                chkEditGasolinaCar.Checked = true;
                chkEditAlcoolCar.Checked = false;
            }
            carModel.Quilometragem = Convert.ToDecimal(dgvEditar.SelectedRows[0].Cells[5].Value);
            txtEditKmCar.Text = carModel.Quilometragem.ToString("N0");
            cbxEditCambioCar.Text = dgvEditar.SelectedRows[0].Cells[6].Value.ToString();
            carModel.Blindado = dgvEditar.SelectedRows[0].Cells[7].Value.ToString();
            if (carModel.Blindado == "Com Blindagem")
                chkEditBlindadoCar.Checked = true;
            else
                chkEditBlindadoCar.Checked = false;
            cbxEditCorCar.Text = dgvEditar.SelectedRows[0].Cells[8].Value.ToString();
            carModel.Preco = Convert.ToDecimal(dgvEditar.SelectedRows[0].Cells[9].Value);
            txtEditPrecoCar.Text = carModel.Preco.ToString("N2");
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*[id_car] [marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]*/
            if (string.IsNullOrWhiteSpace(cbxEditMarcaCar.Text))
                MessageBox.Show("Marca precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditModeloCar.Text))
                MessageBox.Show("Modelo precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditAnoCar.Text))
                MessageBox.Show("Ano precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditCorCar.Text))
                MessageBox.Show("Cor precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditCambioCar.Text))
                MessageBox.Show("Câmbio precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtEditKmCar.Text))
                MessageBox.Show("Quilometragem precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtEditPrecoCar.Text))
                MessageBox.Show("Preço precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEditPrecoCar.Text.Length > 20)
                MessageBox.Show("Preço pode ter até 20 digitos somente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (chkEditAlcoolCar.Checked == false && chkEditGasolinaCar.Checked == false)
                MessageBox.Show("Combustível precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                CarroDAO car = new CarroDAO();
                ArrayList arr = new ArrayList();
                /*[id_car] [marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]*/
                try
                {
                    arr.Add(carroID);
                    arr.Add(cbxEditMarcaCar.Text);
                    arr.Add(cbxEditModeloCar.Text);
                    arr.Add(cbxEditAnoCar.Text);
                    if (chkEditAlcoolCar.Checked && chkEditGasolinaCar.Checked)
                        arr.Add("Álcool e Gasolina");
                    else if (chkEditAlcoolCar.Checked)
                        arr.Add("Álcool");
                    else if (chkEditGasolinaCar.Checked)
                        arr.Add("Gasolina");
                    arr.Add(float.Parse(txtEditKmCar.Text));
                    arr.Add(cbxEditCambioCar.Text);
                    if (chkEditBlindadoCar.Checked)
                        arr.Add("Com Blindagem");
                    else
                        arr.Add("Sem Blindagem");
                    arr.Add(cbxEditCorCar.Text);
                    arr.Add(decimal.Parse(txtEditPrecoCar.Text));

                    //Se todos os campos forem inseridos dentro do array
                    if (car.AtualizarCarro(arr))
                    {
                        MessageBox.Show("Alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormEditaCar_Load(e, e);
                        Resetar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show($"{erro} Erro Ocorrido");
                }
            }
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
           
        }

        private void FormEditaCar_Load(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            dgvEditar.DataSource = car.ListaGridCarro();
            cbxEditMarcaCar.DataSource = car.ListaMarcaCar();
            cbxEditMarcaCar.DisplayMember = "marca";
        }

        private void btnEditCarResetar_Click(object sender, EventArgs e)
        {
            Resetar();
        }

        private void btnEditCarCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar a edição?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxEditMarcaCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            cbxEditModeloCar.DataSource = car.ListaModeloCar(cbxEditMarcaCar.Text);
            cbxEditModeloCar.DisplayMember = "modelo";
        }
    }
}
