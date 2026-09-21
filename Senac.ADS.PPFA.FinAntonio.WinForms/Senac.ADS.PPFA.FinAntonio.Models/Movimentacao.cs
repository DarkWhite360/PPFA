using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.FinAntonio.Models
{
    public class Movimentacao
    {
        public int Codigo { get; set; }
        public int CodigoConta { get; set; }
        public Conta? Conta { get; set; }
        public int CodigoPessoa {  get; set; }
        public Pessoa? Pessoa { get; set; }
        public string? Descricao { get; set; }
        public string?  DataMovimentacao { get; set; }
        public string? DataVencimento { get; set; }
        public string? DataPagamento { get; set; }
        public double ValorTotal { get; set; }
        public string? Status { get; set; } 
        public FormaPagamento? FormaPagamentoDescricao { get; set; }
    }
}
