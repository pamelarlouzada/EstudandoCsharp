
// Aula 35
// lista de fibonacci

var listaFib = new List<int> { 1, 1 };
//Console.WriteLine(listaFib.Count);

for(int i = 0; i < 10; i++)
{
    var inicio1 = listaFib[listaFib.Count - 1];
    var inicio2 = listaFib[listaFib.Count - 2];

    var soma = inicio1 + inicio2;

    listaFib.Add(soma);
}

foreach (var e in listaFib)
{
    Console.WriteLine(e);
}




