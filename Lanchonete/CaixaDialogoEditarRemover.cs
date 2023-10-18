using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class CaixaDialogoEditarRemover : Form
    {
        int id_registro;
        EditarCliente tela_anterior;
        MenuTiposProduto tela_anterior2;
        MenuProdutos tela_anterior3;
        MenuPedidos tela_anterior4;
        

        public CaixaDialogoEditarRemover(EditarCliente telaAnterior,MenuTiposProduto telaAnterior2, MenuProdutos telaAnterior3, MenuPedidos telaAnterior4,int id)
        {
            id_registro = id;
            tela_anterior = telaAnterior;
            tela_anterior2 = telaAnterior2;
            tela_anterior3 = telaAnterior3;
            tela_anterior4 = telaAnterior4;
            InitializeComponent();
        }

        private void CaixaDialogoEditarRemover_Load(object sender, EventArgs e)
        {
            if (tela_anterior4 != null)
            {
                foreach (Pedido p in Program.retornaPedidos()) {

                    Console.WriteLine("\nId: " + p.Id
                        + " Cliente: " + p.Cliente.Nome);

                    if (p.Id == id_registro)
                    {
                        
                        if (p.Status == 0) {
                            botaoFinalizar.Visible = true;
                            botaoEditar.Visible = true;
                            botaoDetalhes.Visible = true;
                            break;
                        }
                        else
                        {
                            botaoFinalizar.Visible = false;
                            botaoEditar.Visible = false;
                            botaoDetalhes.Visible = true;
                            botaoDetalhes.Location = new Point(93,57);
                            break;
                        }
                    }
                    
                }
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_tabela = "";

            //Tela anterior é de CLIENTE
            if (tela_anterior != null)
            {
                nome_tabela = "cliente";
            }

            //Tela anterior é de TIPO_PRODUTO
            if(tela_anterior2 != null)
            {
                nome_tabela = "tipo_produto";
            }

            //Tela anterior é de PRODUTO
            if (tela_anterior3 != null)
            {
                nome_tabela = "produto";
            }

            //Tela anterior é de PEDIDO
            if (tela_anterior4 != null)
            {
                nome_tabela = "pedido";
            }


            //Se a tabela for de pedidos, primeiro deve-se remover os
            //registros da tabela item_pedidos para o pedido correspondente
            Program.removeItensPedido(id_registro);

            //Removendo o registro da tabela
            Program.removeRegistro(nome_tabela,id_registro);

            if (tela_anterior != null)
            {
                tela_anterior.Enabled = true;
                this.Close();
            }

            if (tela_anterior2 != null)
            {
                tela_anterior2.Enabled = true;
                this.Close();
            }

            if (tela_anterior3 != null)
            {
                tela_anterior3.Enabled = true;
                this.Close();
            }

            if (tela_anterior4 != null)
            {
                tela_anterior4.Enabled = true;
                this.Close();
            }

        }

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            if (tela_anterior != null) {
                var editarCliente2 = new EditarCliente2(tela_anterior,id_registro);
                this.Close();
                tela_anterior.Enabled = false;
                tela_anterior.Activate();
                editarCliente2.Show();
            }

            if (tela_anterior2 != null)
            {
                var editarTipoProduto = new EditarTipoProduto(tela_anterior2,id_registro);
                this.Close();
                tela_anterior2.Enabled = false;
                tela_anterior2.Activate();
                editarTipoProduto.Show();
            }

            if (tela_anterior3 != null)
            {
                var editarProduto = new EditarProduto(tela_anterior3,id_registro);
                this.Close();
                tela_anterior3.Enabled = false;
                tela_anterior3.Activate();
                editarProduto.Show();
            }

            if (tela_anterior4 != null)
            {
                var editarPedido = new EditarPedido(tela_anterior4,Program.retornaPedidoPorId(id_registro));
                this.Close();
                tela_anterior4.Enabled = false;
                tela_anterior4.Activate();
                editarPedido.Show();
                               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tela_anterior != null)
            {
                tela_anterior.Enabled = true;
            }
            if (tela_anterior2 != null)
            {
                tela_anterior2.Enabled = true;
            }
            if (tela_anterior3 != null)
            {
                tela_anterior3.Enabled = true;
            }
            if (tela_anterior4 != null)
            {
                tela_anterior4.Enabled = true;
            }
            this.Close();
        }

        private void botaoFinalizar_Click(object sender, EventArgs e)
        {
            Program.finalizarPedido(id_registro);

            if (tela_anterior4 != null)
            {
                tela_anterior4.Enabled = true;
                this.Close();
            }

        }

        private void botaoDetalhes_Click(object sender, EventArgs e)
        {
            if (tela_anterior4 != null)
            {
                
                var verPedido = new VerPedido(tela_anterior4, Program.retornaPedidoPorId(id_registro));
                tela_anterior4.Enabled = true;
                this.Close();
                verPedido.Show();
                
            }
        }
    }
}
