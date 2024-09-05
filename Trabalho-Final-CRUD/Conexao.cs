using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Trabalho_Final_CRUD
{
    public static class Conexao
    {
        static MySqlConnection conexao;

        public static MySqlConnection Conectar()
        {
            try
            {
                string strconexao = "server=127.0.0.1;port=3306;uid=root;pwd=root;database=bd_crud";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a conexão com a base de dados!", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            return conexao;
        }

        public static void FecharConexao()
        {
            conexao.Close();
        }
    }
}
