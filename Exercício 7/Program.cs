using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[16];
            Console.WriteLine("Digite 15 números");
            
            for (int i = 1; i < 16; i++){
               Console.Write($"Número {i}: ");
               numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int a = 15; a > 0; a--){
                Console.Write($"{numeros[a]}, ");
            }
        }
    }
}
