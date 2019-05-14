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
    public partial class FormPesquisaMot : Form
    {
        public FormPesquisaMot()
        {
            InitializeComponent();
        }

        private void FormPesquisaMot_Load(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            dgvPesquisarMot.DataSource = mot.ListaGridMoto();
        }

        private void btnPesquisarMot_Click(object sender, EventArgs e)
        {
            MotoDAO mot = new MotoDAO();
            string sql;
            if (rdbPorNomeMot.Checked)
            {
                sql = "SELECT [id_mot] as Cód, [marca_mot] as Marca, [modelo_mot] as Modelo, [ano_mot] as Ano, [combustivel_mot] as Combustível, [tipoPartida_mot] as Partida, [tipoAlimentacao_mot] as Alimentação, [tipoRefrigeracao_mot] as Refrigeração, [tipoFreio_mot] as Freio, [qtdMarchas_mot] as Marchas, [quilometragem_mot] as Km, [cor_mot] as Cor, [preco_mot] as Preço FROM [ProjetoCtrl].[dbo].[TbMoto] WHERE [marca_mot] LIKE @valor OR [modelo_mot] LIKE @valor OR [ano_mot] LIKE @valor OR [combustivel_mot] LIKE @valor OR [tipoPartida_mot] LIKE @valor OR [tipoAlimentacao_mot] LIKE @valor OR [tipoRefrigeracao_mot] LIKE @valor OR [tipoFreio_mot] LIKE @valor OR [qtdMarchas_mot] LIKE @valor OR [quilometragem_mot] LIKE @valor OR [cor_mot] LIKE @valor OR [preco_mot] LIKE @valor"; dgvPesquisarMot.DataSource = mot.Pesquisar(sql, $"%{txtPesquisarMot.Text}%");
            }
            else
            {
                sql = "SELECT [id_mot] as Cód, [marca_mot] as Marca, [modelo_mot] as Modelo, [ano_mot] as Ano, [combustivel_mot] as Combustível, [tipoPartida_mot] as Partida, [tipoAlimentacao_mot] as Alimentação, [tipoRefrigeracao_mot] as Refrigeração, [tipoFreio_mot] as Freio, [qtdMarchas_mot] as Marchas, [quilometragem_mot] as Km, [cor_mot] as Cor, [preco_mot] as Preço FROM [ProjetoCtrl].[dbo].[TbMoto] WHERE [id_mot] = @valor"; dgvPesquisarMot.DataSource = mot.Pesquisar(sql, txtPesquisarMot.Text);
            }
        }
    }
}
