using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_Sorvete_11901055_Frederico.Code.DTO
{
    class UsuarioDTO
    {
        private int _idusuario;
        private string _emailusuario;
        private string _senhausuario;

        public int Idusuario { get => _idusuario; set => _idusuario = value; }
        public string Emailusuario { get => _emailusuario; set => _emailusuario = value; }
        public string Senhausuario { get => _senhausuario; set => _senhausuario = value; }
    }
}
