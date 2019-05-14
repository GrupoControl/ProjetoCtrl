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
    public partial class FormPesquisaCar : Form
    {
        public FormPesquisaCar()
        {
            InitializeComponent();
        }
        private void FormPesquisaCar_Load(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            dgvPesquisar.DataSource = car.ListaGridCarro();
        }

        private void btnPesquisarCar_Click(object sender, EventArgs e)
        {
            CarroDAO car = new CarroDAO();
            string sql;
            if(rdbPorNome.Checked)
            {
                /*[id_car] [marca_car], [modelo_car], [ano_car], [combustivel_car],[quilometragem_car], [cambio_car], [blindado_car], [cor_car], [preco_car]*/
                sql = "SELECT [id_car] as Código, [marca_car] as Marca, [modelo_car] as Modelo, [ano_car] as Ano, [combustivel_car] as Combustível,[quilometragem_car] as Quilometragem, [cambio_car] as Câmbio, [blindado_car] as Blindado, [cor_car] as Cor, [preco_car] as Preço FROM [ProjetoCtrl].[dbo].[TbCarro] WHERE [marca_car] LIKE @valor OR [modelo_car] LIKE @valor OR [ano_car] LIKE @valor OR [combustivel_car] LIKE @valor OR [quilometragem_car] LIKE @valor OR [cambio_car] LIKE @valor OR [blindado_car] LIKE @valor OR [cor_car] LIKE @valor OR [preco_car] LIKE @valor"; dgvPesquisar.DataSource = car.Pesquisar(sql, $"%{txtPesquisar.Text}%");
            }
            else
            {
                sql = "SELECT [id_car] as Código, [marca_car] as Marca, [modelo_car] as Modelo, [ano_car] as Ano, [combustivel_car] as Combustível,[quilometragem_car] as Quilometragem, [cambio_car] as Câmbio, [blindado_car] as Blindado, [cor_car] as Cor, [preco_car] as Preço FROM [ProjetoCtrl].[dbo].[TbCarro] WHERE [id_car] = @valor"; dgvPesquisar.DataSource = car.Pesquisar(sql, txtPesquisar.Text);
            }
        }
    }
}
