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
            

            //Accedemos al objeto hanoi y a sus metodos 
            Hanoi objetoHanoi = new Hanoi();
            int resultado = objetoHanoi.iterativo(3, pilaInicial, pilaFinal, pilaAux);
            Console.WriteLine("NUMERO DE MOVIMIENTOS FINALES == " + resultado);
            if(resultado == 7)
            {
                Console.WriteLine("EL PROGRAMA FUNCIONA CORRECTAMENTE");
            }
            //objetoHanoi.mover_disco(pilaInicial, pilaAux);
            //objetoHanoi.mover_disco(pilaInicial, pilaFinal);
            // objetoHanoi.mover_disco(pilaInicial, pilaFinal);
             //Console.WriteLine("Top de Inicial" + pilaInicial.Top);
            //Console.WriteLine("Top de Aux" + pilaAux.Top);
            //Console.WriteLine("Top de Final" + pilaFinal.Top);
           // Console.WriteLine("Size de Inicio" + pilaInicial.Size);
            //Console.WriteLine("Size de AUx" + pilaAux.Size);
            //Console.WriteLine("Size de Final" + pilaFinal.Size);




            Console.ReadKey();
        }
    }
}
