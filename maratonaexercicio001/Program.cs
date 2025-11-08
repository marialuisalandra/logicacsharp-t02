/* 1. Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
Descrição: Crie um script que declare uma variável para o nome de 
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá, 
João! Bem-vindo ao nosso site!".
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de 
uma string com aspas duplas.*/

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome}! Bem-vindo ao nosso site!");
Console.WriteLine("Olá " + nome + "! Bem-vindo ao nosso site!\n");

/*2. Conversão de Temperatura (Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
Descrição: Crie um script que CONVERTA uma temperatura em Celsius 
para Fahrenheit. A fórmula para conversão é: 
Dica: Declare uma CONSTANTE para armazenar o valor 9/5 e faça o 
cálculo com a variável fornecida. */

float celsius = 36f;
const float conversao = 9f / 5f;
Console.WriteLine($"Temperatura em Celsius: {celsius}");
float fahrenheit = celsius * conversao + 32f;
Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit}\n");

/*3.. Impressão de Dados do Usuário 
Objetivo: Concatenar e interpolar dados. 
Descrição: Crie um script que solicite ao usuário seu nome, idade e 
cidade e depois mostre uma mensagem com essas informações. 
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo". 
Dica: Use tanto concatenação quanto interpolação.*/

Console.WriteLine("Digite seu nome:");
string nomedousuario = Console.ReadLine();
Console.WriteLine("Digite sua idade:");
string idade = Console.ReadLine();
Console.WriteLine("Digite sua cidade:");
string cidade = Console.ReadLine();

Console.WriteLine($"Meu nome é {nomedousuario},tenho {idade} anos e moro em {cidade}");
Console.WriteLine("Meu nome é " + nomedousuario + ",tenho " + idade + " anos e moro em " + cidade);
Console.WriteLine();

/*4.Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis. 
Descrição: Crie um script que calcule o valor de uma parcela de um 
empréstimo, dado o valor total do empréstimo, a taxa de juros e o 
número de parcelas. Exemplo de fórmula:  
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o 
número de parcelas. */

Console.WriteLine("Digite o valor total do empréstimo: ");
double valorEmprestimo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a taxa de juros em porcentagem: (Ex: 5) ");
double taxaPorcento = Convert.ToDouble(Console.ReadLine());

double taxaJuros = 1 + (taxaPorcento / 100) ;
Console.WriteLine("Digite o número de parcelas:");
int parcelas = Convert.ToInt32(Console.ReadLine());

double valorParcela = (valorEmprestimo * taxaJuros) / parcelas;
Console.WriteLine($"Valor da Parcela: {valorParcela}");
Console.WriteLine();

/*5. Conversor de Moeda 
Objetivo: Trabalhar com variáveis, operadores e arredondamento. 
Descrição: Crie um script que converta uma quantia em reais para 
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor 
convertido com 2 casas decimais. 
Dica: Use round() para arredondar o valor para 2 casas decimais. */

Console.WriteLine("Digite o valor em reais: ");
double reais = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor em dólar - (Taxa de câmbio): ");
double dolar = Convert.ToDouble(Console.ReadLine());

double valorConvertido = reais / dolar;
//Arredondamento 2 casas decimais:
valorConvertido = Math.Round(valorConvertido, 2);
Console.WriteLine($"Valor convertido em dólares: {valorConvertido}");

/*6 . Calculadora de Desconto 
Objetivo: Cálculos matemáticos e uso de variáveis. 
Descrição: Crie um script que calcule o valor do desconto de um 
produto, dado o preço original e a porcentagem de desconto. Exemplo 
de fórmula:  
Dica: Use variáveis para armazenar o preço e a porcentagem do 
desconto e calcule o valor final.*/

Console.WriteLine("Quanto custa o produto?");
double valorProduto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Quanto de desconto você teve?");
double desconto = Convert.ToDouble(Console.ReadLine());

double valorDoDesconto = (valorProduto * desconto) / 100 ;
Console.WriteLine($"Valor do desconto: {valorDoDesconto}");

//Valor final após o desconto: 
double preco = valorProduto - valorDoDesconto;
Console.WriteLine($"O valor do produto com desconto é de: {preco} reais");
