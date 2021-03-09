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
            disco1.Valor = 1;

            Disco disco2 = new Disco();
            disco2.Valor = 2;

            Disco disco3 = new Disco();
            disco3.Valor = 3;

            pila.push(disco3);
            pila.push(disco2);
            pila.push(disco1);

            Pila pilaAux = new Pila();
            Pila pilaFinal = new Pila();
            Hanoi objetoHanoi = new Hanoi();
            int resultado = objetoHanoi.iterativo(3, pila, pilaAux, pilaFinal);

            //Console.WriteLine("Valor del disco extraido " +popDisco.Valor);
            // Keep the console window open in debug mode.
            Console.WriteLine("RESULTADO => " + resultado);
            Console.WriteLine("Press any key to exit.");
            
            Console.ReadKey();
        }
    }
}
