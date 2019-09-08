using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador
{

    [Serializable]
    public class Local
    {

        double latitude;
        double longitude;
        string cidade;
        string bairro;
        string uf;
        string rua;
        string cep;
        int numero;

        public Local(double latitude, double longitude, string cidade, string bairro, string uf, string rua, string cep, int numero)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.cidade = cidade;
            this.bairro = bairro;
            this.uf = uf;
            this.rua = rua;
            this.cep = cep;
            this.numero = numero;
        }

        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Cep { get => cep; set => cep = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
