using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetoAula.SistemaCadastro.Forms.Data
{
    public class EnderecoRepository
    {
      
        public Int32 Save(Endereco endereco)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_ENDERECO, conn);
                cmd.Parameters.Add("@idPessoa", MySqlDbType.Int32).Value = endereco.Pessoa.Id;
                cmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 15).Value = endereco.Pessoa.CGCCPF;
                cmd.Parameters.Add("@rua", MySqlDbType.VarChar, 45).Value = endereco.Pessoa.TipoPessoa;
                cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = endereco.Pessoa.Nome;
                cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 45).Value = endereco.Pessoa.CGCCPF;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 45).Value = endereco.Pessoa.TipoPessoa;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = endereco.Pessoa.Nome;

                cmd.ExecuteNonQuery();
                return (Int32)cmd.LastInsertedId;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLS
        private const String SQL_INSERT_ENDERECO = @"INSERT INTO endereco
(id_pessoa,
CEP,
rua,
numero,
bairro,
cidade,
uf)
VALUES
(@id_pessoa,
@CEP,
@rua,
@numero,
@bairro,
@cidade,
@uf);";
        private const String SQL_SELECT_ENDERECOS = @"SELECT id, CEP, rua, numero, bairro, cidade, uf from endereco";
        #endregion
    }
}