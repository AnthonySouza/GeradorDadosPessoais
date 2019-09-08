using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador
{
    [Serializable]
    public class Telefones
    {

        public class Telefone
        {

            string numero;

            public Telefone(string numero)
            {
                this.numero = numero;
            }

            public string Numero { get => numero; set => numero = value; }
        }

        public class Celular
        {

            string numero;

            public Celular(string numero)
            {
                this.numero = numero;
            }

            public string Numero { get => numero; set => numero = value; }

        }

    }
}
