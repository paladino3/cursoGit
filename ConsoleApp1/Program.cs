using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Controle de versao do Git hub");

            Console.WriteLine("FAZENDO UMA ALTERACAO NO CODIGO! ");


            //fazendo algumas alteracoes
            char a = 'n';

            while ( a !='s' ) {

                Console.Write("Digite um valor:");
                double valor = double.Parse(Console.ReadLine());

                Console.Write(valor = (valor >= 100) ? 1 : 0);

                Console.Write("\nDeseja sair? (S) ou (N): ");
                a = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Precione para sair");

            Console.ReadKey();
           }

    }
}
