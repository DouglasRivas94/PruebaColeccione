using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class prueba
{
    public static void Main()
    {
        //cree una coleccion de frutas
        Collection<String> Frutas = new Collection<string>();
        Frutas.Add("Limon");
        Frutas.Add("Pera");
        Frutas.Add("Mandarina");
        Frutas.Add("Uva");

        //Imprimir la coleccion 
        Console.WriteLine("{0} Frutas: ", Frutas.Count);
        Display(Frutas);

        //Agregar un elemento a la coleccion
        Console.WriteLine("\nInsert(2, \"Sandia\"): {0}");
        Frutas.Insert(3, "Sandia");
        Display(Frutas);

        //Verificar si en la coleccion esta la naranja
        Console.WriteLine("La coleccion contiene la naranja " + $"{Frutas.Contains("Naranja")}");
        Frutas.Contains("Naranja");

        //Remover el indice 2 de la coleccion
        Frutas.RemoveAt(2);


        //Imprimir coleccion en cada caso
        Console.WriteLine("La coleccion no contiene el indice 2");
        Display(Frutas);

        //Contar elementos de la coleccion
        Console.WriteLine($"La coleccion tiene {Frutas.Count}");
    }
    private static void Display(Collection<string> cs)
    {
        Console.WriteLine();
        foreach (string item in cs)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------------------------------------");
    }

}