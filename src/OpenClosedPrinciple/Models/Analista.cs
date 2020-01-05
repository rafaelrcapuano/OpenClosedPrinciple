namespace OpenClosedPrinciple.Models
{
    public class Analista : Funcionario
    {
        public Analista(int id, string nome) : base(id, nome) { }

        public override decimal CalcularSalario()
        {
            return 2000;
        }
    }
}