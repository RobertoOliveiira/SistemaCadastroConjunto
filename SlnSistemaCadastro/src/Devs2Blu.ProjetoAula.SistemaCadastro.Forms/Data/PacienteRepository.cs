using Devs2Blu.ProjetoAula.SistemaCadastro.Forms.Data;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Forms.Data
{
    public class PacienteRepository
    {
        public Paciente Save(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_PACIENTE, conn);
                cmd.Parameters.Add("@id_pessoa", MySqlDbType.Int32).Value = paciente.Pessoa.Id;
                cmd.Parameters.Add("@id_convenio", MySqlDbType.Int32).Value = paciente.Convenio.Id;
                cmd.Parameters.Add("@numero_prontuario", MySqlDbType.Enum).Value = paciente.Pessoa.TipoPessoa;

                cmd.ExecuteNonQuery();
                return paciente;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLS
        private const String SQL_INSERT_PACIENTE = @"INSERT INTO paciente
(id_pessoa,
id_convenio,
numero_prontuario,
paciente_risco,
flstatus,
flobito)
VALUES
(@id_pessoa,
@id_convenio,
@numero_prontuario,
@paciente_risco,
'A',
0)";
        private const String SQL_SELECT_PESSOAS = @"SELECT id_pessoa, id_convenio, numero_prontuario, paciente_risco from pessoa";
        #endregion
    }
}
