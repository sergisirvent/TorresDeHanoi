﻿using System;
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
            return 0;
        }

    }
}
