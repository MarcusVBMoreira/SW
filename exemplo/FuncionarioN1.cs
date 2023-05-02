namespace exemplo;
class FuncionarioN1:Funcionario
{
    public override double Lucro(){
        return base.Lucro()*0.01;
    }
}