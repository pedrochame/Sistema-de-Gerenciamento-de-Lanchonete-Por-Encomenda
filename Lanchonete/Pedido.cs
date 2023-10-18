using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lanchonete
{
    public class ItemPedido{
        public int Id {  get; set; }
        public produto Produto { get; set; }
        public int Quantidade {  get; set; }
        public double Valor {  get; set; }

        public ItemPedido(produto p, int q, double v)
        {
            Produto = p;
            Quantidade = q;
            Valor = v;
        }

    }
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> ItensPedido { get; set; }
        public double Valor { get; set; }
        public int Status { get; set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime Data_Entrega { get; set; }

        public Pedido(Cliente c, List<ItemPedido> itens)
        {
            
            Cliente = c;
            Status = 0;
            Valor = 0;
            foreach (ItemPedido ip in itens){
                Valor += ip.Valor;
            }
            ItensPedido = itens;
            Data_Criacao = DateTime.UtcNow;
            Data_Entrega = Program.dataRepresentandoNull;
        }

    }
}
