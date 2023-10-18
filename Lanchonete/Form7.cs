using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class MenuTiposProduto : Form
    {

        

        public MenuTiposProduto()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrindo tela de Adicionar Tipo de Produto e escondendo a de Tipos de Produto
            var addTipoProduto = new AddTipoProduto(this,null,null);
            this.Close();
            addTipoProduto.Show();
        }

        private void listaTiposProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listaTiposProduto.SelectedItems.Count == 0)
            {
                return;
            }

            string idTipoProduto = listaTiposProduto.SelectedItems[0].Text;

            // Chamando a tela de Escolher Editar/Remover e deixando a tela atual em stand-by
            var caixaDialogoEditarRemover = new CaixaDialogoEditarRemover(null,this, null,null,int.Parse(idTipoProduto));
            this.Enabled = false;
            caixaDialogoEditarRemover.Show();





        }

        private void MenuTiposProduto_Load(object sender, EventArgs e)
        {
            carregaInfo(null,null);
        }

        private void OnEnabledChanged(object sender, EventArgs e)
        {

            foreach(ListViewItem i in listaTiposProduto.Items){
                if (!Program.verificaSeExiste("tipo_produto", int.Parse(i.SubItems[0].Text)))
                {
                    listaTiposProduto.Items.Remove(i);
                    Console.WriteLine(i.SubItems[0].Text);
                }
                else
                {
                    tipoDeProduto tipo = Program.retornaTipoDeProdutoPorId(int.Parse(i.SubItems[0].Text));
                    //Atualizando Nome
                    i.SubItems[1].Text = tipo.Nome;
                }
            }
            
        }

        private void carregaInfo(List<tipoDeProduto> lista,string n)
        {
            listaTiposProduto.Items.Clear();
            List<tipoDeProduto> tiposProduto;

            if (lista==null) {
                tiposProduto = Program.retornaTiposProduto();
            }
            else
            {
                tiposProduto = lista;
            }

            foreach (tipoDeProduto t in tiposProduto)
            {
                listaTiposProduto.Items.Add(new ListViewItem(new string[] { Convert.ToString(t.Id), t.Nome }));
            }

            if(n != null)
            {
                nome.Text = n;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Chamando a função que vai pesquisar os registros 
            carregaInfo(Program.pesquisaTipoProduto(nome.Text) , nome.Text);
        
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            carregaInfo(null, "");
        }

        private void exportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            string nome = Program.Exportar("tipo_produto", listaTiposProduto);

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
