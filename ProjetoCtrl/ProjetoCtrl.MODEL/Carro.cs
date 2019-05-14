using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCtrl.MODEL
{
    public class Carro : Veiculo
    {
        public int Id_Car { get; set; }
        public string Cambio { get; set; }
        public string Blindado { get; set; }
        public Carro()
        {
            Id_Car = 0;
            Cambio = null;
            Blindado = null;
        }
        public Carro(int id_car, string marca, string modelo, string combustivel, string cor, int ano, decimal quilometragem, string cambio, string blindado, decimal preco) : base(marca, modelo, combustivel, cor, ano, quilometragem, preco)
        {
            Id_Car = id_car;
            Cambio = cambio;
            Blindado = blindado;
        }
    }
}
