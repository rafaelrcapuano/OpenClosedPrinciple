namespace OpenClosedPrinciple.Models
{
    public class Coordenador : Funcionario
    {
        public Coordenador(int id, string nome) : base(id, nome) { }

        public override decimal CalcularSalario()
        {
            return 5000;
        }
    }
}

