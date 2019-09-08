using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador
{

    [Serializable]
    public class Filiacao
    {

        string nomePai;
        string nomeMae;

        public Filiacao(string nomePai, string nomeMae)
        {
            this.nomePai = nomePai;
            this.nomeMae = nomeMae;
        }

        public string NomePai { get => nomePai; set => nomePai = value; }
        public string NomeMae { get => nomeMae; set => nomeMae = value; }
    }
}
