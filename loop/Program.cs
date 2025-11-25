<<<<<<< HEAD
﻿//loop for
for(int i = 1; i <= 10; i++)
=======
﻿// Loop for
for (int i =1;i <= 10; i++)
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
{
    Console.WriteLine(i);
}

<<<<<<< HEAD

int soma  = 0;
for (int i = 1;  i <= 100; i++)
=======
int soma = 0;
for (int i = 1; i <=100; i++)
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
{
    soma += i; //Soma o valor de i à variável soma, exemplo: 1+2+3+4...+99+100
}

Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);

<<<<<<< HEAD
//Loop infinito
/*
for (;;)
{
    Console.WriteLine("Este é um loop infinito!");
=======
//Loop infinito 
/*
 for (;;)
{
Console.WriteLine("Este é um loop infinito!");
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
}
*/


//Loop While (enquanto)
<<<<<<< HEAD

int contador = 1;

while(contador <= 5)
{
    Console.WriteLine(contador);
    contador++;  //incrementa o contador
}



//Loop do while (faça enquanto) 
=======
int contador = 1;
while(contador <= 5)
{
    Console.WriteLine(contador);
    contador++; //incrementa o contador
}

//Loop "Do while" (faça, enquanto)
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++; //incrementa o contador
} while (novocontador <= 5);


//Loop infinito while
/*
<<<<<<< HEAD
while (true)
{
    Console.WriteLine("Este é um loop infinito!");
=======
 * while (true)
 {
Console.WriteLine("Este é um loop infinito!");
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
}
*/


//Laço foreach
<<<<<<< HEAD

=======
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
//Uma lista de strings
List<string> nomes = new List<string> { "Ana", "Carlos", "João", "Maria" };

//Usando o foreach para percorrer a lista
foreach (string nome in nomes)
{
<<<<<<< HEAD
    Console.WriteLine(nome); //imprime cada nome exibindo na tela 
}


//Um vetor de números inteiros 
int[] numeros = { 1, 2, 3, 4, 5 };

//Usando o foreach para percorrer o vetor 
=======
    Console.WriteLine(nome); //imprime cada nome exibindo na tela
}

//Um vetor de números inteiros 
int[] numeros = { 1, 2, 3, 4, 5 };

//Usando o foreach para percorrer o vetor
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
foreach (int numero in numeros)
{
    Console.WriteLine(numero); //imprime cada número exibido na tela
}
<<<<<<< HEAD

=======
>>>>>>> 9f47b86d985fb4c935b3198a7238e8bdfa592a04
