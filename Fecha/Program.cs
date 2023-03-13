
using System.ComponentModel;

int NumPar; 
int NumNon;



    Console.WriteLine("Ingresa el valor maximo que quieres que imprima en numeros nones  ");
    NumNon = int.Parse(Console.ReadLine());

    for (int i = 1; i < NumNon; i += 2)
    {
        Console.WriteLine(i);
    }



    Console.WriteLine("Ingresa el valor maximo al cual quieres que imprima en pares ");
    NumPar = int.Parse(Console.ReadLine());

    for (int i = 0; i < NumPar; i += 2)
    {
        Console.WriteLine(i);
    }




Console.ReadLine();