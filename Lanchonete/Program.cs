using Aspose.Cells;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lanchonete
{


    internal static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        
        //Definindo a string de conexão para o banco de dados SQLite.
        public const string connectionString = "Data Source=BDLanchonete.db;Version=3;";
        
        public static List<Municipio> municipios = new List<Municipio>();

        public static DateTime dataRepresentandoNull = DateTime.Parse("01/01/1970 03:00:00");

/// </summary>
[STAThread]

        //Método para corrigir caracteres especiais vindos dos dados obtidos através da API do IBGE
        public static string UTF8_to_ISO(string value)
        {
            Encoding isoEncoding = Encoding.GetEncoding("ISO-8859-1");
            Encoding utfEncoding = Encoding.UTF8;
            
            byte[] bytesIso = utfEncoding.GetBytes(value);
            byte[] bytesUtf = Encoding.Convert(utfEncoding, isoEncoding,bytesIso);

            string textoISO = utfEncoding.GetString(bytesUtf);

            return textoISO;
        }

        //Método para buscar os municípos via API e armazenar na lista local
        public static void preencheListaMunicipios() {
            var mun = Municipio.listarMunicipios();
            foreach (Municipio m in mun)
            {
                m.Nome = UTF8_to_ISO(m.Nome);
                m.Microrregiao.Mesorregiao.Uf.Nome = UTF8_to_ISO(m.Microrregiao.Mesorregiao.Uf.Nome);
                municipios.Add(m);
            }
        }

















        //Função para exportar o datagrid da página como arquivo de excel
        public static string Exportar(string tabela,System.Windows.Forms.ListView lista)
        {

            try
            {
                //Criando o arquivo
                Workbook workbook = new Workbook();
                Worksheet worksheet = workbook.Worksheets[0];

                if (tabela != "pedido") {

                    for (int i = 0; i < lista.Columns.Count; i++)
                    {
                        ArrayList info = new ArrayList();
                        info.Add(lista.Columns[i].Text);

                        foreach (ListViewItem item in lista.Items)
                        {
                            info.Add(item.SubItems[i].Text);
                        }

                        worksheet.Cells.ImportArrayList(info, 0, i, true);
                    }
                }
                else
                {

                    for (int i = 0; i < 5; i++)
                    {
                        ArrayList info = new ArrayList();
                        info.Add(lista.Columns[i].Text);

                        foreach (ListViewItem item in lista.Items)
                        {
                            info.Add(item.SubItems[i].Text);
                        }

                        worksheet.Cells.ImportArrayList(info, 0, i, true);
                    }

                    string[] k = { "Endereço", "Telefone", "Email" };
                    int x = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        ArrayList info = new ArrayList();
                        info.Add(k[i]);


                        foreach (ListViewItem item in lista.Items)
                        {

                            Pedido p = retornaPedidoPorId(int.Parse(item.SubItems[0].Text));
                            if (k[i] == "Endereço") {
                                info.Add(p.Cliente.Endereco);
                            }
                            if (k[i] == "Telefone")
                            {
                                info.Add(p.Cliente.Telefone);
                            }
                            if (k[i] == "Email")
                            {
                                info.Add(p.Cliente.Email);
                            }
                        }


                        worksheet.Cells.ImportArrayList(info, 0, 5 + x, true);

                        x++;
                    }

                    for (int i = 5; i < lista.Columns.Count; i++)
                    {
                        ArrayList info = new ArrayList();
                        info.Add(lista.Columns[i].Text);

                        foreach (ListViewItem item in lista.Items)
                        {
                            info.Add(item.SubItems[i].Text);
                        }

                        worksheet.Cells.ImportArrayList(info, 0, i+3, true);
                    }

                }
                

                //Colocando data e hora no nome do arquivo
                string dh = Convert.ToString(DateTime.Now.ToLocalTime()).Replace(':', '-').Replace('/', '-');

                //Salvando o arquivo de excel de acordo com o tipo de dado
                string nome = "";

                if (tabela == "tipo_produto")
                {
                    nome = "Tipos de Produto";
                }
                else if (tabela == "cliente")
                {
                    nome = "Clientes";
                }
                else if (tabela == "produto")
                {
                    nome = "Produtos";
                }
                else if (tabela == "pedido")
                {
                    nome = "Pedidos";
                }

                workbook.Save($"../../../{nome} {dh}.xlsx");

                return $"{nome} {dh}.xlsx";

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }































    public static bool adicionaRegistro(string tabela, List<string> campos)
        {
            //Removendo espaços a esq. e dir. dos campos informados
            for (int i=0;i<campos.Count();i++)
            {
                campos[i] = campos[i].Trim();
            }

            if (tabela == "tipo_produto")
            {
                foreach (tipoDeProduto t in retornaTiposProduto())
                {
                    if (t.Nome.ToLower() == campos[0].ToLower())
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Já existe um Tipo de Produto com este nome.", "Atenção!", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }

            if (tabela == "produto")
            {
                foreach (produto p in retornaProdutos())
                {
                    if (p.Nome.ToLower() == campos[0].ToLower())
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Já existe um Produto com este nome.", "Atenção!", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }


            if (tabela == "cliente")
            {
                foreach (Cliente c in retornaClientes())
                {
                    if (c.Telefone == campos[5] )
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Já existe um Cliente com este telefone.", "Atenção!", MessageBoxButtons.OK);
                        return false;
                    }
                    if (c.Email.ToLower() == campos[6].ToLower() && campos[6] != "")
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Já existe um Cliente com este email.", "Atenção!", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }


            //Se algum campo estiver em branco, a adição não acontece
            for(int i=0;i<campos.Count;i++)
            {
                //Email, da tabela Cliente, não é obrigatório
                if (tabela == "cliente" && i==6)
                {
                    break;
                }
                //Descrição, da tabela Produto, não é obrigatório
                if (tabela == "produto" && i ==1)
                {
                    break;
                }

                if (campos[i] == "")
                {
                    DialogResult aviso = new DialogResult();
                    aviso = MessageBox.Show("Preencha todos os campos.", "Atenção!", MessageBoxButtons.OK);
                    return false;
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string s="null,";
                    for(int i=0;i<campos.Count;i++)
                    {
                        if (i != campos.Count-1) {
                            s += $"'{campos[i]}',";
                        }
                        else
                        {
                            s += $"'{campos[i]}'";
                        }
                    }

                    string insertIntoTable = $"insert into {tabela} values({s})";
                    using (SQLiteCommand command = new SQLiteCommand(insertIntoTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                    if (tabela != "item_pedido")
                    {
                        //Mostrando a mensagem de sucesso
                        DialogResult dialog = new DialogResult();
                        if (tabela == "tipo_produto") {
                            dialog = MessageBox.Show($"O tipo de produto foi adicionado.", "Sucesso!", MessageBoxButtons.OK);
                        }
                        else {
                            dialog = MessageBox.Show($"O {tabela} foi adicionado.", "Sucesso!", MessageBoxButtons.OK);
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    DialogResult msgErro = new DialogResult();
                    msgErro = MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro!", MessageBoxButtons.OK);
                    return false;
                }
            }
        }

        public static bool editaRegistro(string tabela, int idRegistro, List<string> campos)
        {
            //Removendo espaços a esq. e dir. dos campos informados
            for (int i = 0; i < campos.Count(); i++)
            {
                campos[i] = campos[i].Trim();
            }


            string id = Convert.ToString(idRegistro);


            if (tabela == "tipo_produto")
            {
                foreach (tipoDeProduto t in retornaTiposProduto())
                {
                    if (t.Id != int.Parse(id)){
                        if (t.Nome.ToLower() == campos[0].ToLower())
                        {
                            DialogResult dialog = new DialogResult();
                            dialog = MessageBox.Show("Já existe um Tipo de Produto com este nome.", "Atenção!", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }

            if (tabela == "produto")
            {
                foreach (produto p in retornaProdutos())
                {
                    if (p.Id != int.Parse(id)) {
                        if (p.Nome.ToLower() == campos[0].ToLower())
                        {
                            DialogResult dialog = new DialogResult();
                            dialog = MessageBox.Show("Já existe um Produto com este nome.", "Atenção!", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }


            if (tabela == "cliente")
            {
                foreach (Cliente c in retornaClientes())
                {
                    if(c.Id != int.Parse(id)){
                        if (c.Telefone == campos[5])
                        {
                            DialogResult dialog = new DialogResult();
                            dialog = MessageBox.Show("Já existe um Cliente com este telefone.", "Atenção!", MessageBoxButtons.OK);
                            return false;
                        }
                        if (c.Email.ToLower() == campos[6].ToLower() && campos[6] != "")
                        {
                            DialogResult dialog = new DialogResult();
                            dialog = MessageBox.Show("Já existe um Cliente com este email.", "Atenção!", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }


            //Se algum campo estiver em branco, a adição não acontece
            for (int i = 0; i < campos.Count; i++)
            {
                //Email, da tabela Cliente, não é obrigatório
                if (tabela == "cliente" && i == 6)
                {
                    break;
                }
                //Descrição, da tabela Produto, não é obrigatório
                if (tabela == "produto" && i == 1)
                {
                    break;
                }

                if (campos[i] == "")
                {
                    DialogResult aviso = new DialogResult();
                    aviso = MessageBox.Show("Preencha todos os campos.", "Atenção!", MessageBoxButtons.OK);
                    return false;
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string s = "";
                    for (int i = 0; i < campos.Count; i++)
                    {
                        if (i != campos.Count - 1)
                        {
                            s += $"{retornaColunas(tabela)[i]} = '{campos[i]}',";
                        }
                        else
                        {
                            s += $"{retornaColunas(tabela)[i]} = '{campos[i]}'";
                        }
                    }

                    string updateTable = $"update {tabela} set {s} where id = {id}";
                    using (SQLiteCommand command = new SQLiteCommand(updateTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                    //Mostrando a mensagem de sucesso
                    DialogResult dialog = new DialogResult();
                    if (tabela == "tipo_produto")
                    {
                        dialog = MessageBox.Show($"O tipo de produto foi editado.", "Sucesso!", MessageBoxButtons.OK);
                    }
                    else {
                        dialog = MessageBox.Show($"O {tabela} foi editado.", "Sucesso!", MessageBoxButtons.OK);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    //Mostrando a mensagem de erro
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    DialogResult msgErro = new DialogResult();
                    msgErro = MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro!", MessageBoxButtons.OK);
                    return false;
                }
            }
        }



        public static bool finalizarPedido(int id)
        {

            string data = Convert.ToString(DateTime.UtcNow);
            
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string updateTable = $"update pedido set status = 1 , data_entrega='{data}' where id = {id}";
                    using (SQLiteCommand command = new SQLiteCommand(updateTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                    
                    return true;
                }
                catch (Exception ex)
                {
                    //Mostrando a mensagem de erro
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    return false;
                }
            }
        }





        public static List<string> retornaColunas(string tabela)
        {
            List<string> colunas = new List<string>();

            //Buscando no banco de dados, na tabela em questão, todos os registros
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from {tabela}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            int nColunas = reader.FieldCount;
                            while (reader.Read())
                            {
                                //Todas as colunas A PARTIR do Id
                                for (int i = 1; i<nColunas; i++)
                                {
                                    colunas.Add(reader.GetName(i));
                                }
                                break;
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
            return colunas;
        }

        public static List<tipoDeProduto> retornaTiposProduto()
        {
            List<tipoDeProduto> listaItens = new List<tipoDeProduto>();

            //Buscando no banco de dados, na tabela em questão, todos os registros
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from tipo_produto order by nome asc";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nome = reader.GetString(1);
                                listaItens.Add(new tipoDeProduto(id,nome));
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

            return listaItens;

        }

        public static List<Cliente> retornaClientes()
        {
            List<Cliente> listaItens = new List<Cliente>();

            //Buscando no banco de dados, na tabela em questão, todos os registros
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = "select * from cliente order by nome";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
        
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nome = reader.GetString(1);
                                string estado = reader.GetString(2);
                                string cidade = reader.GetString(3);
                                string bairro = reader.GetString(4);
                                string endereco = reader.GetString(5);
                                string telefone = reader.GetString(6);
                                string email = reader.GetString(7);
                                listaItens.Add(new Cliente(id, nome, estado, cidade, bairro, endereco, telefone, email));
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

            return listaItens;

        }


        public static produto retornaProdutoPorNome(string nome)
        {


            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from produto where nome='{nome}'";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idP = reader.GetInt32(0);
                                string nomeP = reader.GetString(1);
                                string descP = reader.GetString(2);
                                double valorP = reader.GetDouble(3);

                                tipoDeProduto tp = new tipoDeProduto(reader.GetInt32(4), retornaTipoDeProdutoPorId(reader.GetInt32(4)).Nome);


                                produto p = new produto(idP, nomeP, descP, valorP, tp);
                                return p;


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


            return null;
        }



        public static produto retornaProdutoPorId(int id)
        {


            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from produto where id='{id}'";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idP = reader.GetInt32(0);
                                string nomeP = reader.GetString(1);
                                string descP = reader.GetString(2);
                                double valorP = reader.GetDouble(3);

                                tipoDeProduto tp = new tipoDeProduto(reader.GetInt32(4), retornaTipoDeProdutoPorId(reader.GetInt32(4)).Nome);


                                produto p = new produto(idP, nomeP, descP, valorP, tp);
                                return p;


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


            return null;
        }



        public static produto retornaProduto(int id)
        {
            

            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from produto where id={id}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idP = reader.GetInt32(0);
                                string nomeP = reader.GetString(1);
                                string descP = reader.GetString(2);
                                double valorP = reader.GetDouble(3);

                                tipoDeProduto tp = new tipoDeProduto(reader.GetInt32(4), retornaTipoDeProdutoPorId(reader.GetInt32(4)).Nome);
     

                                produto p = new produto(idP,nomeP,descP,valorP,tp);
                                return p;
                               
                            
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


            return null;
        }

        public static List<ItemPedido> retornaItemPedidoPorIdPedido(int id)
        {
            List <ItemPedido> lista = new List<ItemPedido>();

            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from item_pedido where id_pedido={id}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idI = reader.GetInt32(0);
                                int idPedidoI = reader.GetInt32(1);
                                int idProdutoI= reader.GetInt32(2);
                                int qtI = reader.GetInt32(3);
                                double valorI = reader.GetDouble(4);

                                ItemPedido ip = new ItemPedido(retornaProduto(idProdutoI),qtI,valorI);
                                ip.Id = idI;
                                lista.Add(ip);


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


            return lista;
        }


        public static bool existeCliente(string nome)
        {


            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from cliente where nome='{nome}'";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idC = reader.GetInt32(0);
                                string nomeC = reader.GetString(1);
                                string estadoC = reader.GetString(2);
                                string cidadeC = reader.GetString(3);
                                string bairroC = reader.GetString(4);
                                string endC = reader.GetString(5);
                                string telC = reader.GetString(6);
                                string emailC = reader.GetString(7);

                                Cliente c = new Cliente(idC, nomeC, estadoC, cidadeC, bairroC, endC, telC, emailC);
                                return true;


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


            return false;
        }



        public static int retornaIdUltimoPedido()
        {


            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from pedido order by data_criacao desc";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                return reader.GetInt32(0);


                            }


                        }
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    Console.WriteLine("ERRO AO BUSCAR ULTIMO PEDIDO");
                }
            }


            return -1;
        }



        public static List<ItemPedido> retornaItensPedido()
        {
            List<ItemPedido> lista = new List<ItemPedido>();

            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = "select * from item_pedido";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idC = reader.GetInt32(0);
                                int idPedido = reader.GetInt32(1);
                                int idProduto= reader.GetInt32(2);
                                int qt = reader.GetInt32(3);
                                double valor = reader.GetDouble(4);
                                
                                ItemPedido item = new ItemPedido(retornaProdutoPorId(idProduto),qt,valor);
                                item.Id = idC;

                                lista.Add(item);
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


            return lista;
        }

        public static List<string> retornaBairros(string cidade)
        {
            List<string> lista = new List<string>();

            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select bairro from cliente where cidade = '{cidade}'";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string b = reader.GetString(0);
                                if (!lista.Contains(b)) {
                                    lista.Add(b);
                                }
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


            return lista;
        }


        public static Cliente retornaClientePorId(int id)
        {


            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from cliente where id={id}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idC = reader.GetInt32(0);
                                string nomeC = reader.GetString(1);
                                string estadoC = reader.GetString(2);
                                string cidadeC = reader.GetString(3);
                                string bairroC = reader.GetString(4);
                                string endC = reader.GetString(5);
                                string telC = reader.GetString(6);
                                string emailC = reader.GetString(7);

                                Cliente c = new Cliente(idC,nomeC,estadoC,cidadeC,bairroC,endC,telC,emailC);
                                return c;


                            }


                        }
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    Console.WriteLine("RETORNA CLIENTE POR ID");
                }
            }


            return null;
        }



        public static bool removeItensPedido(int id_pedido)
        {
            
            //Removendo o registro da tabela
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string deleteFromTable = $"delete from item_pedido where id_pedido = {id_pedido}";
                    using (SQLiteCommand command = new SQLiteCommand(deleteFromTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    return false;
                }
            }
            return true;
        }









        public static bool verificaSeExiste(string tabela, int id)
        {

            int id_registro = -1;

            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select id from '{tabela}' where id = {id}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                id_registro = reader.GetInt32(0);
                            }   
                        }
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    Console.WriteLine("VERIFICA SE EXISTE");
                    return false;
                }
            }
            if (id_registro == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }









        public static List<Cliente> pesquisaCliente(string nomeC, string estadoC, string cidadeC, string bairroC, string endC, string telC, string emailC)
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
                {
                    connection.Open();

                    string nome = nomeC;
                    string estado = estadoC;
                    string cidade = cidadeC;
                    string bairro = bairroC;
                    string endereco = endC;
                    string telefone = telC;
                    string email = emailC;

                    string selectFromTable = $"select * from cliente where nome like '%{nome}%' and estado like '%{estado}%' and cidade like '%{cidade}%' and bairro like '%{bairro}%' and endereco like '%{endereco}%' and tel like '%{telefone}%' and email like '%{email}%'  order by nome asc";
                    Console.WriteLine(selectFromTable);

                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nc = reader.GetString(1);
                                string ec = reader.GetString(2);
                                string cc = reader.GetString(3);
                                string bc = reader.GetString(4);
                                string enC = reader.GetString(5);
                                string tc = reader.GetString(6);
                                string emC = reader.GetString(7);

                                Cliente obj = new Cliente(id,nc,ec,cc,bc,enC,tc,emC);
                                lista.Add(obj);
                            }
                        }
                    }
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
            }

            return lista;
        }


        public static List<Pedido> pesquisaPedido(string nomeC, string estadoC, string cidadeC, string bairroC, string endC, string telC, string emailC, string valorMaiorQueP,string valorMenorQueP,string dtCriacaoInicioP,string dtCriacaoFimP,string dtEntregaInicioP,string dtEntregaFimP,string status)
        {
            List<Pedido> lista = new List<Pedido>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
                {
                    connection.Open();

                    string nome = nomeC;
                    string estado = estadoC;
                    string cidade = cidadeC;
                    string bairro = bairroC;
                    string endereco = endC;
                    string telefone = telC;
                    string email = emailC;
                    string valorMaiorQue = valorMaiorQueP;
                    string valorMenorQue = valorMenorQueP;


                    
                    if (!dtCriacaoInicioP.Contains(':'))
                    {
                        dtCriacaoInicioP += " 00:00:00";
                    }
                    if (!dtCriacaoFimP.Contains(':'))
                    {
                        dtCriacaoFimP += " 23:59:59";
                    }
                    if (!dtEntregaInicioP.Contains(':'))
                    {
                        dtEntregaInicioP += " 00:00:00";
                    }
                    if (!dtEntregaFimP.Contains(':'))
                    {
                        dtEntregaFimP += " 23:59:59";
                    }

                    string dtCriacaoInicio = Convert.ToString(DateTime.Parse(dtCriacaoInicioP).ToUniversalTime());
                    string dtCriacaoFim = Convert.ToString(DateTime.Parse(dtCriacaoFimP).ToUniversalTime());
                    string dtEntregaInicio = Convert.ToString(DateTime.Parse(dtEntregaInicioP).ToUniversalTime());
                    string dtEntregaFim = Convert.ToString(DateTime.Parse(dtEntregaFimP).ToUniversalTime());

                    
                    
                    
                    
                    
                    
                    
                    string selectFromTable;
                    if (status == "Finalizado")
                    {
                        selectFromTable = $"select p.id,p.id_cliente,c.nome,c.estado,c.cidade,c.bairro,c.endereco,c.tel,c.email,p.status,p.valor,p.data_criacao,p.data_entrega from pedido as p,cliente as c where c.estado like '%{estado}%' and c.cidade like '%{cidade}%' and c.bairro like '%{bairro}%' and c.nome like '%{nome}%' and c.endereco like '%{endereco}%' and c.tel like '%{telefone}%' and c.email like '%{email}%' and p.valor >= '{valorMaiorQue}' and p.valor <= '{valorMenorQue}' and p.data_criacao >= '{dtCriacaoInicio}' and p.data_criacao <= '{dtCriacaoFim}' and p.data_entrega >= '{dtEntregaInicio}' and p.data_entrega <= '{dtEntregaFim}' and p.status = 1 and p.id_cliente = c.id order by data_criacao asc";
                    }
                    else if(status == "Aberto")
                    {
                        selectFromTable = $"select p.id,p.id_cliente,c.nome,c.estado,c.cidade,c.bairro,c.endereco,c.tel,c.email,p.status,p.valor,p.data_criacao,p.data_entrega from pedido as p,cliente as c where c.estado like '%{estado}%' and c.cidade like '%{cidade}%' and c.bairro like '%{bairro}%' and c.nome like '%{nome}%' and c.endereco like '%{endereco}%' and c.tel like '%{telefone}%' and c.email like '%{email}%' and p.valor >= '{valorMaiorQue}' and p.valor <= '{valorMenorQue}' and p.data_criacao >= '{dtCriacaoInicio}' and p.data_criacao <= '{dtCriacaoFim}' and p.data_entrega >= '{dtEntregaInicio}' and p.data_entrega <= '{dtEntregaFim}' and p.status = 0 and p.id_cliente = c.id order by data_criacao asc";
                    }
                    else
                    {
                        selectFromTable = $"select p.id,p.id_cliente,c.nome,c.estado,c.cidade,c.bairro,c.endereco,c.tel,c.email,p.status,p.valor,p.data_criacao,p.data_entrega from pedido as p,cliente as c where c.estado like '%{estado}%' and c.cidade like '%{cidade}%' and c.bairro like '%{bairro}%' and c.nome like '%{nome}%' and c.endereco like '%{endereco}%' and c.tel like '%{telefone}%' and c.email like '%{email}%' and p.valor >= '{valorMaiorQue}' and p.valor <= '{valorMenorQue}' and p.data_criacao >= '{dtCriacaoInicio}' and p.data_criacao <= '{dtCriacaoFim}' and p.data_entrega >= '{dtEntregaInicio}' and p.data_entrega <= '{dtEntregaFim}' and p.id_cliente = c.id order by data_criacao asc";
                    }

                    Console.WriteLine(selectFromTable);

                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                int idC = reader.GetInt32(1);
                                string nc = reader.GetString(2);
                                string ec = reader.GetString(3);
                                string cc = reader.GetString(4);
                                string bc = reader.GetString(5);
                                string enC = reader.GetString(6);
                                string tc = reader.GetString(7);
                                string emC = reader.GetString(8);
                                int s = reader.GetInt32(9);
                                double v = reader.GetDouble(10);
                                DateTime dc = DateTime.Parse(reader.GetString(11));
                                DateTime de = DateTime.Parse(reader.GetString(12));

                                Cliente c = new Cliente(id, nc, ec, cc, bc, enC, tc, emC);
                                Pedido p = new Pedido(c, retornaItemPedidoPorIdPedido(id));
                                p.Id = id;
                                p.Status = s;
                                p.Valor = v;
                                p.Data_Criacao = dc;
                                p.Data_Entrega = de;

                                lista.Add(p);
                            }
                        }
                    }
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                Console.WriteLine("aquiiiiiiii");
            }

            return lista;
        }











        public static List<produto> pesquisaProduto(string nomeP,string descP,string vMaior,string vMenor,int idTP)
        {
            List<produto> lista = new List<produto>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
                {
                     connection.Open();

                    string nome = nomeP;
                    string desc = descP;
                    string valorMaior = vMaior;
                    string valorMenor = vMenor;
                    int idTipo = idTP;


                    string selectFromTable;
                    if (idTipo>0) {
                        selectFromTable = $"select * from produto where nome like '%{nome}%' and descricao like '%{desc}%' and valor >= '{valorMaior}' and valor <= '{valorMenor}' and id_tipo_produto = {idTipo} order by nome asc";
                    }
                    else
                    {
                        selectFromTable = $"select * from produto where nome like '%{nome}%' and descricao like '%{desc}%' and valor >= '{valorMaior}' and valor <= '{valorMenor}' order by nome asc";
                    }
                    Console.WriteLine(selectFromTable);

                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string np = reader.GetString(1);
                                string dp = reader.GetString(2);
                                double valor = reader.GetDouble(3);
                                int tp = reader.GetInt32(4);
                                tipoDeProduto t = new tipoDeProduto(tp,retornaTipoDeProdutoPorId(tp).Nome);
                                produto obj = new produto(id, np,dp,valor,t);
                                lista.Add(obj);
                            }
                        }
                    }
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
            }

            return lista;
        }





        public static List<tipoDeProduto> pesquisaTipoProduto(string nomeTipo)
        {
            List<tipoDeProduto> lista = new List<tipoDeProduto>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
                {


                    connection.Open();

                    string selectFromTable = $"select * from tipo_produto where nome like '%{nomeTipo}%' order by nome asc";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string nome = reader.GetString(1);
                                tipoDeProduto obj = new tipoDeProduto(id,nome);
                                lista.Add(obj);
                            }
                        }
                    }
                    connection.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");                
            }
            
            return lista;
        }




        public static bool removeRegistro(string tabela, int id)
        {
            if (tabela == "tipo_produto")
            {
                foreach(produto p in retornaProdutos())
                {
                    if (p.TipoDeProduto.Id == id)
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Não é possível excluir pois existe um Produto cadastrado com este Tipo.", "Atenção!", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }

            if (tabela == "produto")
            {
                foreach (ItemPedido i in retornaItensPedido())
                {
                    if (i.Produto.Id == id)
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Não é possível excluir pois existe um Pedido cadastrado com este Produto.", "Atenção!", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }

            if (tabela == "cliente")
            {
                foreach (Pedido p in retornaPedidos())
                {
                    if (p.Cliente.Id == id)
                    {
                        DialogResult dialog = new DialogResult();
                        dialog = MessageBox.Show("Não é possível excluir pois existe um Pedido cadastrado para este Cliente.", "Atenção!", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }


            //Removendo o registro da tabela
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string deleteFromTable = $"delete from {tabela} where id = {id}";
                    using (SQLiteCommand command = new SQLiteCommand(deleteFromTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    return false;
                }
            }
            return true;
        }

        public static List<Pedido> retornaPedidos()
        {
            List<Pedido> listaItens = new List<Pedido>();

            //Buscando no banco de dados, na tabela em questão, todos os registros
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = "select * from pedido order by data_criacao asc";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                int id = reader.GetInt32(0);
                                int id_cliente = reader.GetInt32(1);
                                double valor = reader.GetDouble(2);
                                Console.WriteLine(valor);
                                int status = reader.GetInt32(3);
                                
                                DateTime data_criacao = DateTime.Parse(reader.GetString(4));
                                DateTime data_entrega = DateTime.Parse(reader.GetString(5));
                                
                                Cliente cliente = retornaClientePorId(id_cliente);
                                Pedido pedido = new Pedido(cliente, retornaItemPedidoPorIdPedido(id));
                                pedido.Id = id;
                                pedido.Valor = valor;
                                pedido.Status = status;
                                pedido.Data_Criacao = data_criacao;
                                pedido.Data_Entrega = data_entrega;
                                listaItens.Add(pedido);

                                

                            }


                        }
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    Console.WriteLine("ERRO AO RETORNAR PEDIDOS");
                }
            }

            return listaItens;

        }









        public static Pedido retornaPedidoPorId(int id)
        {
            //Buscando no banco de dados, na tabela em questão, o registro especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from pedido where id = {id}";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int id_cliente = reader.GetInt32(1);
                                double valor = reader.GetDouble(2);
                                int status = reader.GetInt32(3);
                                DateTime data_criacao = DateTime.Parse(reader.GetString(4));
                                DateTime data_entrega = DateTime.Parse(reader.GetString(5));

                                Cliente cliente = retornaClientePorId(id_cliente);
                                Pedido pedido = new Pedido(cliente, retornaItemPedidoPorIdPedido(id));
                                pedido.Id = id;
                                pedido.Valor = valor;
                                pedido.Status = status;
                                pedido.Data_Criacao = data_criacao;
                                pedido.Data_Entrega = data_entrega;

                                return pedido;



                            }


                        }
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                    Console.WriteLine("ERRO AO RETORNAR PEDIDOS");
                }
            }

            return null;

        }











        public static List<produto> retornaProdutos()
        {
            List<produto> listaItens = new List<produto>();

            //Buscando no banco de dados, na tabela em questão, todos os registros
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = "select * from produto order by nome asc";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                
                                int id             = reader.GetInt32(0);
                                string nome        = reader.GetString(1);
                                string desc        = reader.GetString(2);
                                double valor       = reader.GetDouble(3);
                                int id_tipo_produto = reader.GetInt32(4);
                                
                                tipoDeProduto tipo = retornaTipoDeProdutoPorId(id_tipo_produto);
                                listaItens.Add(new produto(id, nome, desc, valor, tipo));

                                

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

            return listaItens;

        }

        public static tipoDeProduto retornaTipoDeProdutoPorNome(string nome)
        {

            //Buscando o Tipo de Produto especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    connection.Open();

                    string selectFromTable = $"select * from tipo_produto where nome='{nome}'";
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idTipo = reader.GetInt32(0);
                                string nomeTipo = reader.GetString(1);
                                return new tipoDeProduto(idTipo,nomeTipo);
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

            return null;

        }

        public static tipoDeProduto retornaTipoDeProdutoPorId(int id)
        {
            

            //Buscando o Tipo de Produto especificado
            using (SQLiteConnection connection = new SQLiteConnection(Program.connectionString))
            {
                try
                {
                    
                    connection.Open();

                    string selectFromTable = $"select * from tipo_produto where id={id}";
                    
                    using (SQLiteCommand command = new SQLiteCommand(selectFromTable, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                
                                int idTipo = reader.GetInt32(0);
                                
                                string nomeTipo = reader.GetString(1);
                                
                                return new tipoDeProduto(idTipo,nomeTipo);
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

            return null;

        }

        static void Main()
        {

            //Alimentando a lista de municípios
            preencheListaMunicipios();

            //Criando a tabela ITEM_PEDIDO
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string createTableSql = "CREATE TABLE IF NOT EXISTS item_pedido (\r\n    id           INTEGER     PRIMARY KEY AUTOINCREMENT NOT NULL,\r\n    id_pedido    INTEGER     NOT NULL REFERENCES pedido (id),\r\n    id_produto   INTEGER     NOT NULL REFERENCES produto (id),\r\n    qt           INTEGER     NOT NULL,\r\n    valor        REAL        NOT NULL\r\n);";
                    using (SQLiteCommand command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }

            

            //Criando a tabela TIPO_PRODUTO
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string createTableSql = "CREATE TABLE IF NOT EXISTS tipo_produto (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nome TEXT UNIQUE NOT NULL);";
                    using (SQLiteCommand command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }

            //Criando a tabela PRODUTO
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string createTableSql = "CREATE TABLE IF NOT EXISTS produto (\r\n    id        INTEGER PRIMARY KEY AUTOINCREMENT\r\n                      NOT NULL,\r\n    nome TEXT             NOT NULL\r\n                      UNIQUE,\r\n    descricao TEXT,\r\n    valor     REAL    NOT NULL,\r\nid_tipo_produto INTEGER REFERENCES tipo_produto (id) \r\n                      NOT NULL\r\n);";
                    using (SQLiteCommand command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }

            //Criando a tabela CLIENTE
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string createTableSql = "CREATE TABLE IF NOT EXISTS cliente (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, nome TEXT NOT NULL, estado TEXT NOT NULL, cidade TEXT NOT NULL, bairro TEXT NOT NULL, endereco TEXT NOT NULL, tel TEXT UNIQUE NOT NULL, email TEXT);";
                    using (SQLiteCommand command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }

            //Criando a tabela PEDIDO
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string createTableSql = "CREATE TABLE IF NOT EXISTS pedido (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, id_cliente INTEGER NOT NULL REFERENCES cliente (id), valor REAL NOT NULL, status INTEGER (1) NOT NULL DEFAULT (0), data_criacao TEXT NOT NULL, data_entrega TEXT);";
                    using (SQLiteCommand command = new SQLiteCommand(createTableSql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Dispose();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());



            
        }
    }
}
