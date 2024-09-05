using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Final_CRUD.Modulos;
using Trabalho_Final_CRUD.Modulos.DAO;

namespace Trabalho_Final_CRUD.Formularios
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO clienteDAO = new ClienteDAO();
                Cliente c = new Cliente();

                c.NomeCliente = txtNome.Text;
                c.EmailCliente = txtEmail.Text;
                c.CpfCliente = txtCpf.Text;
                c.TelefoneCliente = txtTelefone.Text;
                c.DataNascCliente = Convert.ToDateTime(txtDataNasc.Text);

                clienteDAO.Insert(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro forá de SQL", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
