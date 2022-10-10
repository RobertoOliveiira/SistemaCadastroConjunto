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
        public MySqlDataReader FetchAll()
        {

            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_PACIENTE, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                return dataReader;
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            // DataSet data = new DataSet();
        }
        public void Delete(Paciente paciente)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE_PACIENTE, conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = paciente.Id;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void Update(Paciente paciente)
        {
            MySqlConnection conn = ConnectionMySQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_PACIENTE, conn);
            cmd.Parameters.Add("@numeroProntuario", MySqlDbType.VarChar, 45).Value = paciente.NrProntuario;
            cmd.Parameters.Add("@pacienterisco", MySqlDbType.VarChar, 45).Value = paciente.PacienteRisco;

            //validação
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = paciente.Id;
            cmd.ExecuteNonQuery();
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
        private const String SQL_SELECT_PACIENTE = @"SELECT * FROM paciente";
        private const String SQL_DELETE_PACIENTE = @"DELETE FROM paciente WHERE id = @id";
        private const String SQL_UPDATE_PACIENTE = @"UPDATE paciente SET
numero_prontuario = @numeroProntuario,
paciente_risco = @pacienterisco
WHERE id = @id";
        #endregion
    }
}
