int primeiroNumero = 0, segundoNumero = 1, proximoNumero = 0;
bool detectado = false;

Console.WriteLine("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

while (proximoNumero <= n)
{
    if(proximoNumero == n)
    {
        Console.WriteLine($"o número {n} pertence à sequência de Fibonacci");
        detectado = true;
        break;
    }
    else
    {
        proximoNumero = primeiroNumero + segundoNumero;
        primeiroNumero = segundoNumero;
        segundoNumero = proximoNumero;
    }

}

if (!(detectado))
{
    Console.WriteLine($"O número {n} não pertence a sequência de Fibonacci");
}