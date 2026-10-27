using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Senac.ADS.PPFA.FinAntonio.Models
{
    public class Pessoa
    {
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
