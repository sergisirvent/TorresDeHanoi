using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
            //por si hay una pila vacia
            if (a.isEmpty() && b.Top != 0)
            {
                Disco discoMovido = b.pop();
                a.push(discoMovido);

                //Console.WriteLine("discoMovido" + discoMovido.Valor);
                Console.WriteLine("MOVIMIENTO -->Disco movido con valor --> " + discoMovido.Valor);



            }
            else if (!a.isEmpty() && b.isEmpty())
            {
                Disco discoMovido = a.pop();
                b.push(discoMovido);
                Console.WriteLine("MOVIMIENTO -->Disco movido con valor --> " + discoMovido.Valor);

            }
            else 
            {
                //por si estan las dos llenas se realiza una comparación
                int inicio = a.Top;
                int final = b.Top;
                if (inicio > final)
                {
                    //de b a a
                    Disco discoMovido = b.pop();
                    a.push(discoMovido);
                   Console.WriteLine("MOVIMIENTO -->Disco movido con valor --> " + discoMovido.Valor);
                }
                else
                {
                    //de a a b
                    Disco discoMovido = a.pop();
                    b.push(discoMovido);
                    Console.WriteLine("MOVIMIENTO -->Disco movido con valor --> " + discoMovido.Valor);
                }
            }
            


        }

        
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int numero_movimientos = 0;
            bool noSolucionado = true;

            if(n%2 != 0)
            {
                while (noSolucionado) 
                {
                    //Console.WriteLine("Inicio bucle   ");
                    //Console.WriteLine("Size fin-->  " +fin.Size);
                   // Console.WriteLine(noSolucionado);
                    mover_disco(ini,fin);
                    numero_movimientos++;
                    
                    if(fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }
                    mover_disco(ini, aux);
                    numero_movimientos++;
                    if(fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }
                    mover_disco(aux, fin);
                    numero_movimientos++;
                    if(fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }
                    

                }//fin mientras

            }//fin si 

            if (n % 2 == 0)
            {
                while (noSolucionado)
                {
                    mover_disco(ini, aux);
                    numero_movimientos++;
                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }
                    mover_disco(ini, fin);
                    numero_movimientos++;
                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }
                    mover_disco(aux, fin);
                    numero_movimientos++;
                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }


                }//fin mientras

            }//fin si

            
            return numero_movimientos;
        }

        public int movimientosRecursivos;
        public int recursivo(int n , Pila ini , Pila fin , Pila aux)
        {
            

            if (n == 1)
            {
                mover_disco(ini, fin);
                incrementar_movimientos();
            }
            else
            {

                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin);
                incrementar_movimientos();
                recursivo(n - 1, aux, fin, ini);

            }
            return movimientosRecursivos;
        }

        public int incrementar_movimientos()
        {
            return movimientosRecursivos++;
        }
        

    }
}
