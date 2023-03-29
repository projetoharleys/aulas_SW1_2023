namespace metodos_construtor;
class Produto
{
    public Produto(){
        this.Nome = "curupira";
        this.Preco = 10;
    }
    public Produto(string nome){
        this.Nome = nome;
    }
    public Produto(string nome, int desconto){
        this.Nome = nome;
        this.Preco = 10 - 10 * desconto/100;
    }
    private string? Nome {get;set;}
    private double Preco {get;set;}
    
    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Preço: " + this.Preco);
    }
    public void AlteraNome(string nome){
        this.Nome = nome;
    }
    public void AlteraPreco(double preco){
        this.Preco = preco;
    }
}