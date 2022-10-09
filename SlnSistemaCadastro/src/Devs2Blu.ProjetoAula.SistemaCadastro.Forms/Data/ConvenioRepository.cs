using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetoAula.SistemaCadastro.Forms.Data
{
    public class ConvenioRepository
    {

        public MySqlDataReader FetchAll()
        {

            MySqlConnection conn = ConnectionMySQL.GetConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT_CONVENIO, conn);
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
        public void Save(Convenio convenio)
        {
            try
            {
                MySqlConnection conn = ConnectionMySQL.GetConnection();
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT_CONVENIO, conn);
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 45).Value = convenio.Nome;

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException myExc)
            {
                MessageBox.Show(myExc.Message, "Erro de MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        #region SQLS
        private const String SQL_SELECT_CONVENIO = "SELECT * FROM convenio";

        private const String SQL_INSERT_CONVENIO = @"INSERT INTO convenio
(nome,
flstatus)
VALUES
(@nome,
'A')";
        private const String SQL_DELETE_CONVENIO = @"DELETE FROM convenio WHERE @id ";

        #endregion

    }
}
