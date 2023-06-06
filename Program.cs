using System;

class Program
{
    static float a = 0;
    static float b = 0;

    static float Soma()
    {
        float resultado = a + b;
        return resultado;
    }

    static float Subt()
    {
        float resultado = a - b;
        return resultado;
    }

    static float Mult()
    {
        float resultado = a * b;
        return resultado;
    }

    static float Divi()
    {
        float resultado = a / b;
        return resultado;
    }

    static void Main()
    {
        Console.WriteLine("Digite 1 número positivo: ");
        a = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite mais 1 número positivo: ");
        b = float.Parse(Console.ReadLine());

        Console.WriteLine("Soma = " + Soma());
        Console.WriteLine("Subtração = " + Subt());
        Console.WriteLine("Multiplicação = " + Mult());
        Console.WriteLine("Divisão = " + Divi());
    }
}
