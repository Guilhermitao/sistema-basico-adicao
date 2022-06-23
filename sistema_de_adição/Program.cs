using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_adição
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            string continuar;

            do
            {
                Console.WriteLine("Digite o primeiro numero");
                numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                numero2 = double.Parse(Console.ReadLine());
                Console.WriteLine("O total da soma é " + (numero1 + numero2));
                Console.WriteLine("Deseja fazer outra conta?\r\ns=sim,n=não.");
                continuar = Console.ReadLine();

                while (
                (continuar != "n" & continuar != "N") &
                (continuar != "s" & continuar != "S")
                )
                {
                    Console.WriteLine("informaçao incorreta,digite novamente.\r\nDeseja fazer outra conta?\r\ns=sim,n=não.");
                    continuar = Console.ReadLine();
                }/*while*/

            } while (continuar == "s" || continuar == "S");/*do-while*/
        }
    }
}
