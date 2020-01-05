using OpenClosedPrinciple.Interfaces;

namespace OpenClosedPrinciple
{
    public class CalculoDeSalario
    {
        private readonly ISalarioFuncionario _salarioFuncionario;

        //Preciso de alguém que saiba calcular o salário por mim (alguma classe que implementa ISalarioFuncionario)
        //Injeção de dependência!		
        public CalculoDeSalario(ISalarioFuncionario salarioFuncionario)
        {
            _salarioFuncionario = salarioFuncionario;
        }

        //Não sei como, mas alguma classe que implementa ISalarioFuncionario vai calcular por mim
        public decimal Calcular()
        {
            return _salarioFuncionario.CalcularSalario();
        }
    }
}