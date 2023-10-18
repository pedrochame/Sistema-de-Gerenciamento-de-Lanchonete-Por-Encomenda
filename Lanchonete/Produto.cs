using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public tipoDeProduto TipoDeProduto { get; set; }

        public produto(int i,string n,string d,double v,tipoDeProduto t)
        {
            Id = i;
            Nome = n;
            Descricao = d;
            Valor = v;
            TipoDeProduto = t;
        }

    }
}
