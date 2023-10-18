using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class MenuClientes : Form
    {
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {

        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Menu e fechando a tela atual
            var telaInicial = new Menu();
            this.Close();
            telaInicial.Show();
        }

        private void botaoAddCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void botaoEditarCliente_Click(object sender, EventArgs e)
        {
            //Abrindo tela de Editar Cliente e escondendo a de Clientes
            var editarCliente = new MenuClientes();
            this.Hide();
            editarCliente.Show();
        }
    }
}
