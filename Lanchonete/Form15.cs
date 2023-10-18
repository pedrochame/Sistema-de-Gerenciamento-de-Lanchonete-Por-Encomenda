using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class VerPedido : Form
    {
        MenuPedidos tela_anterior;
        Pedido pedido;

        public VerPedido(MenuPedidos t, Pedido p)
        {
            tela_anterior = t;
            pedido = p;
            InitializeComponent();
        }

        private void VerPedido_Load(object sender, EventArgs e)
        {
            //Congelando a tela de Menu de Pedidos
            tela_anterior.Enabled = false;

            //Preenchendo dados do Cliente do Pedido
            clienteNome.Text = pedido.Cliente.Nome;
            clienteEstado.Text = pedido.Cliente.Estado;
            clienteCidade.Text = pedido.Cliente.Cidade;
            clienteBairro.Text = pedido.Cliente.Bairro;
            clienteEndereco.Text = pedido.Cliente.Endereco;
            clienteTel.Text = pedido.Cliente.Telefone;
            clienteEmail.Text = pedido.Cliente.Email;

            //Preenchendo dados do Pedido
            foreach (ItemPedido ip in Program.retornaItemPedidoPorIdPedido(pedido.Id))
            {
                listaItemPedido.Items.Add(new ListViewItem(new string[] { ip.Produto.Nome, Convert.ToString(ip.Quantidade), "R$ " + Convert.ToString(ip.Valor).Replace(',', '.') }));
            }

            dtCriacaoPedido.Text = Convert.ToString(pedido.Data_Criacao.ToLocalTime());
            
            if (pedido.Data_Entrega != Program.dataRepresentandoNull) {
                dtEntregaPedido.Text = Convert.ToString(pedido.Data_Entrega.ToLocalTime());
            }
            
            valorPedido.Text = "R$ " + Convert.ToString(pedido.Valor).Replace(',','.');

            if (pedido.Status == 1) {
                statusPedido.Text = "Finalizado";
                botaoFinalizar.Visible = false;
            }
            else
            {
                statusPedido.Text = "Aberto";
                botaoFinalizar.Visible = true;
            }

        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {

            tela_anterior.Enabled = true;
            tela_anterior.Activate();
            this.Close();
        }

        private void botaoFinalizar_Click(object sender, EventArgs e)
        {
            Program.finalizarPedido(pedido.Id);
            pedido = Program.retornaPedidoPorId(pedido.Id);
            dtEntregaPedido.Text = Convert.ToString(pedido.Data_Entrega.ToLocalTime());
            statusPedido.Text = "Finalizado";
            botaoFinalizar.Visible = false;
        }
    }
}
