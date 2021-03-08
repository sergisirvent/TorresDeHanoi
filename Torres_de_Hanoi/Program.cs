using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();

            Disco disco1 = new Disco();
            disco1.Valor = 5;

            Disco disco2 = new Disco();
            disco2.Valor = 10;

            Disco disco3 = new Disco();
            disco3.Valor = 3;

            Disco disco4 = new Disco();
            disco4.Valor = 2;

            pila.push(disco1);
            pila.push(disco2);
            pila.push(disco3);
            //pila.push(disco4);

           // Console.WriteLine("Elementos finales " + pila.isEmpty() + Environment.NewLine);
            foreach(Disco d in pila.Elementos)
            {
                Console.WriteLine(d.Valor);
            }
            Disco popDisco = pila.pop();
            Console.WriteLine("Valor del disco extraido " +popDisco.Valor);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}
