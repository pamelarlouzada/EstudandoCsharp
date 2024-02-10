

using LinguagemCsharp;

ContaBanco contaB = new ContaBanco("Pâmela", 10000);
Console.WriteLine($"A conta {contaB.Numero} de {contaB.Titular} foi criada com saldo de {contaB.Saldo}");

contaB.Depositar(800, DateTime.Now, "Recebi um pgto");
Console.WriteLine($"A conta {contaB.Numero} de {contaB.Titular} está com saldo de {contaB.Saldo}");

try
{
    contaB.Sacar(10000, DateTime.Now, "Fiz um pgto");
    Console.WriteLine($"A conta {contaB.Numero} de {contaB.Titular} está com saldo de {contaB.Saldo}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message );
}
catch (Exception ex)
{
    Console.WriteLine($"Operação não realizada");
}

Console.WriteLine(contaB.PegarMovimentacoes());




