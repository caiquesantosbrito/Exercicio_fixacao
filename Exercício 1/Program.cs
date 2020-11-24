using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano atual: ");
            int ano_atual = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            Console.Write("Digite o ano em que nasceu: ");
            int ano_que_nasceu = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            int anos = ano_atual - ano_que_nasceu;

            if(anos >= 18){
                Console.WriteLine("Você pode votar!");
            }
            else{
                Console.WriteLine("Você ainda não tem idade para votar!");
            }
        }
    }
}
