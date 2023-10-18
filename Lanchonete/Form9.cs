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
    public partial class MenuProdutos : Form
    {
        public MenuProdutos()
        {
            InitializeComponent();
        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Menu e fechando a tela atual
            var telaInicial = new Menu();
            this.Close();
            telaInicial.Show();
        }

        private void MenuProdutos_Load(object sender, EventArgs e)
        {
            carregaInfo(null,null,null,null,null,null);
        }

        private void OnEnabledChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listaProdutos.Items)
            {
                if (!Program.verificaSeExiste("produto", int.Parse(i.SubItems[0].Text)))
                {
                    listaProdutos.Items.Remove(i);
                    Console.WriteLine(i.SubItems[0].Text);
                }
                else
                {
                    produto prod = Program.retornaProduto(int.Parse(i.SubItems[0].Text));
                    //Atualizando Nome
                    i.SubItems[1].Text = prod.Nome;
                    //Atualizando Descrição
                    i.SubItems[2].Text = prod.Descricao;
                    //Atualizando Valor
                    i.SubItems[3].Text = "R$ " + Convert.ToString(prod.Valor).Replace(',','.');
                    //Atuliazando Tipo
                    i.SubItems[4].Text = prod.TipoDeProduto.Nome;
                }
            }
        }

        private void carregaInfo(List<produto> lista, string nome, string desc, string valor1, string valor2, tipoDeProduto tipo)
        {
            listaProdutos.Items.Clear();
            List<produto> produtos;

            if (lista == null)
            {
                produtos = Program.retornaProdutos();
            }
            else
            {
                produtos = lista;
            }

            foreach (produto p in produtos)
            {
                listaProdutos.Items.Add(new ListViewItem(new string[] { Convert.ToString(p.Id), p.Nome, p.Descricao, "R$ " + Convert.ToString(p.Valor).Replace(',', '.'), p.TipoDeProduto.Nome }));
            }

            if (nome != null)
            {
                nomeProduto.Text = nome;
            }
            if (desc != null)
            {
                descProduto.Text = desc;
            }
            if (valor1 != null)
            {
                valorMaiorQue.Text = valor1;
            }
            if (valor2 != null)
            {
                valorMenorQue.Text = valor2;
            }
            if (tipo != null)
            {
                comboTipos.Text = tipo.Nome;
            }

            //Alimentando a ComboBox de Tipos de Produto
            comboTipos.Items.Clear();
            List<tipoDeProduto> tipos = Program.retornaTiposProduto();
            foreach (tipoDeProduto t in tipos)
            {
                comboTipos.Items.Add(t.Nome);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrindo tela de Adicionar Produto e escondendo a de Produtos
            var addProduto = new AdicionarProduto(this,null,null);
            this.Hide();
            addProduto.Show();
        }

        private void listaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaProdutos.SelectedItems.Count == 0)
            {
                return;
            }

            string idProduto = listaProdutos.SelectedItems[0].Text;



            // Chamando a tela de Escolher Editar/Remover e deixando a tela atual em stand-by
            var caixaDialogoEditarRemover = new CaixaDialogoEditarRemover(null, null, this,null,int.Parse(idProduto));
            this.Enabled = false;
            caixaDialogoEditarRemover.Show();
        }

        private void botaoFiltrar_Click(object sender, EventArgs e)
        {
            //Chamando a função que vai pesquisar os registros 
            string np = nomeProduto.Text;
            string desc = descProduto.Text;
            string v1="0", v2="99999999999";
            if (valorMaiorQue.Text.Trim() != "") {
                v1 = valorMaiorQue.Text.Trim().Replace(',','.');
            }
            if (valorMenorQue.Text.Trim() != "") {
                v2 = valorMenorQue.Text.Trim().Replace(',','.');
            }
            tipoDeProduto t = Program.retornaTipoDeProdutoPorNome(comboTipos.Text);
            int idT;
            if (t != null) { 
                idT = t.Id;
            }
            else
            {
                idT = 0;
            }
            carregaInfo(Program.pesquisaProduto(np,desc,v1,v2,idT),nomeProduto.Text,descProduto.Text,valorMaiorQue.Text,valorMenorQue.Text,t);
        }

        private void valorMaiorQue_TextChanged(object sender, EventArgs e)
        {
            string x = valorMaiorQue.Text.Replace(',', '.');
            if (x.IndexOf('.') != x.LastIndexOf('.'))
            {
                valorMaiorQue.Text = valorMaiorQue.Text.Remove(valorMaiorQue.Text.Length - 1);
                return;
            }
            for (int i = 0; i < x.Length; i++)
            {
                List<char> numeros = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                if (numeros.IndexOf(x[i]) == -1 && i != x.IndexOf('.'))
                {
                    valorMaiorQue.Text = valorMaiorQue.Text.Remove(valorMaiorQue.Text.Length - 1);
                    return;
                }
            }
        }

        private void valorMenorQue_TextChanged(object sender, EventArgs e)
        {
            string x = valorMenorQue.Text.Replace(',', '.');
            if (x.IndexOf('.') != x.LastIndexOf('.'))
            {
                valorMenorQue.Text = valorMenorQue.Text.Remove(valorMenorQue.Text.Length - 1);
                return;
            }
            for (int i = 0; i < x.Length; i++)
            {
                List<char> numeros = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                if (numeros.IndexOf(x[i]) == -1 && i != x.IndexOf('.'))
                {
                    valorMenorQue.Text = valorMenorQue.Text.Remove(valorMenorQue.Text.Length - 1);
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carregaInfo(null, "", "","","",null);
            comboTipos.Text = null;
        }

        private void exportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            string nome = Program.Exportar("produto", listaProdutos);

            if ( nome != "")
            {
                dialog = MessageBox.Show($"Arquivo de Excel criado.\nCaminho: {nome}.xlsx", "Sucesso!", MessageBoxButtons.OK);
            }
            else
            {
                dialog = MessageBox.Show("Falha na criação do arquivo de Excel.", "Erro!", MessageBoxButtons.OK);
            }
        }
    }
}
