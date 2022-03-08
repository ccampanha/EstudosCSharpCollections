using colecoes.Exemplos;
using colecoes;

Exemplos exemplos = new Exemplos();

//arrayTeste.PercorrendoArray();
//arrayTeste.PercorrendoMatriz();
//List<int> lista = new List<int>() {19, 25, 47, 3, 9, 29};
//exemplos.OrdenaListaBolha(lista);

OperacoesArray op = new OperacoesArray();

int[] array = new int[5] {19, 25, 47, 3, 9};

Console.WriteLine("Array original: ");
op.ImprimirArray(array);

// Console.WriteLine("Array ordenado: ");
// op.Ordenar(array);
// op.ImprimirArray(array);

// // COPIAR ARRAY
// int[] arrayCopia = new int[10];

// op.Copiar(ref array, ref arrayCopia);
// Console.WriteLine("Array após a cópia: ");
// op.ImprimirArray(arrayCopia);

// // ENCONTRAR ELEMENTO ARRAY
// int valorProcurado = 9;
// bool existe = op.Existe(array, valorProcurado);

// if (existe)
// {
//     Console.WriteLine("Encontrei o valor {0}", valorProcurado);
// }
// else
// {
//     Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
// }

// //ENCONTRAR ELEMENTO ARRAY
// int valor = 2;
// bool todosMaiorQue = op.TodosMaiorQue(array, valor);

// if (todosMaiorQue)
// {
//     Console.WriteLine("Todos são maiores que {0}", valor);
// }
// else
// {
//     Console.WriteLine("Existem valores que não são maiores que {0}", valor);
// }

// //ENCONTRAR POSIÇÃO DE ELEMENTO NO ARRAY
// int valor = 19;
// int indice = op.ObterIndice(array, valor);

// if (indice > -1)
// {
//     Console.WriteLine("O indice do elemento {0} é: {1} ", valor, indice);
// }
// else
// {
//     Console.WriteLine("Valor {0} não existe no array.", valor);
// }

// // REDIMENSIONAR ARRAY
// int novoTamanho = 10;

// Console.WriteLine($"Capacidade atual do array: {array.Length}");

// op.RedimensionarArray(ref array, novoTamanho);
// Console.WriteLine($"Nova capacidade do array: {array.Length}");

// CONVERTER ARRAY EM STRING
string[] novoArray = op.ConverterParaArrayDeString(array);
Console.WriteLine("Cópia do array foi convertido a string: " + novoArray);





