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
    public partial class AtualizarCliente : Form
    {

        ClienteDAO clienteDAO = new ClienteDAO();

        public AtualizarCliente()
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

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.IdCliente = Convert.ToInt32(txtId.Text);
            cliente.NomeCliente = txtNome.Text;
            cliente.EmailCliente = txtEmail.Text;
            cliente.CpfCliente = txtCpf.Text;
            cliente.TelefoneCliente = txtTelefone.Text;
            cliente.DataNascCliente = Convert.ToDateTime(txtDataNasc.Text);

            clienteDAO.Update(cliente);
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbNomeAlterar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
