using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis

            double diaria, adultos, criancas, vlr_criancas, vlr_adultos, vlr_familia, dias, vlr_total, parcelas, vlr_parcelas;

             //entradas

            Console.WriteLine("Informe o valor da diaria do hotel: ");
            diaria = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de adultos: ");
            adultos = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de crianças: ");
            criancas = double.Parse(Console.ReadLine());

            //processamento 1

            vlr_adultos = diaria * adultos;
            vlr_criancas = (diaria * criancas) / 2;
            vlr_familia = vlr_criancas + vlr_adultos;

            Console.WriteLine("O valor por dia da familia sera de: " + vlr_familia.ToString("C"));

            //entradas 2

            Console.WriteLine("Informe o numero de dias hospedagem: ");
            dias = double.Parse(Console.ReadLine());

            //processamento 2

            vlr_total = dias * vlr_familia;

            Console.WriteLine("O valor total da hospedagem é : " + vlr_total.ToString("C"));

            //entradas 3

            Console.WriteLine("Informe o numero de parcelas: ");
            parcelas = double.Parse(Console.ReadLine());

            //processamento 3

            vlr_parcelas = vlr_total / parcelas;

            Console.WriteLine("O valor por parcelas é: " + vlr_parcelas.ToString("C"));
          

            Console.ReadKey();

        }
    }
}
