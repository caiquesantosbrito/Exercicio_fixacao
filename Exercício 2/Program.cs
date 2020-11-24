using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tipo de combustível você deseja? \n  A-álcool \n  G-gasolina");
            string tipo_combustivel = Console.ReadLine();
            Console.WriteLine("Quantos litros você quer abastecer?");
            float litros = float.Parse(Console.ReadLine());

            switch (tipo_combustivel)
            {
                case "A":
                    MostrarValorPago(AplicarDesconto(litros, 4.90f, 3, 5));
                    break;

                case "G":
                    MostrarValorPago(AplicarDesconto(litros, 5.30f, 4, 6));
                    break;

                default:
                    Console.WriteLine("Tipo de combustível inválido");
                    break;
            }
            
            float AplicarDesconto(float litros, float preco, float perc1, float perc2){

                if(litros <= 20){
                    return litros * (preco - (preco * perc1 / 100));
                }
                return litros * (preco - (preco * perc2 / 100));
            }

            void MostrarValorPago(float valorPago){
                Console.WriteLine("Valor total a ser pago é : "+valorPago);
            }
        }
    }
}
