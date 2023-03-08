using System;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("### MENU CALCULADORA ###");
                Console.WriteLine("\n[1]- ADIÇÃO");
                Console.WriteLine("[2]- SUBTRAÇÃO");
                Console.WriteLine("[3]- MULTIPLICAÇÃO");
                Console.WriteLine("[4]- DIVISÃO");
                Console.WriteLine("[S]- SAIR");
                Console.Write("\n=> ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\nDigite o primeiro número: ");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        double num2 = double.Parse(Console.ReadLine());
                        double resultado = num1 + num2;
                        Console.WriteLine($"\nO resultado da adição é: {resultado}\n");
                        break;

                    case "2":
                        Console.Write("\nDigite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 - num2;
                        Console.WriteLine($"\nO resultado da subtração é: {resultado}\n");
                        break;

                    case "3":
                        Console.Write("\nDigite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = num1 * num2;
                        Console.WriteLine($"\nO resultado da multiplicação é: {resultado}\n");
                        break;

                    case "4":
                        Console.Write("\nDigite o primeiro número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        num2 = double.Parse(Console.ReadLine());
                        if (num2 == 0)
                        {
                            Console.WriteLine("\nErro: divisão por zero!\n");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nO resultado da divisão é: {resultado}\n");
                        }
                        break;

                    case "S":
                    case "s":
                        Console.WriteLine("\nEncerrando a calculadora...");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida! Tente novamente.\n");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();

            } while (opcao.ToUpper() != "S");



            /*              
            Requisito 01
            //Nossa calculadora deve ter a possibilidade de somar dois números
            Requisito 02
            //Nossa calculadora deve ter a possibilidade fazer várias operações de soma
            Requisito 03
            //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
            Requisito 04
            //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
            Requisito 05
            //Nossa calculadora deve realizar as operações com "0"
            Requisito 06
            //Nossa calculadora deve validar a opções do menu 
            Requisito 07
            //Nossa calculadora deve realizar as operações com números com duas casas decimais
            */


        }
    }
}