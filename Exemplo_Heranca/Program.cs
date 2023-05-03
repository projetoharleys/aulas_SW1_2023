namespace Exemplo_Heranca;
class Program
{
    static void Main(string[] args)
    {
        FuncionárioN1 n1 = new FuncionárioN1();
        FuncionárioN2 n2 = new FuncionárioN2();
        FuncionárioN3 n3 = new FuncionárioN3();

        n1.Nome = "Harley";
        n2.Nome = "Alves";
        n3.Nome = "Gustavo";

        Console.WriteLine("Nome: " + n1.Nome + " / Lucro: " + n1.lucro());
        Console.WriteLine("Nome: " + n2.Nome + " / Lucro: " + n2.lucro());
        Console.WriteLine("Nome: " + n3.Nome + " / Lucro: " + n3.lucro());
    }
}
