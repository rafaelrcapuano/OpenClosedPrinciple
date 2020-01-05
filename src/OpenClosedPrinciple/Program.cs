using System;
using OpenClosedPrinciple.Models;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var analista = new Analista(1, "Rafael");                        
            var calculoDeSalario = new CalculoDeSalario(analista);
            var salario = calculoDeSalario.Calcular();

            Console.WriteLine($"O salário do funcionário é: {salario}");
            Console.ReadLine();
        }
    }
}