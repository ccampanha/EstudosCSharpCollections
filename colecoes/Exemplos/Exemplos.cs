using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colecoes.Exemplos
{
    public class Exemplos
    {
        public void PercorrendoArray()
        {
            // PERCORRENDO ARRAY
            int[] arrayInteiros = new int[] {10,20,30};

            string texto = "30";

            arrayInteiros[2] = int.Parse(texto); 

            Console.WriteLine("Percorrendoo o array pelo For:");
            for (int i = 0; i < arrayInteiros.Length; i++) 
            {
                Console.WriteLine(arrayInteiros[i]);
            }

            Console.WriteLine("Percorrendoo o array pelo Foreach:");

            foreach (var item in arrayInteiros)
            {
                Console.WriteLine(item);
            }
        } 

        public void PercorrendoMatriz()
        {
            // ARRAY MULTIDIMENDSIONAL
            int[,] matriz = new int[4,2]
            {
                {8, 8},
                {10, 20},
                {50, 60},
                {90, 200}
            };

            //Percorrendo matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0} ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void OrdenaListaBolha(List<int> lista)
        {
            int itemLeft;
            int itemRight;
            bool changed;

            Console.WriteLine("Lista desordenada:");
            ImprimeLista(lista);

            do
            {
                changed = false;
                for (int i = 0; i < lista.Count -1; i++)
                {
                    itemLeft = lista[i];
                    itemRight = lista[i+1];
                    if (itemLeft > itemRight)
                    {
                        lista[i] = itemRight;
                        lista[i+1] = itemLeft;
                        changed = true;
                    }
                }   

            } while (changed);

            Console.WriteLine("Lista ordenada:");
            ImprimeLista(lista);
        }

        public void ImprimeLista(List<int> lista)
        {
            foreach (int i in lista)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }

    }        
}