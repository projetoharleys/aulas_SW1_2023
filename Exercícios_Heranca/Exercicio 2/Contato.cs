namespace Exercicio_2;
class Contato

{
    public string? Nome{get;set;}
    public string? Email{get;set;}
    public string? Telefone{get;set;}

    public virtual string MostrarDados(){
        string Tudo ="Nome: "+ this.Nome +"\nEmail: "+ this.Email +"\nTelefone: "+ this.Telefone;
        return Tudo;
    }

}