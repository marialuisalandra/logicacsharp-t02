/*Qual a diferença entre lista e vetores?
Na lista pode ter vários tipos de dados, enquanto no vetor tem um tamanho fixo e os dados tem que ser homogêneos
O vetor é um espaço na memória que armazena o mesmo tipo de dados

Posição / index / índice [i]
Vetor - Array 
vetor [colchetes]
Length = comprimento [0] [1] [2] [3]
i++ (exibe na tela e soma mais uma posição do comprimento)
*/


//Declaração de dois vetores
int[] numeros = { 7, 2, 3, 34, 5 }; //Vetor de inteiros 
string[] nomes = { "Ana", "João", "Maria", "Carlos" }; //Vetor de strings

//Exibindo os elementos do vetor de números com loop for

Console.WriteLine("Vetor de números (usando for):");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Exibindo os elementos do vetor de nomes com loop foreach

Console.WriteLine("\nVetor de nomes (usando foreach):");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}
/*
//Ordenação do vetor de números 
Array.Sort(numeros);
Console.WriteLine("\nVetor de números ordenado:");
foreach (var n in numeros)
{
    Console.WriteLine(n);
}

*/

//Pesquisa Sequencial é uma função 

int valorProcurado = 5;
int posicaoSequencial = PesquisaSequencial(numeros, valorProcurado);

if(posicaoSequencial != -1)
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorProcurado} encontrado na posição {posicaoSequencial}");
}
else
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorProcurado} não encontrado.");
}

static int PesquisaSequencial(int[] vetor, int valor)
{
    for (int i = 0; i <vetor.Length; i++)
    {
        if (vetor[i] == valor)
            return i; //Retorna o índice do valor encontrado
    }
    return -1; //Retorna -1 se não encontrar 
}