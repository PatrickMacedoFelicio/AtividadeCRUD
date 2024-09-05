using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Final_CRUD.Modulos.DAO;
using Trabalho_Final_CRUD.Modulos;

namespace Trabalho_Final_CRUD.Formularios
{
    public partial class DeletarCliente : Form
    {

        ClienteDAO clienteDAO = new ClienteDAO();

        public DeletarCliente()
        {
            InitializeComponent();
            carregarCB();
        }

        private void carregarCB()
        {
            foreach (Cliente cli in clienteDAO.List())
            {
                cbNomeAlterar.Items.Add(cli.NomeCliente);
            }

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            foreach (Cliente cli in clienteDAO.List())
            {
                if (cbNomeAlterar.Text == cli.NomeCliente)
                {
                    txtId.Text = cli.IdCliente.ToString();
                    txtNome.Text = cli.NomeCliente;
                    txtCpf.Text = cli.CpfCliente;
                    txtEmail.Text = cli.EmailCliente;
                    txtTelefone.Text = cli.TelefoneCliente;
                    txtDataNasc.Text = cli.DataNascCliente.ToString();
                }
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            DialogResult esc = MessageBox.Show("Deseja realmente DELETAR o cliente?", "Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (esc == DialogResult.Yes)
            {
                Cliente c = new Cliente();
                c.IdCliente = Convert.ToInt32(txtId.Text);

                clienteDAO.Delete(c);

                txtId.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtDataNasc.Clear();
                txtNome.Clear();
                txtTelefone.Clear();
            }
        }
    }
}
