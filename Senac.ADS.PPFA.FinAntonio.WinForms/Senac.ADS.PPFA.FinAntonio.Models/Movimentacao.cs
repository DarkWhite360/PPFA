using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.FinAntonio.Models
{
    public class Movimentacao
    {
        public Movimentacao(int codigo, Pessoa nomePessoa, string descricao, string dataMovimentacao, string dataVencimento, string dataPagamento, double valorTotal, string status, Conta contaMovimentacao, FormaPagamento formaPagamentoDescricao)
        {
            Codigo = codigo;
            NomePessoa = nomePessoa;
            Descricao = descricao;
            DataMovimentacao = dataMovimentacao;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            ValorTotal = valorTotal;
            Status = status;
            ContaMovimentacao = contaMovimentacao;
            FormaPagamentoDescricao = formaPagamentoDescricao;

        }

        public int Codigo { get; set; }
        public Pessoa? NomePessoa { get; set; }
        public string? Descricao { get; set; }
        public string?  DataMovimentacao { get; set; }
        public string? DataVencimento { get; set; }
        public string? DataPagamento { get; set; }
        public double ValorTotal { get; set; }
        public string? Status { get; set; }
        public Conta? ContaMovimentacao { get; set; }
        public FormaPagamento? FormaPagamentoDescricao { get; set; }
    }
}
