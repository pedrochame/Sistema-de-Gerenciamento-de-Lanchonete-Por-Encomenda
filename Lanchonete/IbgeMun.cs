using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Regiao
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }

    public class UF
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public Regiao Regiao { get; set; }
    }

    public class Mesorregiao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public UF Uf { get; set; }
    }

    public class Microrregiao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Mesorregiao Mesorregiao { get; set; }
    }

    public class Municipio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Microrregiao Microrregiao { get; set; }

        public static List<Municipio> listarMunicipios()
        {
            string url = "https://servicodados.ibge.gov.br/api/v1/localidades/municipios\r\n";
            string json = (new System.Net.WebClient()).DownloadString(url);
            var mun = JsonConvert.DeserializeObject<List<Municipio>>(json);

            return mun;

        }

    }

}
