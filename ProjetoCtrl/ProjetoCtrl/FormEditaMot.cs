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
    public partial class FormEditaMot : Form
    {
        public FormEditaMot()
        {
            InitializeComponent();
        }
        private int motoID;

        public void Resetar()
        {
            cbxEditMarcaMot.Text = null;
            cbxEditModeloMot.Text = null;
            cbxEditAnoMot.Text = null;
            chkEditAlcoolMot.Checked = false;
            chkEditGasolinaMot.Checked = false;
            cbxEditPartidaMot.Text = null;
            cbxEditAlimentacaoMot.Text = null;
            cbxEditRefrigeracaoMot.Text = null;
            cbxEditFreioMot.Text = null;
            cbxEditQtdMarchasMot.Text = null;
            txtEditKmMot.Text = null;
            cbxEditCorMot.Text = null;
            txtEditPrecoMot.Text = null;
        }
        private void dgvEditarMot_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Moto motModel = new Moto();
            /*[id_mot], [marca_mot], [modelo_mot], [ano_mot], [combustivel_mot], [tipoPartida_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [qtdMarchas_mot], [quilometragem_mot], [cor_mot], [preco_mot], */
            motoID = Convert.ToInt32(dgvEditarMot.SelectedRows[0].Cells[0].Value);
            cbxEditMarcaMot.Text = dgvEditarMot.SelectedRows[0].Cells[1].Value.ToString();
            cbxEditModeloMot.Text = dgvEditarMot.SelectedRows[0].Cells[2].Value.ToString();
            cbxEditAnoMot.Text = dgvEditarMot.SelectedRows[0].Cells[3].Value.ToString();
            motModel.Combustivel = dgvEditarMot.SelectedRows[0].Cells[4].Value.ToString();
            if (motModel.Combustivel == "Álcool e Gasolina")
            {
                chkEditAlcoolMot.Checked = true;
                chkEditGasolinaMot.Checked = true;
            }
            else if (motModel.Combustivel == "Álcool")
            {
                chkEditAlcoolMot.Checked = true;
                chkEditGasolinaMot.Checked = false;
            }
            else if (motModel.Combustivel == "Gasolina")
            {
                chkEditGasolinaMot.Checked = true;
                chkEditAlcoolMot.Checked = false;
            }
            cbxEditPartidaMot.Text = dgvEditarMot.SelectedRows[0].Cells[5].Value.ToString();
            cbxEditAlimentacaoMot.Text = dgvEditarMot.SelectedRows[0].Cells[6].Value.ToString();
            cbxEditRefrigeracaoMot.Text = dgvEditarMot.SelectedRows[0].Cells[7].Value.ToString();
            cbxEditFreioMot.Text = dgvEditarMot.SelectedRows[0].Cells[8].Value.ToString();
            cbxEditQtdMarchasMot.Text = dgvEditarMot.SelectedRows[0].Cells[9].Value.ToString();
            motModel.Quilometragem = Convert.ToDecimal(dgvEditarMot.SelectedRows[0].Cells[10].Value);
            txtEditKmMot.Text = motModel.Quilometragem.ToString("N0");
            cbxEditCorMot.Text = dgvEditarMot.SelectedRows[0].Cells[11].Value.ToString();
            motModel.Preco = Convert.ToDecimal(dgvEditarMot.SelectedRows[0].Cells[12].Value.ToString());
            txtEditPrecoMot.Text = motModel.Preco.ToString("N2");
        }
        private void btnEditMot_Click(object sender, EventArgs e)
        {
            /*[marca_mot], [modelo_mot], [ano_mot], [corPrimaria_mot], [cor_mot],  [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [tipoPartida_mot], [qtdMarchas_mot], [quilometragem_mot], [preco_mot], [combustivel_car]*/
            if (string.IsNullOrWhiteSpace(cbxEditMarcaMot.Text))
                MessageBox.Show("Marca precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditModeloMot.Text))
                MessageBox.Show("Modelo precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditAnoMot.Text))
                MessageBox.Show("Ano precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditCorMot.Text))
                MessageBox.Show("Cor precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditAlimentacaoMot.Text))
                MessageBox.Show("Tipo Alimentação precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditRefrigeracaoMot.Text))
                MessageBox.Show("Tipo Refrigeração precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditFreioMot.Text))
                MessageBox.Show("Tipo Freio precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditPartidaMot.Text))
                MessageBox.Show("Tipo Partida precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cbxEditQtdMarchasMot.Text))
                MessageBox.Show("Quantidade de Marchas precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtEditKmMot.Text))
                MessageBox.Show("Quilometragem precisa ser informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(txtEditPrecoMot.Text))
                MessageBox.Show("Preço precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtEditPrecoMot.Text.Length > 20)
                MessageBox.Show("Preço pode ter até 20 digitos somente", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (chkEditAlcoolMot.Checked == false && chkEditGasolinaMot.Checked == false)
                MessageBox.Show("Combustível precisa ser informado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MotoDAO mot = new MotoDAO();
                ArrayList arr = new ArrayList();
                /*[marca_mot], [modelo_mot], [ano_mot], [combustivel_mot], [tipoPartida_mot], [tipoAlimentacao_mot], [tipoRefrigeracao_mot], [tipoFreio_mot], [qtdMarchas_mot], [quilometragem_mot], [cor_mot], [preco_mot], */
                try
                {
                    arr.Add(motoID);
                    arr.Add(cbxEditMarcaMot.Text);
                    arr.Add(cbxEditModeloMot.Text);
                    arr.Add(cbxEditAnoMot.Text);
                    if (chkEditAlcoolMot.Checked && chkEditGasolinaMot.Checked)
                        arr.Add("Álcool e Gasolina");
                    else if (chkEditAlcoolMot.Checked)
                        arr.Add("Álcool");
                    else if (chkEditGasolinaMot.Checked)
                        arr.Add("Gasolina");
                    arr.Add(cbxEditPartidaMot.Text);
                    arr.Add(cbxEditAlimentacaoMot.Text);
                    arr.Add(cbxEditRefrigeracaoMot.Text);
                    arr.Add(cbxEditFreioMot.Text);
                    arr.Add(cbxEditQtdMarchasMot.Text);
                    arr.Add(float.Parse(txtEditKmMot.Text));
                    arr.Add(cbxEditCorMot.Text);
                    arr.Add(decimal.Parse(txtEditPrecoMot.Text));

                    //Se todos os campos forem inseridos dentro do array
                    if (mot.AtualizarMoto(arr))
                    {
                        MessageBox.Show("Alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormEditaMot_Load(e, e);
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

        private void FormEditaMot_Load(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            dgvEditarMot.DataSource = mot.ListaGridMoto();
            cbxEditMarcaMot.DataSource = mot.ListaMarcaMoto();
            cbxEditMarcaMot.DisplayMember = "marca_mot";
        }

        private void btnEditResetarMot_Click(object sender, EventArgs e)
        {
            Resetar();
        }

        private void btnEditCancMot_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar a edição?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxEditMarcaMot_SelectedIndexChanged(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            cbxEditModeloMot.DataSource = mot.ListaModeloMoto(cbxEditMarcaMot.Text);
            cbxEditModeloMot.DisplayMember = "modelo_mot";
        }

        
    }
}
