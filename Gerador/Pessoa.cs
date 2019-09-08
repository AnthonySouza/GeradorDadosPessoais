using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador
{

    [Serializable]
    public class Pessoa
    {

        int id;
        string nomeCompleto;
        int cpf;
        int sus;
        int idade;
        int rg;
        Filiacao filiacao;
        Genero genero;
        DateTime dataNascimento;
        Local local;
        TipoSanguineo tipoSanguineo;
        Telefones telefones;
        float altura;
        int peso;
        string observacao;

        public Pessoa(int id, string nomeCompleto, int cpf, int sus, int idade, int rg, Filiacao filiacao, Genero genero, DateTime dataNascimento, Local local, TipoSanguineo tipoSanguineo, Telefones telefones, float altura, int peso, string observacao)
        {
            this.id = id;
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
            this.sus = sus;
            this.idade = idade;
            this.rg = rg;
            this.filiacao = filiacao;
            this.genero = genero;
            this.dataNascimento = dataNascimento;
            this.local = local;
            this.tipoSanguineo = tipoSanguineo;
            this.telefones = telefones;
            this.altura = altura;
            this.peso = peso;
            this.observacao = observacao;
        }

        public int Id { get => id; set => id = value; }
        public string NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public int Sus { get => sus; set => sus = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Rg { get => rg; set => rg = value; }
        public Filiacao Filiacao { get => filiacao; set => filiacao = value; }
        public Genero Genero { get => genero; set => genero = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public Local Local { get => local; set => local = value; }
        public TipoSanguineo TipoSanguineo { get => tipoSanguineo; set => tipoSanguineo = value; }
        public Telefones Telefones { get => telefones; set => telefones = value; }
        public float Altura { get => altura; set => altura = value; }
        public int Peso { get => peso; set => peso = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
