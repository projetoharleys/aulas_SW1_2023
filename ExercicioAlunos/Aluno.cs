namespace ExercicioAlunos;
class Aluno
{
    public string nome="";
    public double nota1, nota2;

    //media-> retorna um doble (por exemplo um numero como 8.3)
    public double obterMedia(){
        double media = (nota1+nota2)/2;
        return media;
    }
    //situação-> retorna uma string ("aprovado" ou "reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="APROVADO";
        }else{
            situacao="REPROVADO";
        }
        return situacao;
    }
    //mensagem-> não retorna nada. Só mostra na tela os detalhes (nome, media e siruação )     
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome + " está " + resultadoSituacao + " com média: " + mediaCalculada);
    }
}