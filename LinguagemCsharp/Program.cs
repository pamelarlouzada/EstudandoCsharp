
// Aula 25
// Manioulando strings

string saudacao = "          Olá mundo        ";
Console.WriteLine($"[{saudacao}]");

string ApararSaudacao = saudacao.Trim(); // TrimStart() e TrimEnd()
Console.WriteLine($"Função Trim(): [{ApararSaudacao}]");

Console.WriteLine($"Função Replace(): [{ApararSaudacao.Replace("Olá", "Oi")}]");
Console.WriteLine($"Função ToUpper(): [{ApararSaudacao.ToUpper()}]");
Console.WriteLine($"Função ToLower(): [{ApararSaudacao.ToLower()}]");
Console.WriteLine($"Função Length: [{ApararSaudacao.Length}]");
Console.WriteLine($"Função Contains(): [{ApararSaudacao.Contains("Olá")}]");
Console.WriteLine($"Função StartsWith(): [{ApararSaudacao.StartsWith("Olá")}]");
Console.WriteLine($"Função EndsWith(): [{ApararSaudacao.EndsWith("mundo")}]");
Console.WriteLine($"Função IndexOf(): [{ApararSaudacao.IndexOf("mundo")}]");


//string primeiroAmigo = "João";
//string segundoAmigo = "Maria";

//Console.WriteLine($"meus amigos são {primeiroAmigo} e {segundoAmigo}");

//Console.WriteLine($"O nome {primeiroAmigo} tem {primeiroAmigo.Length} letras");

