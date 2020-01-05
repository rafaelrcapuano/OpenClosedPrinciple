using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple.Models
{
    public abstract class Funcionario : ISalarioFuncionario
    {
        public Funcionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; }

        public string Nome { get; }

        public abstract decimal CalcularSalario();
    }
}