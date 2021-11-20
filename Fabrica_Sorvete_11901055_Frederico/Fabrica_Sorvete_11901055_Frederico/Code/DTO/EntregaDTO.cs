using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Sorvete_11901055_Frederico.Code.DTO
{
    class EntregaDTO
    {
        private int _identrega;
        private string _endereco;
        private string _numtelefone;
        private string _cep;
        private string _tiposorvete;
        private string _saborsorvete;
        private int _quantidade;

        public int Identrega { get => _identrega; set => _identrega = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Numtelefone { get => _numtelefone; set => _numtelefone = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Tiposorvete { get => _tiposorvete; set => _tiposorvete = value; }
        public string Saborsorvete { get => _saborsorvete; set => _saborsorvete = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
    }
}
