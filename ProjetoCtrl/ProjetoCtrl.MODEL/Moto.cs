using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCtrl.MODEL
{
    public class Moto : Veiculo
    {
        public int Id_Mot { get; set; }
        public string TipoPartida { get; set; }
        public string TipoAlimentacao { get; set; }
        public string TipoRefrigeracao { get; set; }
        public string TipoFreio { get; set; }
        public int QtdMarchas { get; set; }

        public Moto()
        {
            Id_Mot = 0;
            TipoPartida = null;
            TipoAlimentacao = null;
            TipoRefrigeracao = null;
            TipoFreio = null;
            QtdMarchas = 0;
        }
        public Moto(int id_mot, string marca, string modelo, string combustivel, string cor, int ano, decimal quilometragem, string tipoPartida, string tipoAlimentacao, string tipoRefrigeracao, string tipoFreio, int qtdMarchas, decimal preco) : base(marca, modelo, combustivel, cor, ano, quilometragem, preco)
        {
            Id_Mot = id_mot;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
            Cor = cor;
            Ano = ano;
            Quilometragem = quilometragem;
            TipoPartida = tipoPartida;
            TipoAlimentacao = tipoAlimentacao;
            TipoRefrigeracao = tipoRefrigeracao;
            TipoFreio = tipoFreio;
            QtdMarchas = qtdMarchas;
            Preco = preco;
        }
    }
}
