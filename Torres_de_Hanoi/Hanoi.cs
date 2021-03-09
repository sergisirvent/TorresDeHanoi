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
            int inicio = a.Top;
            int final = b.Top;
            if (inicio < final)
            {
                
                a.push(b.pop());
                


            }else if (inicio < final)
            {
                b.push(a.pop());
                
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
                    mover_disco(ini, fin);
                    numero_movimientos++;
                    if (fin.Size == n)
                    {
                        noSolucionado = false;
                        break;
                    }
                    mover_disco(ini, aux);
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
        

    }
}
