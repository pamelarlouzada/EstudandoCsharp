
// Aula 21
// - Retornos e parâmetros
// - Nível de acessibilidade (public/private..)
// - Sobrecarga de método
// - Override

Carro carro1 = new Carro("Carro 1");
Carro carro2 = new Carro("Carro 2");
Carro carro3 = new Carro("Carro 1");

Console.WriteLine(carro1);
Console.WriteLine(carro2);
Console.WriteLine(carro3.DigaSeuNome("Carro 3"));
class Carro
{
    private string nome;
    //atalho para fazer um construtor: ctor
    public Carro()
    {
    }
    public Carro(string Nome)
    {
        nome = Nome;
    }
    public string DigaSeuNome()
    {
        return nome;
    }
    public string DigaSeuNome(string Nome)
    {
        return Nome;
    }

    public DateTime DigaDataNascimento()
    {
        return DateTime.Now;
    }

    public override string ToString()
    {
        return string.Format("Eu sou o carro {0} e nasci em {1}", this.nome, this.DigaDataNascimento() );
    }
}
