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
    class SorvetesBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "sorvetes";
        public void Inserir(SorvetesDTO newDto) 
        {
            string inserir = $"insert into {tabela} values('{newDto.Id}', '{newDto.Tipo}', '{newDto.Sabor}', '{newDto.Preco}');";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select distinct(*) from {tabela} order by idSorvete;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(SorvetesDTO newDto)
        {
            string alterar = $"update {tabela} set tipo = '{newDto.Tipo}', sabor = '{newDto.Sabor}', preco = '{newDto.Preco}' where idSorvete = '{newDto.Id}';";
            conexao.ExecutarComando(alterar);
        }
        public void Excluir(SorvetesDTO newDto)
        {
            string excluir = $"delete from {tabela} where idSorvete = '{newDto.Id}';";
            conexao.ExecutarConsulta(excluir);
        }

        

    }
}
