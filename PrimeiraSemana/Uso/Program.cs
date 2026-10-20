namespace Uso;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        string name = "André Luiz";
        decimal number3 = 49.90m;
        bool teste = true;

        Console.WriteLine($"Você digitou {number} e {number2} e seu nome é {name}");
        Console.WriteLine($"Você digitou o decimal {number3} e declarou como {teste} a variável teste");
    }
}