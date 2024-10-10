using System;
using System.Security.Cryptography;

namespace calculadora;
class Programa
    {
public static void Main(string[] args)
{
        
    Menu();
}

    public static void Menu()
    {
    
    Console.WriteLine("Escolha uma das funções");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Resto");
    Console.WriteLine("6 - Potencia");
    Console.WriteLine("0 - Sair");
    string  option = Console.ReadLine();

    
        switch (option)
        {
            case "1":
            Somar();
            break;
                
            case "2":
            Subtrair();
            break;
                
            case "3":
            Multiplicar();
            break;
                
            case "4":
            Dividir();
            break;

            case "5":
            Resto();
            break;

            case "6":
            Potencia();
            break;

            case "0":
            break;       

            default:
            Menu();
            break;
        }
    }


    
public static void Somar()
{
    double valor1;
    double valor2;
    Console.WriteLine("Digite o primeiro valor");
    valor1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");

    Console.ReadLine();
    Menu();
}
public static void Subtrair()
{
    double valor1;
    double valor2;
    Console.WriteLine("Digite o primeiro valor");
    valor1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");

    Console.ReadLine();
    Menu();
}
public static void Multiplicar()
{
    double valor1;
    double valor2;
    Console.WriteLine("Digite o primeiro valor");
    valor1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");

    Console.ReadLine();
    Menu();
}

public static void Dividir()
{
    double valor1;
    double valor2;
    Console.WriteLine("Digite o primeiro valor");
    valor1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine());
    if (valor2 != 0)
    Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
    else 
    Console.WriteLine("Não é possivel dividir por 0");

    Console.ReadLine();
    Menu();
}

public static void Resto()
{
    double valor1;
    double valor2;
    Console.WriteLine("Digite o primeiro valor");
    valor1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor");
    valor2 = Convert.ToDouble(Console.ReadLine());
    if (valor2 != 0)
    Console.WriteLine("O resto da divisão " + $"{valor1} / {valor2} = {valor1 % valor2}");
    else 
    Console.WriteLine("Não é possivel dividir por 0");

    Console.ReadLine();
    Menu();
}

public static void Potencia()
{
    double basePot;
    double expoente;
    Console.WriteLine("Digite o primeiro valor");
    basePot = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o segundo valor");
    expoente = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"{basePot} elevado a {expoente} = {Math.Pow(basePot , expoente)}");

    Console.ReadLine();
    Menu();
}
    }