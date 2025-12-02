// Exercícios com array e foreach 
/*1. Faça um programa de listas de peças de carro 
Crie um programa que tenha um array de nomes de 10 peças de carro e imprima 
todos os nomes em uma lista. 

string[] pecasCarro = { "Motor", "Freio", "Suspensão", "Filtro", "Velas", "Bateria", "Pneus", "Faróis", "Volante", "Alternador" };
Console.WriteLine("Peças de carro: ");
for (int i = 0; i < pecasCarro.Length; i++)
{   
    Console.WriteLine($"{i + 1}. {pecasCarro[i]}");
    Thread.Sleep(1000);
}
*/

/*2. Faça um programa de desconto (?) 
Crie um programa que tenha um array associativo com dados de um gato que 
chegou no petshop, como chave e seu valor. Utilize o foreach para imprimir os 
nomes dos dados do gato. */



// Exercícios com Do while
/* 1. Faça um programa que pergunte se a pessoa quer continuar 
O programa pergunta se o usuário quer continuar digitando. 
Enquanto ele responder “s”, o programa repete. */

string continuar;

do
{
    Console.WriteLine("Deseja continuar digitando?(s/n)");
    continuar = Console.ReadLine();
} while (continuar == "s");

/*2. Faça um programa de tabuada do 3 
Crie um programa em C# que mostre a tabuada do número 3 de 1 a 10. 
Use a estrutura do...while e declare a variável do contador já na mesma linha em 
que ela é criada. 
O programa deve exibir o resultado da multiplicação a cada repetição. */

int numero = 3;
int j = 1;
Console.WriteLine($"Tabuada do {numero}");

do
{
    Console.WriteLine($"{numero} x {j} = {numero * j}");
    j++;
    Thread.Sleep(500);
} while (j <= 10);
