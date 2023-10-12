string[] colores =
{
    "Magenta",
    "Rojo",
    "Blanco",
    "Azul"
};
string[] eliminarColores =
{
    "Magenta",
    "Rojo"
};
List<string> lista = new List<string>();

foreach(var color in colores)
{
    lista.Add(color.ToString());
}

List<string> eliminarlista = new List<string>(eliminarColores);

MostrarInformacion(lista);
EliminarItem(lista, eliminarColores);
EliminarListaColor(lista, eliminarlista);

void EliminarListaColor(List<string> lista, List<string> eliminarlista)
{
    foreach(var item in eliminarlista)
    {
        lista.Remove(item);
    }
    Console.WriteLine("\nNo eliminados");
    foreach(var item in lista)
    {
        Console.WriteLine($"{item}");
    }
}

void MostrarInformacion(List<string> lista)
{
    foreach(var item in lista)
    {
        Console.WriteLine($"{item} ");
    }

    Console.WriteLine($"\nTamaño = {lista.Count}; " + $"{lista.Capacity}");

    int index = lista.IndexOf("Azul");

    if (index != -1)
        Console.WriteLine($"La lista posee ese elemento en el indice{index}");
    else
        Console.WriteLine("La lista no posee este elemento");
}

//Elimine de primera lista los colores especificados en segunda lista
void EliminarItem(List<string> lista, string[] eliminarColores)
{
    for (int i = 0; i < eliminarColores.Length; i++)
    {
        lista.Remove(eliminarColores[i]);
    }

}