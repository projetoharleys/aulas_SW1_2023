namespace Exercicio_1;
class Program
{
    static void Main(string[] args)
    {
       Cao n1 = new Cao();
       Gato n2 = new Gato();
       Homem n3 = new Homem();

       n1.Nome = "Cão";
       n2.Nome = "Gato";
       n3.Nome = "Homem";

       Console.WriteLine(n1.Nome + ": " + n1.fala());
       Console.WriteLine(n2.Nome + ": " + n2.fala());
       Console.WriteLine(n3.Nome + ": " + n3.fala());
    }
}
