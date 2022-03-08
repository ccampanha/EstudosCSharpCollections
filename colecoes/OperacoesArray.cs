using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace colecoes
{
    public class OperacoesArray
    {
        public void Ordenar(int[] array )
        {
            Array.Sort(array);

        }

        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(",", array);
            Console.WriteLine(linha);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array,valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayDeString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

    }
}