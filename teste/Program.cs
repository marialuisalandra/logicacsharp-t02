int a = 15;
int b = 5;
int resultado = 0;

while (a > 0)
{
    a -= b;
    resultado++;
}

Console.WriteLine("O resultado é: " + resultado);