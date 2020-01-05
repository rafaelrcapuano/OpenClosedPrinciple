namespace OpenClosedPrinciple.Models
{
    public class Diretor : Funcionario
    {
        public Diretor(int id, string nome) : base(id, nome) { }

        public override decimal CalcularSalario()
        {
            return 10000;
        }
    }
}