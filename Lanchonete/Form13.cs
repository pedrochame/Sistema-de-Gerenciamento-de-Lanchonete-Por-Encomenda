using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class AddPedido : Form
    {

        public static List<ItemPedido> listaItensPedido;
        
        public AddPedido(List<ItemPedido> lista)
        {
            listaItensPedido = lista;
            InitializeComponent();
        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Pedidos e fechando a tela atual
            var menuPedidos = new MenuPedidos();
            this.Close();
            menuPedidos.Show();
        }

        private bool registraListaItemPedido(int idPedido)
        {
            foreach (ItemPedido i in listaItensPedido)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaItensPedido.Count == 0)
            {
                //Mostrando a mensagem de erro
                DialogResult msgErro = new DialogResult();
                msgErro = MessageBox.Show("Adicione ao menos item ao pedido.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

            //Adicionando registro da tabela Pedido 
            List<string> campos = new List<string>();

            campos.Add(comboClientes.Text.Split('|')[0].Trim());
            
            double valor_pedido=0;
            foreach (ItemPedido i in listaItensPedido)
            {
                valor_pedido += i.Valor;
            }
            campos.Add(Convert.ToString(valor_pedido).Replace(',','.'));
            campos.Add(Convert.ToString(0));
            campos.Add(Convert.ToString(DateTime.UtcNow));
            campos.Add(Convert.ToString(Program.dataRepresentandoNull));


            if (Program.adicionaRegistro("pedido", campos) == true)
            {
                if(registraListaItemPedido(Program.retornaIdUltimoPedido()) == false){
                    return;
                }

                // Chamando a tela de Pedidos e fechando a tela atual
                var menuPedidos = new MenuPedidos();
                this.Close();
                menuPedidos.Show();
            }
            else
            {
                return;
            }

        }

        private void atualizaValorTotal()
        {
            double v = 0;
            foreach (ItemPedido ip in listaItensPedido)
            {
                v += ip.Valor;
            }
            valorTotal.Text = "R$ " + Convert.ToString(v).Replace(',', '.');
        }

        private void AddPedido_Load(object sender, EventArgs e)
        {
            //Preenchendo o campo de valor total
            valorTotal.Text = "R$ 0.00";


            carregarInfo();


        }

        private void listaItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboClientes.Text.Length >= 5)
            {
                if (comboClientes.Text[2] != '|')
                {
                    //Mostrando a mensagem de erro
                    DialogResult msgErro = new DialogResult();
                    msgErro = MessageBox.Show("Selecione um cliente válido.", "Atenção!", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                //Mostrando a mensagem de erro
                DialogResult msgErro = new DialogResult();
                msgErro = MessageBox.Show("Selecione um cliente válido.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

            //Garantindo que o produto selecionado existe
            if (Program.retornaProdutoPorNome(comboProdutos.Text) == null)
            {
                //Mostrando a mensagem de erro
                DialogResult msgErro = new DialogResult();
                msgErro = MessageBox.Show("Selecione um produto válido.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

            //Garantindo que o cliente selecionado existe
            
            if (Program.existeCliente(comboClientes.Text.Split('|')[1].Trim()) == false)
            {
                //Mostrando a mensagem de erro
                DialogResult msgErro = new DialogResult();
                msgErro = MessageBox.Show("Selecione um cliente válido.", "Atenção!", MessageBoxButtons.OK);
                return;
            }
            

            //Adicionando o produto selecionado à lista de itens do pedido
            string nomeItem = comboProdutos.Text;
            int qtdItem = int.Parse(qtdProduto.Text);
            produto prod = Program.retornaProdutoPorNome(nomeItem);
            double valorItem = qtdItem * prod.Valor;

            ItemPedido i = new ItemPedido(prod,qtdItem,valorItem);
            listaItensPedido.Add(i);
            listaItemPedido.Items.Add(new ListViewItem(new string[] { i.Produto.Nome,Convert.ToString(i.Quantidade),"R$ "+Convert.ToString(i.Valor).Replace(',','.')}));

            //Resetando o campo de produto e quantidade, e congelando o de cliente e adicionar cliente
            comboProdutos.Text = "";
            qtdProduto.Text = "1";
            comboClientes.Enabled = false;
            botaoNovoCliente.Visible = false;

            //Atualizando campo de valor total
            atualizaValorTotal();

            

        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

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
            double itemValor = Double.Parse(item.SubItems[2].Text.Split('$')[1].Trim().Replace('.',','));

            foreach (ItemPedido i in listaItensPedido)
            {
                if (i.Quantidade == itemQt && i.Produto.Nome == itemNome && i.Valor == itemValor)
                {
                    listaItensPedido.Remove(i);
                    
                    break;
                }
            }

            //Atualizando campo de valor total
            atualizaValorTotal();

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

            //Alimentando a ComboBox de Produtos
            foreach (produto p in Program.retornaProdutos())
            {
                comboProdutos.Items.Add(p.Nome);
            }
        }

        private void OnEnabledChanged(object sender, EventArgs e)
        {
            carregarInfo();
        }

        private void botaoNovoCliente_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Adicionar Cliente e fechando a tela atual
            var x = new AdicionarCliente(null, this);
            this.Enabled = false;
            x.Show();
        }

        private void botaoNovoProduto_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Adicionar Produto e fechando a tela atual
            var x = new AdicionarProduto(null, this,null);
            this.Enabled = false;
            x.Show();
        }
    }
}
