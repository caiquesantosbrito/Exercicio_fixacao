using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string[] nomes = new string[11];

            Console.WriteLine("Digite 10 nomes para cadastro");

            for(var i = 1; i < 11; i++){
                Console.Write("Nome " + i + ": ");
                nomes[i] = Console.ReadLine();
            }

            while(repeat == true){
                Console.WriteLine("------------------------------");
                Console.WriteLine("Digite um nome para busca:");
                Console.Write("Nome: ");
                string nome_cadastrado = Console.ReadLine();

                foreach(var nome in nomes){
                    if(nome == nome_cadastrado){
                        Console.WriteLine($"O nome {nome_cadastrado} está cadastrado.");
                        Console.WriteLine("------------------------------");
                        break;
                    }
                }
                Console.WriteLine("Deseja repetir?");
                string repeat1 = Console.ReadLine().ToLower();
                if(repeat1 != "sim"){
                    Console.WriteLine("Obrigado por usar nosso sistema");
                    break;
                }else{}    
            }
        }
    }
}
