using Bogus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gerador
{
    public class Gerador
    {

        Faker fake;

        public Gerador()
        {

            fake = new Faker("pt_BR");

        }

        private string token = "08ee4c0ad551ba3d969fecc510092db0";
        private string url_sus = "http://geradorapp.com/api/v1/cns/generate?token=";

        public string GerarCPF()
        {

            int soma = 0;
            int resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;


        }

        public string GerarSUS()
        {

            var webRequest = WebRequest.CreateHttp(url_sus + token);
            webRequest.Method = "GET";

            using (var result = webRequest.GetResponse())
            {

                var sData = result.GetResponseStream();
                StreamReader reader = new StreamReader(sData);
                string oResponse = reader.ReadToEnd();

                var post = JObject.Parse(oResponse);

                if((int)post["status"] == 1)
                {

                    return (string)post["data"]["number"];

                }

            }

            return "0";

        }

        public DateTime GerarDataNascimento(int idade)
        {

            return fake.Date.Past(idade, DateTime.Now);

        }

        public int GerarIdade(int min, int max)
        {

            Random randNum = new Random();
            return randNum.Next(min, max);

        }

        public string GerarNomeCompleto(Genero genero)
        {

            switch (genero)
            {
                case Genero.Masculino:

                    return fake.Name.FullName(Bogus.DataSets.Name.Gender.Male) + " " + fake.Name.LastName(Bogus.DataSets.Name.Gender.Male);

                case Genero.Feminino:

                    return fake.Name.FullName(Bogus.DataSets.Name.Gender.Female) + " " + fake.Name.LastName(Bogus.DataSets.Name.Gender.Female);

            }

            return "";

        }

        public Genero GerarGenero()
        {

            Random randNum = new Random();

            switch (randNum.Next(-1, 1))
            {

                case (int)Genero.Masculino:

                    return Genero.Masculino;

                case (int)Genero.Feminino:

                    return Genero.Feminino;

            }

            return Genero.Feminino;

        }

        public TipoSanguineo GerarTipoSanguineo()
        {

            Random randNum = new Random();

            switch (randNum.Next(-1, 7))
            {

                case (int)TipoSanguineo.ABN:

                    return TipoSanguineo.ABN;

                case (int)TipoSanguineo.ABP:

                    return TipoSanguineo.ABP;

                case (int)TipoSanguineo.AN:

                    return TipoSanguineo.AN;

                case (int)TipoSanguineo.AP:

                    return TipoSanguineo.AP;

                case (int)TipoSanguineo.BN:

                    return TipoSanguineo.BN;

                case (int)TipoSanguineo.BP:

                    return TipoSanguineo.BP;

                case (int)TipoSanguineo.ON:

                    return TipoSanguineo.ON;

                case (int)TipoSanguineo.OP:

                    return TipoSanguineo.OP;

            }

            return TipoSanguineo.OP;

        }

        public string GerarTelefone(bool celular, bool ddd = true)
        {

            if (celular)
            {

                return fake.Phone.PhoneNumber("(##) 9####-####");

            }

            return fake.Phone.PhoneNumber("(##) ####-####");

        }

        public float GerarAltura()
        {

            int minCntVal = 45;
            int maxCntVal = 99;

            Random randNum = new Random();
            float result = float.Parse(string.Format("1,{0}", randNum.Next(minCntVal, maxCntVal)));

            if(result == 1.5f || result == 1.6f || result == 1.7f || result == 1.8f || result == 1.9f)
            {

                return float.Parse(result.ToString() + 4);

            }

            return result;

        }

        public int GerarPeso()
        {

            int min = 55;
            int max = 110;

            Random randNum = new Random();
            return randNum.Next(min, max);

        }

        public string GerarObservacao()
        {

            return fake.Lorem.Paragraphs(5, 10);

        }

        public Local GerarLocal()
        {
            
            Local local = new Local(fake.Address.Latitude(),
                fake.Address.Longitude(),
                fake.Address.County(),
                "[BAIRRO]",
                fake.Address.StateAbbr(),
                fake.Address.StreetName(),
                fake.Address.ZipCode("#####-###"),
                int.Parse(fake.Address.BuildingNumber()));

            return local;

        }

    }



}
