
// Aula 33
// list


var nomes = new List<string> { "<nome>", "Ana", "Felipe", "Bia", "Camila" , "Amanda", "Davi"};
nomes.Add("Maria");
nomes.Remove("Ana");
nomes.RemoveAt(0);

nomes.Sort();
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

var index = nomes.IndexOf("Felipe");
Console.WriteLine($"O index do Felipe é {index}");

var index2 = nomes.IndexOf("Alberto");
Console.WriteLine($"O index do Alberto é {index2}. Isso indica que não tem Alberto na lista");





