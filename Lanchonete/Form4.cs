using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lanchonete
{
    public partial class EditarCliente : Form
    {

        
        
        public EditarCliente()
        {
            InitializeComponent();

        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Menu e fechando a tela atual
            var telaInicial = new Menu();
            this.Close();
            telaInicial.Show();
        }

        private void carregaInfo(List<Cliente> lista, string n, string e, string c, string b)
        {

            listaClientesEditar.Items.Clear();
            List<Cliente> clientes;

            if (lista == null)
            {
                clientes = Program.retornaClientes();
            }
            else
            {
                clientes = lista;
            }

            if (n != null)
            {
                clienteNome.Text = n;
            }
            if (e != null)
            {
                comboEstados.Text = e;
            }
            if (c != null)
            {
                comboCidades.Text = c;
            }
            if (b != null)
            {
                clienteBairro.Text = b;
            }

            foreach (Cliente cl in clientes)
            {
                string es = cl.Estado;
                foreach (Municipio m in Program.municipios)
                {
                    UF estado = m.Microrregiao.Mesorregiao.Uf;
                    if (es == estado.Nome)
                    {
                        es = estado.Sigla;
                    }
                }

                listaClientesEditar.Items.Add(
                    new ListViewItem(new string[] { Convert.ToString(cl.Id), cl.Nome, es, cl.Cidade, cl.Bairro, cl.Endereco, cl.Telefone, cl.Email })
                );
            }
        }

        private void OnEnabledChanged(object sender, EventArgs e) {

            foreach (ListViewItem i in listaClientesEditar.Items)
            {
                if (!Program.verificaSeExiste("cliente", int.Parse(i.SubItems[0].Text)))
                {
                    listaClientesEditar.Items.Remove(i);
                    Console.WriteLine(i.SubItems[0].Text);
                }
                else
                {

                    Cliente cliente = Program.retornaClientePorId(int.Parse(i.SubItems[0].Text));
                    //Atualizando Nome
                    i.SubItems[1].Text = cliente.Nome;
                    //Atualizando Estado
                    string es = cliente.Estado;
                    foreach (Municipio m in Program.municipios)
                    {
                        UF estado = m.Microrregiao.Mesorregiao.Uf;
                        if (es == estado.Nome)
                        {
                            es = estado.Sigla;
                        }
                    }
                    i.SubItems[2].Text = es;
                    //Atualizando Cidade
                    i.SubItems[3].Text = cliente.Cidade;
                    //Atualizando Bairro
                    i.SubItems[4].Text = cliente.Bairro;
                    //Atualizando Endereço
                    i.SubItems[5].Text = cliente.Endereco;
                    //Atualizando Telefone
                    i.SubItems[6].Text = cliente.Telefone;
                    //Atualizando Email
                    i.SubItems[7].Text = cliente.Email;
                }
            }

        }

        

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            carregaInfo(null,null,null,null,null);

            //Alimentando a ComboBox de estados
            foreach (Municipio m in Program.municipios)
            {
                string estado = m.Microrregiao.Mesorregiao.Uf.Nome;
                if (!comboEstados.Items.Contains(estado))
                {
                    comboEstados.Items.Add(estado);
                }

            }

        }

        private void listaClientesEditar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaClientesEditar.SelectedItems.Count==0)
            {
                return;
            }

            string idCliente = listaClientesEditar.SelectedItems[0].Text;

            

            // Chamando a tela de Escolher Editar/Remover e deixando a tela atual em stand-by
            var caixaDialogoEditarRemover = new CaixaDialogoEditarRemover(this,null,null,null,int.Parse(idCliente));
            this.Enabled = false;
            caixaDialogoEditarRemover.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrindo tela de Adicionar Cliente e escondendo a de Clientes
            var addCliente = new AdicionarCliente(this,null);
            this.Hide();
            addCliente.Show();
        }

        private void comboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCidades.Enabled = true;
            comboCidades.Text = "";
            comboCidades.Items.Clear();

            clienteBairro.Items.Clear();
            clienteBairro.Text = "";

            //Alimentando a ComboBox de cidades de acordo com o estado selecionado

            foreach (Municipio m in Program.municipios)
            {
                string estado = m.Microrregiao.Mesorregiao.Uf.Nome;
                if (estado == comboEstados.Text)
                {
                    comboCidades.Items.Add(m.Nome);
                }
            }
        }

        private void botaoFiltrar_Click(object sender, EventArgs e)
        {
            //Chamando a função que vai pesquisar os registros 
            carregaInfo(Program.pesquisaCliente(clienteNome.Text,comboEstados.Text,comboCidades.Text,clienteBairro.Text,"","",""), clienteNome.Text, comboEstados.Text,comboCidades.Text,clienteBairro.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carregaInfo(null,"","","","");
            comboCidades.Enabled = false;
            clienteBairro.Enabled = false;
        }

        private void clienteBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteBairro.Enabled = true;
            clienteBairro.Items.Clear();
            clienteBairro.Text = "";

            //Alimentando a ComboBox de bairros de acordo com a cidade selecionada

            foreach (string bairro in Program.retornaBairros(comboCidades.Text))
            {
                clienteBairro.Items.Add(bairro);
            }
        }

        private void exportarExcel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            string nome = Program.Exportar("cliente", listaClientesEditar);
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