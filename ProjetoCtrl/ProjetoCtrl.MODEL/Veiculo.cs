using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCtrl.MODEL
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public decimal Quilometragem { get; set; }
        public decimal Preco { get; set; }

        public Veiculo()
        {
            Marca = null;
            Modelo = null;
            Combustivel = null;
            Combustivel = null;
            Cor = null;
            Ano = 0;
            Quilometragem = 0.0m;
            Preco = 0.0m;
        }
        public Veiculo(string marca, string modelo, string combustivel, string cor, int ano, decimal quilometragem, decimal preco)
        {
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
            Cor = cor;
            Ano = ano;
            Quilometragem = quilometragem;
            Preco = preco;
        }
    }
}
