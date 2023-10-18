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
    public partial class EditarProduto : Form
    {

        int idProduto;
        MenuProdutos tela_anterior;
        public EditarProduto(MenuProdutos tela,int id_produto)
        {
            idProduto = id_produto;
            tela_anterior = tela;
            InitializeComponent();
            
        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Produtos e fechando a tela atual
            this.Close();
            tela_anterior.Enabled = true;
            tela_anterior.Activate();
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


            //Chamando a função que vai editar o registro 
            List<string> campos = new List<string>();
            campos.Add(nomeProduto.Text);
            campos.Add(descProduto.Text);
            campos.Add(valorProduto.Text.Replace(',','.'));
            campos.Add(Convert.ToString(Program.retornaTipoDeProdutoPorNome(comboTipos.Text).Id));


            if (Program.editaRegistro("produto", idProduto,campos) == true)
            {
                // Chamando a tela de Produtos e fechando a tela atual
                botaoVoltarMenu_Click(sender, e);
            }
            else
            {
                return;
            }
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            //Alimentando a ComboBox de tipos de produto
            List<tipoDeProduto> tipos = Program.retornaTiposProduto();
            foreach (tipoDeProduto t in tipos)
            {
                    comboTipos.Items.Add(t.Nome);
            }


            //Preenchendo os campos com os dados do produto a ser editado
            produto p = Program.retornaProduto(idProduto);
            nomeProduto.Text = p.Nome;
            descProduto.Text = p.Descricao;
            valorProduto.Text = Convert.ToString(p.Valor).Replace(',','.');
            comboTipos.Text = p.TipoDeProduto.Nome;
            
        }

        private void valorProduto_TextChanged(object sender, EventArgs e)
        {
            string x = valorProduto.Text.Replace(',', '.');
            if (x.IndexOf('.') != x.LastIndexOf('.'))
            {
                valorProduto.Text = valorProduto.Text.Remove(valorProduto.Text.Length - 1);
                return;
            }
            for (int i = 0; i < x.Length; i++)
            {
                List<char> numeros = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                if (numeros.IndexOf(x[i]) == -1 && i != x.IndexOf('.'))
                {
                    valorProduto.Text = valorProduto.Text.Remove(valorProduto.Text.Length - 1);
                    return;
                }
            }
        }

        private void botaoNovoTipo_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Adicionar Tipo de Produto e fechando a tela atual
            var addTipo = new AddTipoProduto(null, null, this);
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
