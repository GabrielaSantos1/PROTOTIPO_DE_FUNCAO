// usa o System, que tem as principais classes usadas
using System;
//cria a classe Programa
class Programa
{
    //cria uma variável float "estático" chamado 'a' com o valor inicial de 0
    static float a = 0;
    //cria uma variável float "estático" chamado 'b' com o valor inicial de 0
    static float b = 0;
    
    //cria uma função float "estático" chamado 'Soma'
    static float Soma()
    {
        //cria um float chamado 'resultado', onde o valor dele já é a soma das variáveis a e b
        float resultado = a + b;
        //retorna o valor da variável resultado
        return resultado;
    }

    //cria uma função float "estático" chamado 'Subt'
    static float Subt()
    {
        //cria um float chamado 'resultado', onde o valor dele já é a subtração das variáveis a e b
        float resultado = a - b;
        //retorna o valor da variável resultado
        return resultado;
    }

    //cria uma função float "estático" chamado 'Mult'
    static float Mult()
    {
        //cria um float chamado 'resultado', onde o valor dele já é a multiplicação das variáveis a e b
        float resultado = a * b;
        //retorna o valor da variável resultado
        return resultado;
    }

    //cria uma função float "estático" chamado 'Divi'
    static float Divi()
    {
        //cria um float chamado 'resultado', onde o valor dele já é a divisão das variáveis a e b
        float resultado = a / b;
        //retorna o valor da variável resultado
        return resultado;
    }

    //cria um principal para começar o programa
    static void Main()
    {
        //fala para o user
        Console.WriteLine("Digite 1 número positivo: ");
        //guarda a resposta do user como valor da variável a
        a = float.Parse(Console.ReadLine());

        //fala para o user
        Console.WriteLine("Digite mais 1 número positivo: ");
        //guarda a resposta do user como valor da variável a
        b = float.Parse(Console.ReadLine());

        //fala para o user o texto + o valor das seguintes funções:
        Console.WriteLine("Soma = " + Soma());
        Console.WriteLine("Subtração = " + Subt());
        Console.WriteLine("Multiplicação = " + Mult());
        Console.WriteLine("Divisão = " + Divi());
    }
}
