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
    public partial class FormCadMot : Form
    {
        public FormCadMot()
        {
            InitializeComponent();
        }
        public void Resetar()
        {
            cbxCadMarcaMot.Text = null;
            cbxCadModeloMot.Text = null;
            cbxCadAnoMot.Text = null;
            chkCadAlcoolMot.Checked = false;
            chkCadGasolinaMot.Checked = false;
            cbxCadPartidaMot.Text = null;
            cbxCadAlimentacaoMot.Text = null;
            cbxCadRefrigeracaoMot.Text = null;
            cbxCadFreioMot.Text = null;
            cbxCadQtdMarchasMot.Text = null;
            txtCadKmMot.Text = null;
            cbxCadCorMot.Text = null;
            txtCadPrecoMot.Text = null;
        }

        private void btnCadMot_Click(object sender, EventArgs e)
        {
            /*[marca_mot], [modelo_mot], [ano_mot], [cor_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [tipoPartida_mot], [qtdMarchas_mot], [quilometragem_mot], [preco_mot], [combustivel_car]*/
            if (string.IsNullOrWhiteSpace(cbxCadMarcaMot.Text))
                MessageBox.Show("Marca precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadModeloMot.Text))
                MessageBox.Show("Modelo precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadAnoMot.Text))
                MessageBox.Show("Ano precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadCorMot.Text))
                MessageBox.Show("Cor precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadAlimentacaoMot.Text))
                MessageBox.Show("Tipo Alimentação precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadRefrigeracaoMot.Text))
                MessageBox.Show("Tipo Refrigeração precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadFreioMot.Text))
                MessageBox.Show("Tipo Freio precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadPartidaMot.Text))
                MessageBox.Show("Tipo Partida precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxCadQtdMarchasMot.Text))
                MessageBox.Show("Quantidade de Marchas precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtCadKmMot.Text))
                MessageBox.Show("Quilometragem precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtCadPrecoMot.Text))
                MessageBox.Show("Preço precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtCadPrecoMot.Text.Length > 20)
                MessageBox.Show("Preço pode ter até 20 digitos somente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (chkCadAlcoolMot.Checked == false && chkCadGasolinaMot.Checked == false)
                MessageBox.Show("Combustível precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Moto motModel = new Moto();
                MotoDAO mot = new MotoDAO();
                ArrayList arr = new ArrayList();
                /*[marca_mot], [modelo_mot], [ano_mot], [combustivel_mot], [tipoPartida_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [qtdMarchas_mot], [quilometragem_mot], [cor_mot], [preco_mot], */
                try
                {
                    arr.Add(cbxCadMarcaMot.Text);
                    arr.Add(cbxCadModeloMot.Text);
                    arr.Add(cbxCadAnoMot.Text);
                    if (chkCadAlcoolMot.Checked && chkCadGasolinaMot.Checked)
                        arr.Add("Álcool e Gasolina");
                    else if (chkCadAlcoolMot.Checked)
                        arr.Add("Álcool");
                    else if (chkCadGasolinaMot.Checked)
                        arr.Add("Gasolina");
                    arr.Add(cbxCadPartidaMot.Text);
                    arr.Add(cbxCadAlimentacaoMot.Text);
                    arr.Add(cbxCadRefrigeracaoMot.Text);
                    arr.Add(cbxCadFreioMot.Text);
                    arr.Add(cbxCadQtdMarchasMot.Text);
                    motModel.Quilometragem = Convert.ToDecimal(txtCadKmMot.Text);
                    arr.Add(motModel.Quilometragem).ToString("N0");
                    arr.Add(cbxCadCorMot.Text);
                    motModel.Preco = Convert.ToDecimal(txtCadPrecoMot.Text);
                    arr.Add(motModel.Preco).ToString("N2");

                    //Se todos os campos forem inseridos dentro do array
                    if (mot.InserirMoto(arr))
                    {
                        MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormCadMot_Load(e, e);
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
        private void FormCadMot_Load(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            dgvCadastrarMot.DataSource = mot.ListaGridMoto();
            //cbxCadMarcaMot.DataSource = obj.ListaMarcaMot();
            //cbxCadMarcaMot.DisplayMember = "marca";
        }

        private void btnCadResetarMot_Click(object sender, EventArgs e)
        {
            Resetar();
        }

        private void btnCadCancMot_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar o cadastro?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormCadMot_Load_1(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            dgvCadastrarMot.DataSource = mot.ListaGridMoto();
            cbxCadMarcaMot.DataSource = mot.ListaMarcaMoto();
            cbxCadMarcaMot.DisplayMember = "marca_mot";
        }

        private void cbxCadMarcaMot_SelectedIndexChanged(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            cbxCadModeloMot.DataSource = mot.ListaModeloMoto(cbxCadMarcaMot.Text);
            cbxCadModeloMot.DisplayMember = "modelo_mot";
        }
    }
}
