using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.FinAntonio.Models
{
    public class Conta
    {
            public int Codigo { get; set; }
            public int CodigoPessoa { get; set; }
            public Pessoa? Pessoa { get; set; }
            public string? Descricao { get; set; }
            public string? Agencia { get; set; }
            public string? ContaNumero { get; set; }
            public int DigitoVerificador { get; set; }
            public string? InstituicaoFinanceira { get; set; }
            public double SaldoInicial { get; set; }
            public string? GerenteConta { get; set; }
    }
}
