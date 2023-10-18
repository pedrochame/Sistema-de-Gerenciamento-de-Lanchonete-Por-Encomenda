using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class tipoDeProduto
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public tipoDeProduto(int id, string nome){
            Nome = nome;
            Id = id;
        }
    }
}
