using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente(int i,string n,string e,string c,string b,string end,string tel,string email)
        {
            Id = i;
            Nome = n;
            Estado = e;
            Cidade = c;
            Bairro = b;
            Endereco = end;
            Telefone = tel;
            Email = email;
        }

    }
}
