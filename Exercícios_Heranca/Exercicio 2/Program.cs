namespace Exercicio_2;
class Program
{
    static void Main(string[] args)
    {
        ContatoPessoaFisica n1 = new ContatoPessoaFisica();
        ContatoPessoaJuridica n2 = new ContatoPessoaJuridica();

        n1.Nome = "Harley";
        n1.Email = "harleysantos2006@gmail.com";
        n1.Telefone = "971676701";
        n1.CPF = "429.800.798-36";
        n1.Idade = 16;

        n2.Nome = "Manoel";
        n2.Email = "mdsadv70@gmail.com";
        n2.Telefone = "999052712";
        n2.CNPJ = "224213423";
        n2.IE = "2123123123";
        n2.NomeDaEmpresa = "HarleyLanches";

        Console.WriteLine(n1.MostrarDados());
        Console.WriteLine();
        Console.WriteLine(n2.MostrarDados());
    }
}
