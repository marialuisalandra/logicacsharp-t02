
// If, else e elseif
// Programa para verificação de estoque

Console.WriteLine("Digite a quantidade de produtos do estoque:");

int quantidade = Convert.ToInt32(Console.ReadLine());
if (quantidade <= 5)
{
    Console.WriteLine("Alerta: baixo estoque. Por favor, reabasteça este produto");
}
else
        {
    Console.WriteLine("Estoque suficiente");
}

// Programa de desconto

Console.WriteLine("Digite o valor total da compra: R$");
double valorTotal = Convert.ToDouble(Console.ReadLine());

if (valorTotal > 200.00)
{
    double valorDesconto = valorTotal * 0.90; //90% do valor 
    Console.WriteLine("Desconto de 10% aplicado!");
    Console.WriteLine("O valor total da compra com desconto é R$:" + valorDesconto);
}
else
{
    Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10%");
    Console.WriteLine("Valor final da compra: R$" + valorTotal);
}

//Switch
// Programa que determine o dia da semana 

Console.WriteLine("Digite um número de 1 a 7 para saber o dia da semana: ");
int dias  = Convert.ToInt32(Console.ReadLine());
switch (dias)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda - feira");
        break;
    case 3:
        Console.WriteLine("Terça - feira");
        break;
    case 4:
        Console.WriteLine("Quarta - feira");
        break;
    case 5:
        Console.WriteLine("Quinta - feira");
        break;
    case 6:
        Console.WriteLine("Sexta - feira");
        break;
    case 7:
        Console.WriteLine("Sábado");
        break;
    default:
        Console.WriteLine("Número inválido. Digite um número entre 1 e 7.");
        break;
}

// Programa que calcule o preço final de um produto com base em um código de desconto

Console.WriteLine("Digite o preço do produto: R$:");
double preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o código (1 a 3) para aplicar o desconto: ");
int codigo = Convert.ToInt32(Console.ReadLine());

double precoFinal = preco;
switch (codigo)
{
    case 1:
        precoFinal = preco * 0.90;
        Console.WriteLine("Código 1: Você recebeu 10% de desconto!");
        break;
    case 2:
        precoFinal = preco * 0.80;
        Console.WriteLine("Código 2: Você recebeu 20% de desconto!");
        break;
    case 3:
        precoFinal = preco * 0.70;
        Console.WriteLine("Código 3: Você recebeu 30% de desconto!");
        break;
    default:
        Console.WriteLine("Código inválido. Nenhum desconto aplicado.");
        break;
}
Console.WriteLine("Preço final: R$" + precoFinal);


//For
// Programa de tabuada de multiplicação

int numero = 7;

   Console.WriteLine ($"Tabuada do {numero}:");
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

// Programa para calcular a média 
//Média simples = a soma dos valores dividida pela soma da quantidade de valores

int soma = 0;
Console.WriteLine("Digite 10 número inteiros");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Número {i}: ");
    int numeros = Convert.ToInt32(Console.ReadLine());
    soma += numeros; 
}
double media = (double)soma / 10;
Console.WriteLine($"\n A média dos números digitados é: {media}");

//While
//Programa de contador de visitantes 

int capacidade = 50;
int visitantes = 0;

Console.WriteLine("Contador de visitantes no museu");
while (visitantes < capacidade)
{
    visitantes++;
    Console.WriteLine($"Total de visitantes: {visitantes} ");
}
Console.WriteLine("\nCapacidade máxima atingida! O museu está cheio.");

//Programa de sistema de login

string senhaCorreta = "senha123";
int tentativas = 0;

while (tentativas < 3)
{
    Console.WriteLine("Digite sua senha: ");
    string senha = Console.ReadLine();
    if (senha == senhaCorreta)
    {
        Console.WriteLine("Login bem sucedido!");
        break;
    }
    else
    {
        tentativas++;
        Console.WriteLine("Senha incorreta");
    }
    if (tentativas == 3)
    {
        Console.WriteLine("\nConta bloqueada por excesso de tentativas!");
    }
}