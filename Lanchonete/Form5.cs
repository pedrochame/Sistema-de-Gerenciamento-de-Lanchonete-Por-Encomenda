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
    public partial class EditarCliente2 : Form
    {
        int id_cliente;
        EditarCliente tela_anterior;
        

        public EditarCliente2(EditarCliente tela,int idCliente)
        {
            id_cliente = idCliente;
            tela_anterior = tela;
            InitializeComponent();
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


            if (Program.editaRegistro("cliente", id_cliente,campos) == true)
            {
                // Chamando a tela de Editar Clientes e fechando a tela atual
                botaoVoltarMenu_Click(sender, e);
            }
            else
            {
                return;
            }

            

        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            //Chamando a tela de Clientes e fechando a tela atual
            this.Close();
            tela_anterior.Enabled = true;
            tela_anterior.Activate();
        }

        private void EditarCliente2_Load(object sender, EventArgs e)
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


            //Preenchendo os campos com os dados do cliente a ser editado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select nome,estado,cidade,bairro,endereco,tel,email from cliente where id={id_cliente}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clienteNome.Text = reader.GetString(0);
                                comboEstados.SelectedItem = reader.GetString(1);
                                comboCidades.SelectedItem = reader.GetString(2);
                                clienteBairro.Text = reader.GetString(3);
                                clienteEndereco.Text = reader.GetString(4);
                                clienteTel.Text = reader.GetString(5);
                                clienteEmail.Text = reader.GetString(6);

                                
                            }
                        }
                    }

                    

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }



        }

        private void comboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Liberando a ComboBox de cidades
            comboCidades.Enabled = true;
            comboCidades.Text = "";
            comboCidades.Items.Clear();
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

        private void comboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Liberando o campo de bairros
            clienteBairro.Enabled = true;
            clienteBairro.Text = "";
        }
    }
}
