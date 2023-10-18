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
    public partial class EditarTipoProduto : Form
    {

        int id_tipoProduto;
        MenuTiposProduto tela_anterior;

        public EditarTipoProduto(MenuTiposProduto tela,int idTipoProduto)
        {
            tela_anterior = tela;
            id_tipoProduto = idTipoProduto;
            InitializeComponent();
        }

        private void botaoVoltarMenu_Click(object sender, EventArgs e)
        {
            // Chamando a tela de Menu de Tipos de Produto e fechando a tela atual
            this.Close();
            tela_anterior.Enabled = true;
            tela_anterior.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Chamando a função que vai editar o registro 
            List<string> campos = new List<string>();
            campos.Add(tipoProdutoNome.Text);


            if (Program.editaRegistro("tipo_produto", id_tipoProduto, campos) == true)
            {
                // Chamando a tela de Menu de Tipos de Produto e fechando a tela atual
                botaoVoltarMenu_Click(sender, e);
            }
            else
            {
                return;
            }

            
        }

        private void EditarTipoProduto_Load(object sender, EventArgs e)
        {
            //Preenchendo os campos com os dados do tipo de produto a ser editado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select nome from tipo_produto where id={id_tipoProduto}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                
                                tipoProdutoNome.Text = reader.GetString(0);
                                
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
    }
}
