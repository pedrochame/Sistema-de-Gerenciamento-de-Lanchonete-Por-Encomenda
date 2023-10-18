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
    public partial class EditarPedido : Form
    {
        Pedido pedido;
        MenuPedidos telaAnterior;
        public EditarPedido(MenuPedidos tela,Pedido p)
        {
            pedido = p;
            telaAnterior = tela;
            InitializeComponent();
        }

        private void atualizaValorTotal()
        {
            double v = 0;
            foreach (ItemPedido ip in pedido.ItensPedido)
            {
                v += ip.Valor;
            }
            valorTotal.Text = "R$ " + Convert.ToString(v).Replace(',', '.');
        }

        private bool registraListaItemPedido(int idPedido)
        {
            if (Program.removeItensPedido(idPedido) == false)
            {
                return false;
            }

            foreach (ItemPedido i in pedido.ItensPedido)
            {
                List<string> campos = new List<string>();
                campos.Add(Convert.ToString(idPedido));
                campos.Add(Convert.ToString(i.Produto.Id));
                campos.Add(Convert.ToString(i.Quantidade));
                campos.Add(Convert.ToString(i.Valor).Replace(',', '.'));

                if (Program.adicionaRegistro("item_pedido", campos) == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void OnEnabledChanged(object sender, EventArgs e)
        {
            carregarInfo();
        }

        private void carregarInfo()
        {
            comboClientes.Items.Clear();
            comboProdutos.Items.Clear();

            //Alimentando a ComboBox de Clientes
            foreach (Cliente c in Program.retornaClientes())
            {
                comboClientes.Items.Add(c.Id + " | " + c.Nome);
            }
            comboClientes.Text = pedido.Cliente.Id + " | " + pedido.Cliente.Nome;

            //Alimentando a ComboBox de Produtos
            foreach (produto p in Program.retornaProdutos())
            {
                comboProdutos.Items.Add(p.Nome);
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            //Preenchendo o campo de valor total
            double valorPedido = 0;
            foreach (ItemPedido item in pedido.ItensPedido)
            {
                valorPedido += item.Valor;
            }
            valorTotal.Text = "R$ " + Convert.ToString(valorPedido).Replace(',','.');


            carregarInfo();

            //Adicionando o produtos da lista do pedido atual ao DataGrid
            foreach(ItemPedido item in pedido.ItensPedido)
            {
                listaItemPedido.Items.Add(new ListViewItem(new string[] { item.Produto.Nome, Convert.ToString(item.Quantidade), "R$ " + Convert.ToString(item.Valor).Replace(',', '.') }));
            }

        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Pedidos e fechando a tela atual
            this.Close();
            telaAnterior.Enabled = true;
            telaAnterior.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //Garantindo que o produto selecionado existe
            if (Program.retornaProdutoPorNome(comboProdutos.Text) == null)
            {
                //Mostrando a mensagem de erro
                DialogResult msgErro = new DialogResult();
                msgErro = MessageBox.Show("Selecione um produto válido.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

            //Adicionando o produto selecionado à lista de itens do pedido
            string nomeItem = comboProdutos.Text;
            int qtdItem = int.Parse(qtdProduto.Text);
            produto prod = Program.retornaProdutoPorNome(nomeItem);
            double valorItem = qtdItem * prod.Valor;

            ItemPedido i = new ItemPedido(prod, qtdItem, valorItem);
            pedido.ItensPedido.Add(i);
            listaItemPedido.Items.Add(new ListViewItem(new string[] { i.Produto.Nome, Convert.ToString(i.Quantidade), "R$ " + Convert.ToString(i.Valor).Replace(',', '.') }));

            //Resetando o campo de produto e quantidade
            comboProdutos.Text = "";
            qtdProduto.Text = "1";

            //Atualizando campo de valor total
            atualizaValorTotal();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pedido.ItensPedido.Count == 0)
            {
                //Mostrando a mensagem de erro
                DialogResult msgErro = new DialogResult();
                msgErro = MessageBox.Show("Adicione ao menos item ao pedido.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

            //Adicionando registro da tabela Pedido 
            List<string> campos = new List<string>();

            campos.Add(Convert.ToString(pedido.Cliente.Id));

            double valor_pedido = 0;
            foreach (ItemPedido i in pedido.ItensPedido)
            {
                valor_pedido += i.Valor;
            }

            campos.Add(Convert.ToString(valor_pedido).Replace(',', '.'));
            campos.Add(Convert.ToString(pedido.Status));
            campos.Add(Convert.ToString(pedido.Data_Criacao));
            campos.Add(Convert.ToString(pedido.Data_Entrega));


            if (Program.editaRegistro("pedido", pedido.Id,campos) == true)
            {
                if (registraListaItemPedido(pedido.Id) == false)
                {
                    return;
                }

                // Chamando a tela de Pedidos e fechando a tela atual
                botaoVoltarMenu_Click(sender, e);
            }
            else
            {
                return;
            }


        }

        private void listaItemPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaItemPedido.SelectedItems.Count == 0)
            {
                return;
            }

            //Item selecionado do DataGrid
            ListViewItem item = listaItemPedido.SelectedItems[0];

            //Deletando o item do DataGrid
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja excluir o item?", "Atenção!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                listaItemPedido.Items.Remove(item);
            }
            else
            {
                return;
            }

            //Deletando o ItemPedido correspondente na lista de itens de pedido

            int itemQt = int.Parse(item.SubItems[1].Text);
            string itemNome = item.SubItems[0].Text;
            double itemValor = Double.Parse(item.SubItems[2].Text.Split('$')[1].Trim().Replace('.', ','));

            foreach (ItemPedido i in pedido.ItensPedido)
            {
                if (i.Quantidade == itemQt && i.Produto.Nome == itemNome && i.Valor == itemValor)
                {
                    pedido.ItensPedido.Remove(i);
                    break;
                }
            }

            //Atualizando campo de valor total
            atualizaValorTotal();
        }

        private void botaoNovoProduto_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Adicionar Produto e fechando a tela atual
            var x = new AdicionarProduto(null, null, this);
            this.Enabled = false;
            x.Show();
        }

        private void valorTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
