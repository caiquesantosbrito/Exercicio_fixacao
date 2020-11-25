using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número da tabuada que deseja ver:");
            int resposta = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------");

            int resultado;

            for (int contador = 10; contador > 0; contador--){
            
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
                System.Threading.Thread.Sleep(700);
            }
        }
    }
}
