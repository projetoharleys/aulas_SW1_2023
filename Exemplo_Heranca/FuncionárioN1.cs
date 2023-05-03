namespace Exemplo_Heranca;
class FuncionárioN1:Funcionário
{
    public override double lucro(){
         return base.lucro()*0.01;
    }
}
