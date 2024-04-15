/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais. */

using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hour;
            double salary = 2D, valueHour;

            Console.Write("Digite o numero: ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de horas: ");
            hour = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da hora: ");
            valueHour = double.Parse(Console.ReadLine());

            salary = hour * valueHour;

            Console.WriteLine($"Numero = {number}");
            Console.WriteLine($"Salário = R$ {salary.ToString("F2")}");
        }
    }
}