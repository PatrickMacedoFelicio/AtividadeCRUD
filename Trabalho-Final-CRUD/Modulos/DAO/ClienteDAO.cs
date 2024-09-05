using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final_CRUD.Modulos.DAO
{
    public class ClienteDAO
    {
        public void Insert(Cliente cliente)
        {
            try
            {
                string dataNascimento = cliente.DataNascCliente.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO Cliente(nome_cli, cpf_cli, email_cli, telefone_cli, dataNasc_cli) VALUES(@nome, @cpf, @email, @telefone, @dataNascimento)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", cliente.NomeCliente);
                comando.Parameters.AddWithValue("@cpf", cliente.CpfCliente);
                comando.Parameters.AddWithValue("@email", cliente.EmailCliente);
                comando.Parameters.AddWithValue("@telefone", cliente.TelefoneCliente);
                comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado!", "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o INSERT\n"+ex.Message, "INSERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public void Delete(Cliente cliente)
        {
            try
            {
                string sql = "DELETE FROM Cliente WHERE id_cli = @id_cli";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_cli", cliente.IdCliente);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente deletado!", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o DELETE\n" + ex.Message, "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public void Update(Cliente cliente)
        {
            try
            {
                string dataNascimento = cliente.DataNascCliente.ToString("yyyy-MM-dd");
                string sql = "UPDATE Cliente SET nome_cli = @nome, cpf_cli = @cpf, email_cli = @email, telefone_cli = @telefone, dataNasc_cli = @dataNascimento WHERE id_cli = @id_cli";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", cliente.NomeCliente);
                comando.Parameters.AddWithValue("@cpf", cliente.CpfCliente);
                comando.Parameters.AddWithValue("@email", cliente.EmailCliente);
                comando.Parameters.AddWithValue("@telefone", cliente.TelefoneCliente);
                comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                comando.Parameters.AddWithValue("@id_cli", cliente.IdCliente);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente atualizado!", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar o UPDATE\n" + ex.Message, "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public List<Cliente> List()
        {
            List<Cliente> ListCliete = new List<Cliente>();

            try
            {
                var sql = "SELECT * FROM Cliente";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.IdCliente = dr.GetInt32("id_cli");
                        cliente.NomeCliente = dr.GetString("nome_cli");
                        cliente.CpfCliente = dr.GetString("cpf_cli");
                        cliente.EmailCliente = dr.GetString("email_cli");
                        cliente.TelefoneCliente = dr.GetString("telefone_cli");
                        cliente.DataNascCliente = dr.GetDateTime("dataNasc_cli");
                        ListCliete.Add(cliente);
                    }
                }
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar ao LISTAR\n" + ex.Message, "LIST", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
            return ListCliete;
        }
    }
}
