using System;

namespace Exercicio2__07_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double AttSal;
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Informe o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário bruto: ");
            funcionario.SalarioB = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + funcionario.Nome + "R$" + funcionario.SalarioL().ToString());

            Console.WriteLine("Informe a procentagem para o aumento: ");
            AttSal = double.Parse(Console.ReadLine());
            funcionario.AumentoSalario(AttSal);

            Console.WriteLine("Dados atualizados: " + funcionario.Nome + ", R$" + funcionario.SalarioB.ToString()); 



        } 
    }
}
