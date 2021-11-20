using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Sorvete_11901055_Frederico.Code.DTO
{
    class SorvetesDTO
    {
        private int _id;
        private string _tipo;
        private string _sabor;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}
