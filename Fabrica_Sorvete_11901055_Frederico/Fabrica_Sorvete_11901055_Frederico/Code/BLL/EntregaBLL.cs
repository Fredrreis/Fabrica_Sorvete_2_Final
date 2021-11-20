using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fabrica_Sorvete_11901055_Frederico.Code.DTO;
using Fabrica_Sorvete_11901055_Frederico.Code.DAL;
using System.Data;

namespace Fabrica_Sorvete_11901055_Frederico.Code.BLL
{
    class EntregaBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "pedido";
        public void Inserir(EntregaDTO newDto)
        {
            string inserir = $"insert into {tabela} values('{newDto.Identrega}', '{newDto.Endereco}', '{newDto.Numtelefone}', '{newDto.Cep}', '{newDto.Tiposorvete}', '{newDto.Saborsorvete}', '{newDto.Quantidade}');";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by idEntrega;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(EntregaDTO newDto)
        {
            string alterar = $"update {tabela} endereco = '{newDto.Endereco}', numTelefone = '{newDto.Numtelefone}', CEP = '{newDto.Cep}', tipoSorvete = '{newDto.Tiposorvete}', saborSorvete = '{newDto.Saborsorvete}', quantidade = '{newDto.Quantidade}' where idEntrega = '{newDto.Identrega}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(EntregaDTO newDto)
        {
            string excluir = $"delete from {tabela} where idEntrega = '{newDto.Identrega}';";
            conexao.ExecutarConsulta(excluir);
        }
    }
}
