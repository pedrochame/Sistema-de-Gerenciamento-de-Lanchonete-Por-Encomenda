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
    public partial class AddTipoProduto : Form
    {

        MenuTiposProduto tela_MenuTiposProduto;
        AdicionarProduto tela_AdicionarProduto;
        EditarProduto tela_EditarProduto;

        public AddTipoProduto(MenuTiposProduto telaAnterior, AdicionarProduto telaAnterior2, EditarProduto telaAnterior3)
        {
            tela_MenuTiposProduto = telaAnterior;
            tela_AdicionarProduto = telaAnterior2;
            tela_EditarProduto = telaAnterior3;

            InitializeComponent();
        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            if (tela_MenuTiposProduto != null) {
                //Chamando a tela de Menu de Tipos de Produto e fechando a tela atual
                var x = new MenuTiposProduto();
                this.Close();
                x.Show();
            }
            if (tela_AdicionarProduto != null)
            {
                // Chamando a tela de Adicionar Produto e fechando a tela atual
                tela_AdicionarProduto.Enabled = true;
                this.Close();
            }
            if (tela_EditarProduto != null)
            {
                // Chamando a tela de Editar Produto e fechando a tela atual
                tela_EditarProduto.Enabled = true;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Chamando a função que vai adicionar um novo registro 
            List<string> campos = new List<string>();
            campos.Add(tipoProdutoNome.Text);

            if (Program.adicionaRegistro("tipo_produto", campos) == true)
            {
                if (tela_AdicionarProduto != null)
                {
                    // Chamando a tela de Adicionar Produto e fechando a tela atual
                    tela_AdicionarProduto.Enabled = true;
                    this.Close();
                }
                if (tela_EditarProduto != null)
                {
                    // Chamando a tela de Editar Produto e fechando a tela atual
                    tela_EditarProduto.Enabled = true;
                    this.Close();
                }
                if (tela_MenuTiposProduto != null)
                {
                    // Chamando a tela de Menu Tipos de Produto e fechando a tela atual
                    botaoVoltarMenu_Click(sender, e);
                }
            }
            else
            {
                return;
            }

        }

        private void AddTipoProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
