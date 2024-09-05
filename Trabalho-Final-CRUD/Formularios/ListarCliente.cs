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
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            foreach (Cliente a in clienteDAO.List())
            {
                dataGridView1.Rows.Add(a.IdCliente, a.NomeCliente, a.CpfCliente, a.EmailCliente, a.TelefoneCliente, a.DataNascCliente);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
