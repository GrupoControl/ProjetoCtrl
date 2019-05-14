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
    public partial class FormCadCarro : Form
    {
        public FormCadCarro()
        {
            InitializeComponent();
        }
        public void Resetar()
        {
            cbxCadMarcaCar.Text = null;
            cbxCadModeloCar.Text = null;
            cbxCadAnoCar.Text = null;
            chkCadAlcoolCar.Checked = false;
            chkCadGasolinaCar.Checked = false;
            txtCadKmCar.Text = null;
            cbxCadCambioCar.Text = null;
            chkCadBlindadoCar.Checked = false;
            cbxCadCorCar.Text = null;
            txtCadPrecoCar.Text = null;
        }

        private void btnCadCar_Click(object sender, EventArgs e)
        {
            /*[id_car] [marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]*/
            if (string.IsNullOrWhiteSpace(cbxCadMarcaCar.Text))
                MessageBox.Show("Marca precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadModeloCar.Text))
                MessageBox.Show("Modelo precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadAnoCar.Text))
                MessageBox.Show("Ano precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadCorCar.Text))
                MessageBox.Show("Cor precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadCambioCar.Text))
                MessageBox.Show("Câmbio precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtCadKmCar.Text))
                MessageBox.Show("Quilometragem precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtCadPrecoCar.Text))
            MessageBox.Show("Preço precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtCadPrecoCar.Text.Length > 20)
                MessageBox.Show("Preço pode ter até 20 digitos somente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (chkCadAlcoolCar.Checked == false && chkCadGasolinaCar.Checked == false)
                MessageBox.Show("Combustível precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Carro carModel = new Carro();
                CarroDAO car = new CarroDAO();
                ArrayList arr = new ArrayList();
                /*[marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]*/
                try
                {
                    arr.Add(cbxCadMarcaCar.Text);
                    arr.Add(cbxCadModeloCar.Text);
                    arr.Add(cbxCadAnoCar.Text);
                    if (chkCadAlcoolCar.Checked && chkCadGasolinaCar.Checked)
                        arr.Add("Álcool e Gasolina");
                    else if (chkCadAlcoolCar.Checked)
                        arr.Add("Álcool");
                    else if (chkCadGasolinaCar.Checked)
                        arr.Add("Gasolina");
                    carModel.Quilometragem = Convert.ToDecimal(txtCadKmCar.Text);
                    arr.Add(carModel.Quilometragem).ToString("N0");
                    arr.Add(cbxCadCambioCar.Text);
                    if (chkCadBlindadoCar.Checked)
                        arr.Add("Com Blindagem");
                    else
                        arr.Add("Sem Blindagem");
                    arr.Add(cbxCadCorCar.Text);
                    carModel.Preco = Convert.ToDecimal(txtCadPrecoCar.Text);
                    arr.Add(carModel.Preco).ToString("N2");

                    //Se todos os campos forem inseridos dentro do array
                    if (car.InserirCarro(arr))
                    {
                        MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormCadCarro_Load(e, e);
                        Resetar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Cadastrar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show($"{erro} Erro Ocorrido");
                }
            }
        }

        private void FormCadCarro_Load(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            dgvCadastrar.DataSource = car.ListaGridCarro();
            cbxCadMarcaCar.DataSource = car.ListaMarcaCar();
            cbxCadMarcaCar.DisplayMember = "marca";
        }

        private void btnCadCarCanc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar o cadastro?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadCarResetar_Click(object sender, EventArgs e)
        {
            Resetar();
        }

        private void cbxCadMarcaCar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            cbxCadModeloCar.DataSource = car.ListaModeloCar(cbxCadMarcaCar.Text);
            cbxCadModeloCar.DisplayMember = "modelo";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
