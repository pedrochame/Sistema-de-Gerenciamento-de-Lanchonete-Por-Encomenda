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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void botaoClientes_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Clientes e escondendo a tela atual
            var clientes = new EditarCliente();
            this.Hide();
            clientes.Show();
        }

        private void botaoPedidos_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Pedidos e escondendo a tela atual
            var menuPedidos = new MenuPedidos();
            this.Hide();
            menuPedidos.Show();
        }

        private void botaoSairApp_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Quer mesmo sair?", "Atenção!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void botaoTiposProdutos_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Tipos de Produtos e escondendo a tela atual
            var menuTipos = new MenuTiposProduto();
            this.Hide();
            menuTipos.Show();
        }

        private void botaoProdutos_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Produtos e escondendo a tela atual
            var menuProdutos = new MenuProdutos();
            this.Hide();
            menuProdutos.Show();
        }
    }
}
