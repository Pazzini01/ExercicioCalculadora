
using System;

Console.WriteLine("=== CALCULADORA ===");
Console.WriteLine("Versão 1.0");
Console.WriteLine("Bem-vindo à calculadora!");

Console.Write("Digite o primeiro número: ");

if (double.TryParse(Console.ReadLine(), out double numero1))
{
    Console.Write("Digite o segundo número: ");

    if (double.TryParse(Console.ReadLine(), out double numero2))
    {
        // Só chega aqui se os dois números forem válidos

        Console.WriteLine("Escolha a operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int operacao = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;
        bool operacaoValida = true;

        switch (operacao)
        {
            case 1:
                resultado = numero1 + numero2;
                break;

            case 2:
                resultado = numero1 - numero2;
                break;

            case 3:
                resultado = numero1 * numero2;
                break;

            case 4:
                if (numero2 == 0)
                {
                    operacaoValida = false;
                    Console.WriteLine("Não é possível dividir por 0");
                }
                else
                {
                    resultado = numero1 / numero2;
                }
                break;

            default:
                operacaoValida = false;
                Console.WriteLine("Operação inválida!");
                break;
        }

        if (operacaoValida == true)
        {
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
    else
    {
        Console.WriteLine("Digite apenas números!");
    }
}
else
{
    Console.WriteLine("Digite apenas números!");
}
