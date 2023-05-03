namespace Exemplo_Heranca;
class FuncionárioN3:Funcionário
{
    public override double lucro(){
         return base.lucro()*0.03;
    }
}