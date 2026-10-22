namespace Operadores;

public class Program
{
    public static void Main()
    {
        int number1 = 15;
        int number2 = 20;

        int sum = number1 + number2;
        int multi = number1 * number2;
        int subtra = number2 - number1;
        int divi = number2 / number1;
        int resto = number2 % number1;

        Console.WriteLine($"{number1} + {number2} = " + sum);
        Console.WriteLine($"{number1} * {number2} = " + multi);
        Console.WriteLine($"{number2} - {number1} = " + subtra);
        Console.WriteLine($"{number2} / {number1} = " + divi);
        Console.WriteLine($"{number2} % {number1} = " + resto);

        Console.WriteLine("===== Operadores de Atribuição =====");

        // Iniciando a variável
        int x = 15;
        Console.WriteLine("\nValor Inicial da variável x é: " + x);

        // Operador de Atribuição Simples (=)
        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Valor de x: " + x);

        // Operador de Atribuição Composta (x++) Incremento
        x++; // é o mesmo que x = x + 1

        Console.WriteLine("\nAtribuição Composta Incremento (++)");
        Console.WriteLine("Valor de x atualizado: " + x);

        // Operador de Atribuição Composta (+=)
        x += 10; // é o mesmo que x = x + 10

        Console.WriteLine("\nAtribuição Composta (+=)");
        Console.WriteLine("Valor de x atualizado: " + x);

        // Operador de Atribuição Composta (-=)
        x -= 10; // é o mesmo que x = x -10

        Console.WriteLine("\nAtribuição Composta (-=)");
        Console.WriteLine("Valor de x atualizado: " + x);

        // Operador de Atribuição Composta (*=)
        x *= 10;

        Console.WriteLine("\nAtribuição Composta (*=)");
        Console.WriteLine("Valor de x atualizado: " + x);

        // Operador de Atribuição Composta (/=)
        x /= 10;

        Console.WriteLine("\nAtribuição Composta (/=)");
        Console.WriteLine("Valor de x atualizado: " + x);

        // Operador de Atribuição Composta (%=)
        x %= 10;

        Console.WriteLine("\nAtribuição Composta (%=)");
        Console.WriteLine("Valor de x atualizado: " + x);

        Console.WriteLine("====== Operadores Relacionais ===== \n");

        Console.WriteLine("Digite um número: ");
        int numa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro número: ");
        int numb = Convert.ToInt32(Console.ReadLine());

        // variáveis do tipo string pode ser declarada sem nenhum valor.
        //string resultado;

        // Operador de Igualdade (==)
        if (numa == numb)
        {
            Console.WriteLine($"{numa} == {numb}");
        }
        else
        {
            Console.WriteLine($"{numa} != {numb}");
        }

        // Operador de Diferença (!=)
        Console.WriteLine("====== Operador de Diferença ===== \n");
        if (numa != numb)
        {
            Console.WriteLine($"{numa} != {numb}");
        }
        else
        {
            Console.WriteLine($"{numa} == {numb}");
        }

        // Operador maior que (>)
        Console.WriteLine("===== Operador Maior Que ===== \n");
        if (numa > numb)
        {
            Console.WriteLine($"{numa} é maior que {numb}");
        }
        else
        {
            Console.WriteLine($"{numa} é menor que {numb}");
        }

        // Operador menor que
        Console.WriteLine("===== Operador Menor Que ===== \n");
        if (numa < numb)
        {
            Console.WriteLine($"{numa} é menor que {numb}");
        }
        else
        {
            Console.WriteLine($"{numa} não é maior que {numb}");
        }

        // Operador Maior ou Igual (>=)
        Console.WriteLine("===== Operador Maior ou Igual ===== \n");
        if (numa >= numb)
        {
            Console.WriteLine($"{numa} é maior ou igual a {numb}");
        }
        else
        {
            Console.WriteLine($"{numa} não é maior ou igual a {numb}");
        }

        // Operador Menor ou Igual (<=)
        Console.WriteLine("===== Operador Menor ou Igual ===== \n");
        if (numa <= numb)
        {
            Console.WriteLine($"{numa} é menor ou igual a {numb}");
        }
        else
        {
            Console.WriteLine($"{numa} não é menor ou igual a {numb}");
        }

        // Operadores Lógicos
        Console.WriteLine("===== Operadores Lógicos =====\n");

        bool isLogged = true;
        bool hasAdminAcces = false;

        Console.WriteLine("\nInformações do Usuário:");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAcces);
    }
}