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
    public partial class MenuPedidos : Form
    {
        public MenuPedidos()
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

        private void botaoCriarTipoProduto_Click(object sender, EventArgs e)
        {
            //Abrindo tela de Adicionar Pedido e escondendo a de Pedidos
            var addPedido = new AddPedido(new List<ItemPedido>());
            this.Hide();
            addPedido.Show();
        }

        private void OnEnabledChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listaPedidos.Items)
            {
                if (!Program.verificaSeExiste("pedido", int.Parse(i.SubItems[0].Text)))
                {
                    //Removendo o pedido do datagrid, se foi removido do banco
                    listaPedidos.Items.Remove(i);
                    Console.WriteLine(i.SubItems[0].Text);
                }
                else {
                    //Atualizando status e data de entrega do pedido
                    Pedido ped = Program.retornaPedidoPorId(int.Parse(i.SubItems[0].Text));
                    if (ped.Status == 1) {
                        i.SubItems[6].Text = "Finalizado";
                    }else{
                        i.SubItems[6].Text = "Aberto";
                    }
                    if (ped.Data_Entrega != Program.dataRepresentandoNull) {
                        i.SubItems[8].Text = Convert.ToString(ped.Data_Entrega.ToLocalTime());
                    }
                    if (status.Text == "Aberto" && i.SubItems[6].Text == "Finalizado")
                    {
                        listaPedidos.Items.Remove(i);
                    }

                    //Atualizando valor do pedido
                    i.SubItems[5].Text = "R$ " + Convert.ToString(ped.Valor).Replace(',','.');

                }
            }
        }

        private void carregaInfo(List<Pedido> lista, string nc,string ec,string cc,string bc, string valor1, string valor2, string dtCriacao1, string dtCriacao2, string dtEntrega1, string dtEntrega2,string statusP)
        {
            listaPedidos.Items.Clear();
            List<Pedido> pedidos;

            if (lista == null)
            {
                pedidos = Program.retornaPedidos();
            }
            else
            {
                pedidos = lista;
            }

            if (nc != null)
            {
                clienteNome.Text = nc;
            }
            if (ec != null)
            {
                comboEstados.Text = ec;
            }
            if (cc != null)
            {
                comboCidades.Text = cc;
            }
            if (bc != null)
            {
                clienteBairro.Text = bc;
            }
            if (valor1 != null)
            {
                valorMaiorQue.Text = valor1;
            }
            if (valor2 != null)
            {
                valorMenorQue.Text = valor2;
            }
            if (dtCriacao1 != null)
            {
                dtCriacaoInicio.Text = dtCriacao1;
            }
            if (dtCriacao2 != null)
            {
                dtCriacaoFim.Text = dtCriacao2;
            }
            if (dtEntrega1 != null)
            {
                dtEntregaInicio.Text = dtEntrega1;
            }
            if (dtEntrega2 != null)
            {
                dtEntregaFim.Text = dtEntrega2;
            }
            if (statusP != null)
            {
                status.Text = statusP;
            }


            foreach (Pedido p in pedidos)
            {
                string status;
                if (p.Status == 1)
                {
                    status = "Finalizado";
                }
                else
                {
                    status = "Aberto";
                }
                string dataEntrega = "";
                if (p.Data_Entrega != Program.dataRepresentandoNull)
                {
                    dataEntrega = Convert.ToString(p.Data_Entrega.ToLocalTime());
                }

                string es = p.Cliente.Estado;
                foreach (Municipio m in Program.municipios)
                {
                    UF estado = m.Microrregiao.Mesorregiao.Uf;
                    if (es == estado.Nome)
                    {
                        es = estado.Sigla;
                    }
                }
                listaPedidos.Items.Add(
                    new ListViewItem(new string[] { Convert.ToString(p.Id), p.Cliente.Nome, es, p.Cliente.Cidade, p.Cliente.Bairro, "R$ " + Convert.ToString(p.Valor).Replace(',', '.'), status, Convert.ToString(p.Data_Criacao.ToLocalTime()),dataEntrega })
                );
            }
            
        }

        private void MenuPedidos_Load(object sender, EventArgs e)
        {
            string dataAtual = Convert.ToString(DateTime.UtcNow.ToLocalTime());
            carregaInfo(null,null,null,null,null,null,null,null,dataAtual,null,dataAtual,"Ambos");

            //Alimentando a ComboBox de estados
            foreach (Municipio m in Program.municipios)
            {
                string estado = m.Microrregiao.Mesorregiao.Uf.Nome;
                if (!comboEstados.Items.Contains(estado))
                {
                    comboEstados.Items.Add(estado);
                }

            }

            //Alimentando a ComboBox de clientes
            foreach (Cliente c in Program.retornaClientes())
            {
                if (!clienteNome.Items.Contains(c.Id + " | " + c.Nome))
                {
                    clienteNome.Items.Add(c.Id + " | " + c.Nome);
                }

            }


            
        }

        private void listaPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaPedidos.SelectedItems.Count == 0)
            {
                return;
            }

            string idPedido = listaPedidos.SelectedItems[0].Text;



            // Chamando a tela de Escolher Editar/Remover e deixando a tela atual em stand-by
            var caixaDialogoEditarRemover = new CaixaDialogoEditarRemover(null, null, null, this, int.Parse(idPedido));
            this.Enabled = false;
            caixaDialogoEditarRemover.Show();
        }

        private void comboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                comboCidades.Enabled = true;
                comboCidades.Text = "";
                comboCidades.Items.Clear();

                clienteBairro.Enabled = false;
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

            string v1 = "0", v2 = "99999999999";
            if (valorMaiorQue.Text.Trim() != "")
            {
                v1 = valorMaiorQue.Text.Trim().Replace(',', '.');
            }
            if (valorMenorQue.Text.Trim() != "")
            {
                v2 = valorMenorQue.Text.Trim().Replace(',', '.');
            }

            int idCliente;
            try {
                idCliente = int.Parse(clienteNome.Text.Split('|')[0].Trim());
            }
            catch
            {
                idCliente = -1;
            }
            string NomeCliente = clienteNome.Text;
            if(idCliente != -1 && Program.verificaSeExiste("cliente",idCliente)) {
                Cliente cliente = Program.retornaClientePorId(idCliente);
                NomeCliente = cliente.Nome;
            }
            
            //Chamando a função que vai pesquisar os registros 
            carregaInfo(Program.pesquisaPedido(NomeCliente, comboEstados.Text, comboCidades.Text, clienteBairro.Text, "", "", "",v1,v2,dtCriacaoInicio.Text,dtCriacaoFim.Text,dtEntregaInicio.Text,dtEntregaFim.Text,status.Text), clienteNome.Text, comboEstados.Text, comboCidades.Text, clienteBairro.Text, valorMaiorQue.Text, valorMenorQue.Text, dtCriacaoInicio.Text, dtCriacaoFim.Text, dtEntregaInicio.Text, dtEntregaFim.Text, status.Text);
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(status.Text == "Finalizado")
            {
                dtEntregaInicio.Enabled = true;
                dtEntregaFim.Enabled = true;

                dtEntregaInicio.Visible = true;
                dtEntregaFim.Visible = true;
                label9.Visible = true;
                label10.Visible = true;


                dtEntregaInicio.MinDate = DateTime.Parse("01/01/2023");
                dtEntregaFim.MinDate = DateTime.Parse("01/01/2023");
                dtEntregaInicio.Text = "01/01/2023";
                dtEntregaFim.Text = DateTime.UtcNow.ToString();
            }
            else if(status.Text == "Aberto")
            {
                    dtEntregaInicio.Enabled = false;
                    dtEntregaFim.Enabled = false;
                    dtEntregaInicio.Visible = false;
                    dtEntregaFim.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    dtEntregaInicio.MinDate = DateTime.Parse("01/01/1970");
                    dtEntregaFim.MinDate = DateTime.Parse("01/01/1970");
                    dtEntregaInicio.Text = "01/01/1970";
                    dtEntregaFim.Text = "01/01/1970";
            }
            else
            {
                dtEntregaInicio.Enabled = true;
                dtEntregaFim.Enabled = true;

                label9.Visible = false;
                label10.Visible = false;
                dtEntregaInicio.Visible = false;
                dtEntregaFim.Visible = false;


                dtEntregaInicio.MinDate = DateTime.Parse("01/01/1970");
                dtEntregaFim.MinDate = DateTime.Parse("01/01/2023");
                dtEntregaInicio.Text = "01/01/1970";
                dtEntregaFim.Text = DateTime.UtcNow.ToString();
            }
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

        private void dtCriacaoInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboCidades.Enabled = false;
            clienteBairro.Enabled = false;
            status.SelectedItem = "Ambos";
            carregaInfo(null, "", "", "", "","","","01/01/2023", Convert.ToString(DateTime.UtcNow), "01/01/1970", Convert.ToString(DateTime.UtcNow), "Ambos");

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

            string nome = Program.Exportar("pedido", listaPedidos);

            if (nome != "")
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
