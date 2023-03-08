namespace aula;
class Exemplo
{
   //Atributos
    public string nome = "";
    public int idade = 0;
    public bool vacinado = false;
    
   //Metodos
   public void mostramsg(){
        Console.WriteLine("Oi 2°F");
   }
   public void mostranome(string texto){
        Console.WriteLine("Oi " + texto);
   }
   public string msg(){
        return "Olá, Tudo bem?";
   }
   public int somar(int a, int b){
        return a+b;
   }
    
}
