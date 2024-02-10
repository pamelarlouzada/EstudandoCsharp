using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemCsharp;

internal class ContaBanco
{
    public string Numero { get; }
    public string Titular { get; set; }
    public decimal Saldo 
    {
        get
        {
            decimal saldo = 0;
            foreach (var item in todasTransacoes) 
            {
                saldo += item.Valor;
            }
            return saldo;
        }
    }

    public static int numeroConta = 1234567890;

    private List<Transacao> todasTransacoes = new List<Transacao>();

    public ContaBanco(string nome, decimal valor)
    {
        this.Titular = nome;

        numeroConta++;
        this.Numero = numeroConta.ToString();
        Depositar(valor, DateTime.Now, "Saldo inicial");
    }

    public void Depositar(decimal valor, DateTime data, string obs)
    {
        if(valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos depósito de valor 0 ou negativo");
        }
        Transacao trans = new Transacao(valor, data, obs);
        todasTransacoes.Add(trans);
    }
    public void Sacar(decimal valor, DateTime data, string obs)
    {
        if (valor <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(valor), "Não aceitamos saque de valor 0 ou negativo");
        }
        if(Saldo - valor < 0)
        {
            throw new InvalidOperationException("Saldo insuficiente");
        }
        Transacao trans = new Transacao(-valor, data, obs);
        todasTransacoes.Add(trans);

    }

    public string PegarMovimentacoes()
    {
        var movimentacoes = new StringBuilder();
        movimentacoes.AppendLine("Data\t\tVlor\tObs");

        foreach(var item in todasTransacoes)
        {
            movimentacoes.AppendLine($"{item.Data.ToShortDateString()}\t{item.Valor}\t{item.Obs}");
        }

        return movimentacoes.ToString();
    }
}
