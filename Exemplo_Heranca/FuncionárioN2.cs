namespace Exemplo_Heranca;
class FuncionárioN2:Funcionário
{
    public override double lucro(){
        return base.lucro()*0.02;
    }
}