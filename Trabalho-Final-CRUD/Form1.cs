using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Final_CRUD.Formularios;

namespace Trabalho_Final_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarCliente cliente = new CadastrarCliente();
                cliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarCliente cliente = new AtualizarCliente();
                cliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            } 
        }

        private void btListarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ListarCliente cliente = new ListarCliente();
                cliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DeletarCliente cliente = new DeletarCliente();
                cliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
