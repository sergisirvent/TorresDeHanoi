using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get { return Elementos.Count; }}

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */

        public int Top { get; set; }

        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            
            Top = 0;
            Elementos = new List<Disco>();
            
        }

        public void push(Disco d)
        {
            Elementos.Add(d);
            
            Top = d.Valor;
            
            
        }

        public Disco pop()
        {

            Disco extraido = null;

            if(Size == 0)
            {
                Top = 0;
            }

            else
            {
                
                extraido = Elementos[Size - 1];
                Elementos.RemoveAt(Size - 1);
                if (Size == 0)
                {
                    Top = 0;
                }
                else
                {
                    Top = Elementos[Size - 1].Valor;
                    
                }
                
            }

            return extraido;

        }                

        public bool isEmpty()
        {
            if(Elementos.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}
