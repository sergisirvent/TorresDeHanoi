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

            //Accedemos al objeto hanoi y a sus metodos 
            Hanoi objetoHanoi = new Hanoi();

            //--------------------------------------------------------------------------------------
            //Creamos los elementos para el recursivo
            //--------------------------------------------------------------------------------------
            //creamos las pilas
            Pila pilaInicial = new Pila();
            Pila pilaAux = new Pila();
            Pila pilaFinal = new Pila();

            //Creamos los discos con sus valores 
            Disco discoPequenyo = new Disco(1);
            
            Disco discoMediano = new Disco(2);
            
            Disco discoGrande = new Disco(3);
            
            
            //Los metemos en la pila inicial
            pilaInicial.push(discoGrande);
            pilaInicial.push(discoMediano);
            pilaInicial.push(discoPequenyo);
            

            
            Console.WriteLine("----------------------");
            Console.WriteLine("MOVIMIENTOS ITERATIVOS");
            Console.WriteLine("----------------------");

            int iterativoResultado = objetoHanoi.iterativo(3, pilaInicial, pilaFinal, pilaAux);
            Console.WriteLine("RESULTADO ITERATIVO --> " + iterativoResultado);
            
            if(iterativoResultado == 7)
            {
                Console.WriteLine("EL PROGRAMA PARECE QUE FUNCIONA ");
            }


            //--------------------------------------------------------------------------------------
            //Creamos los elementos para el recursivo
            //--------------------------------------------------------------------------------------
            //creamos las pilas
            Pila pilaRecursivaInicial = new Pila();
            Pila pilaRecursivaAux = new Pila();
            Pila pilaRecursivaFinal = new Pila();

            //Creamos los discos con sus valores 
            Disco discoRecursivoPequenyo = new Disco(1);

            Disco discoRecursivoMediano = new Disco(2);

            Disco discoRecursivoGrande = new Disco(3);


            //Los metemos en la pila inicial
            pilaRecursivaInicial.push(discoRecursivoGrande);
            pilaRecursivaInicial.push(discoRecursivoMediano);
            pilaRecursivaInicial.push(discoRecursivoPequenyo);
            Console.WriteLine("----------------------");
            Console.WriteLine("MOVIMIENTOS RECURSIVOS");
            Console.WriteLine("----------------------");

            int recursivoResultado = objetoHanoi.recursivo(3, pilaRecursivaInicial, pilaRecursivaFinal, pilaRecursivaAux);

            Console.WriteLine("RESULTADO RECURSIVO --> " + recursivoResultado);
            if (recursivoResultado == 7)
            {
                Console.WriteLine("EL PROGRAMA PARECE QUE FUNCIONA ");
            }


            //objetoHanoi.mover_disco(pilaInicial, pilaAux);
            //objetoHanoi.mover_disco(pilaInicial, pilaFinal);
            // objetoHanoi.mover_disco(pilaInicial, pilaFinal);





            Console.ReadKey();
        }
    }
}
