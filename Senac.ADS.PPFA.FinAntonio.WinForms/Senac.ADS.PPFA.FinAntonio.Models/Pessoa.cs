using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Senac.ADS.PPFA.FinAntonio.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(int codigo, string nome, string cpf, string rg, string dataNascimento, string uf, string cidade, string enderecoRua, int enderecoNumero, string enderecoComplemento, string cep)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Uf = uf;
            Cidade = cidade;
            EnderecoRua = enderecoRua;
            EnderecoNumero = enderecoNumero;
            EnderecoComplemento = enderecoComplemento;
            Cep = cep;
        }

        public int Codigo { get; set;  }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
    
        public string? Rg { get; set; }

        public string? DataNascimento { get; set; }

        public string? Uf { get; set; }
        public string? Cidade { get; set; }
        public string? EnderecoRua { get; set; }
        public int EnderecoNumero { get; set; }
        public string? EnderecoComplemento { get; set; }
        public string? Cep { get; set; }

    }
}
