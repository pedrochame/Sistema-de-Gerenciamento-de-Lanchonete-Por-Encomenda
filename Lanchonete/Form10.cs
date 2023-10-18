using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class AdicionarProduto : Form
    {

        MenuProdutos tela_MenuProdutos;
        AddPedido tela_AddPedido;
        EditarPedido tela_EditarPedido;
        public AdicionarProduto(MenuProdutos t1, AddPedido t2, EditarPedido t3)
        {
            InitializeComponent();
            this.tela_MenuProdutos = t1;
            this.tela_AddPedido = t2;
            this.tela_EditarPedido = t3;
        }

        private void voltarTelaAnterior()
        {
            if (tela_MenuProdutos != null)
            {
                //Chamando a tela de Produtos e fechando a tela atual
                var menuProdutos = new MenuProdutos();
                this.Close();
                menuProdutos.Show();
            }
            if (tela_AddPedido != null)
            {
                //Chamando a tela de Adicionar Pedido e fechando a tela atual
                tela_AddPedido.Enabled = true;
                this.Close();
            }
            if (tela_EditarPedido != null)
            {
                //Chamando a tela de Editar Pedido e fechando a tela atual
                tela_EditarPedido.Enabled = true;
                this.Close();
            }
        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {

            voltarTelaAnterior();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.retornaTipoDeProdutoPorNome(comboTipos.Text) == null)
            {
                //Mostrando a mensagem de erro
                DialogResult msgErro = new DialogResult();
                msgErro = MessageBox.Show("Selecione um tipo válido.", "Atenção!", MessageBoxButtons.OK);
                return;
            }

            //Chamando a função que vai adicionar um novo registro 
            List<string> campos = new List<string>();
            campos.Add(nomeProduto.Text);
            campos.Add(descProduto.Text);
            campos.Add(valorProduto.Text.Replace(',','.'));
            campos.Add(Convert.ToString(Program.retornaTipoDeProdutoPorNome(comboTipos.Text).Id));


            if (Program.adicionaRegistro("produto", campos) == true)
            {
                voltarTelaAnterior();
            }
            else
            {
                return;
            }
        }

        private void AdicionarProduto_Load(object sender, EventArgs e)
        {
            //Alimentando a ComboBox de Tipos de Produto
            List<tipoDeProduto> tipos = Program.retornaTiposProduto();
            foreach (tipoDeProduto t in tipos)
            {
                comboTipos.Items.Add(t.Nome);
            }
            
            
        }

        private void valorProduto_TextChanged(object sender, EventArgs e)
        {
            string x = valorProduto.Text.Replace(',','.');
            if (x.IndexOf('.') != x.LastIndexOf('.'))
            {
                valorProduto.Text = valorProduto.Text.Remove(valorProduto.Text.Length-1);
                return;
            }
            for (int i=0;i<x.Length;i++)
            {
                List<char> numeros = new List<char> {'0','1','2','3','4','5','6','7','8','9' };

                if (numeros.IndexOf(x[i]) == -1 && i!=x.IndexOf('.'))
                {
                    valorProduto.Text = valorProduto.Text.Remove(valorProduto.Text.Length - 1);
                    return;
                }
            }
        }

        private void comboTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void botaoNovoTipo_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Adicionar Tipo de Produto e fechando a tela atual
            var addTipo = new AddTipoProduto(null,this,null);
            this.Enabled = false;
            addTipo.Show();
        }

       
        private void OnEnabledChanged(object sender, EventArgs e)
        {
            //Alimentando a ComboBox de Tipos de Produto
            List<tipoDeProduto> tipos = Program.retornaTiposProduto();
            comboTipos.Items.Clear();
            foreach (tipoDeProduto t in tipos)
            {
                comboTipos.Items.Add(t.Nome);
            }
            
        }

    }
}
