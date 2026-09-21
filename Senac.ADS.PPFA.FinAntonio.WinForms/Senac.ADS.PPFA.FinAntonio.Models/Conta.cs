using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.FinAntonio.Models
{
    public class Conta
    {
        public Conta()
        {
     
        }

        public Conta(int codigo, string descricao, string agencia, string contaNumero, int digitoVerificador, string instituicaoFinanceira, double saldoInicial, string gerenteConta)
        {
            Codigo = codigo;
            Descricao = descricao;
            Agencia = agencia;
            ContaNumero = contaNumero;
            DigitoVerificador = digitoVerificador;
            InstituicaoFinanceira = instituicaoFinanceira;
            SaldoInicial = saldoInicial;
            GerenteConta = gerenteConta;
        }

        public int Codigo { get; set; }

        public string? Descricao { get; set; }
        public string? Agencia { get; set; }
        public string? ContaNumero { get; set; }
        public int DigitoVerificador { get; set; }
        public string? InstituicaoFinanceira { get; set; }
        public double SaldoInicial { get; set; }
        public string? GerenteConta { get; set; }
    }
}
