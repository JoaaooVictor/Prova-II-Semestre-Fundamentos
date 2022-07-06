using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_II_Bimestre_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] matricula = new string[5];
            string[] nome = new string[5];
            double[] sal_a = new double[5];
            double[] salario = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("-------------------------");
                Console.Write("Olá, Digite sua matricula: ");
                matricula[i] = Console.ReadLine();
                Console.Write("Digite seu nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Digite seu salário atual: ");
                salario[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < 5; i++)
            {
                
                if (salario[i] >= 8000)
                {
                    sal_a[i] = salario[i] * 1.025;
                }
                else if (salario[i] < 8000)
                {
                    sal_a[i] = salario[i] * 1.035;
                }
                
                Console.WriteLine("--------------------------");
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Numero de Matricula: " + matricula[i]);
                Console.WriteLine("Esse é seu salário antigo: " + salario[i]);
                Console.WriteLine("Este é seu salário atual: " + sal_a[i]);
                
            }
                Console.ReadKey();
        }
    }
}
