using System;
using System.Globalization;

class URI { 
    
    static void Main(string[] args)

    {
        string [] numeros = Console.ReadLine().Split(' ');

        int A = int.Parse(numeros[0]);
        int B = int.Parse(numeros[1]);
        int C = int.Parse(numeros[2]);

        int maiorAB = (A + B + Math.Abs(A - B)) /2;

        int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;


        Console.WriteLine(maiorABC + " eh o maior");

        Console.ReadLine();

    } 
}