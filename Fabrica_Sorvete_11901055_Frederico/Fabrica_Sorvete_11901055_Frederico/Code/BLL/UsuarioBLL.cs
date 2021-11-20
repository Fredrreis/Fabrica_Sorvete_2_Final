using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabrica_Sorvete_11901055_Frederico.Code.DTO;
using Fabrica_Sorvete_11901055_Frederico.Code.DAL;

namespace Fabrica_Sorvete_11901055_Frederico.Code.BLL
{
    class UsuarioBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "usuario";

        public bool RealizarLogin(UsuarioDTO newDto)
        {
            string sql = $"select * from {tabela} where idUsuario = '{newDto.Idusuario}' and email = '{newDto.Emailusuario}' and senha = '{newDto.Senhausuario}';";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }

    
}
