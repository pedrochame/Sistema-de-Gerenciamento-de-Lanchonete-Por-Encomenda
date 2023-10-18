using Lanchonete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Bairro
    {
        public Municipio Cidade { get; set; }
        public string Nome { get; set; }

        public Bairro(string n, Municipio c)
        {
            Nome = n;
            Cidade = c;
        }

    }

}