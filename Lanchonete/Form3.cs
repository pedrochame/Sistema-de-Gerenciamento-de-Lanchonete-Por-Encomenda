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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Lanchonete
{
    

    public partial class AdicionarCliente : Form
    {


        EditarCliente tela_MenuClientes;
        AddPedido tela_AddPedido;


        public AdicionarCliente(EditarCliente t, AddPedido t2)
        {
            tela_MenuClientes = t;
            tela_AddPedido = t2;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            if (tela_MenuClientes != null) {
                //Chamando a tela de Menu de Clientes e fechando a tela atual
                var menuClientes = new EditarCliente();
                this.Close();
                menuClientes.Show();
            }
            if (tela_AddPedido != null)
            {
                // Chamando a tela de Adicionar Pedido e fechando a tela atual
                tela_AddPedido.Enabled = true;
                this.Close();
            }
        }

        private void AdicionarCliente_Load(object sender, EventArgs e)
        {
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

        private void comboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Liberando a ComboBox de cidades
            comboCidades.Enabled = true;
            comboCidades.Text = "";
            comboCidades.Items.Clear();
            clienteBairro.Enabled = true;
            clienteBairro.Text = "";


            //Alimentando a ComboBox de cidades de acordo com o estado selecionado
            foreach (Municipio m in Program.municipios)
            {
                string estado = m.Microrregiao.Mesorregiao.Uf.Nome;
                if (estado == comboEstados.Text) {
                    comboCidades.Items.Add(m.Nome);
                }
            }
            

        }

        private void comboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Liberando o campo de Bairro
            clienteBairro.Enabled = true;
            clienteBairro.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Chamando a função que vai adicionar um novo registro 
            List<string> campos = new List<string>();
            campos.Add(clienteNome.Text);
            campos.Add(comboEstados.Text);
            campos.Add(comboCidades.Text);
            campos.Add(clienteBairro.Text);
            campos.Add(clienteEndereco.Text);
            campos.Add(clienteTel.Text);
            campos.Add(clienteEmail.Text);

            
            if(Program.adicionaRegistro("cliente",campos) == true)
            {

                if (tela_MenuClientes != null)
                {
                    // Chamando a tela de Clientes e fechando a tela atual
                    var menuClientes = new EditarCliente();
                    this.Close();
                    menuClientes.Show();
                }
                if (tela_AddPedido != null)
                {
                    // Chamando a tela de Adicionar Pedido e fechando a tela atual
                    tela_AddPedido.Enabled = true;
                    this.Close();
                }
            }
            else
            {
                return;
            }

        }

        private void comboBairros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
