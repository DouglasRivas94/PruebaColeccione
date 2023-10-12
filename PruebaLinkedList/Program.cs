LinkedList<int> numeros = new LinkedList<int> ();

foreach(int numero in new int[] { 12, 43, 2, 65, 1})
{
    numeros.AddLast (numero);
}
Console.WriteLine("-----------------------------------------");

foreach (var item in numeros)
{
    Console.WriteLine (item);
}
Console.WriteLine("-----------------------------------------");
numeros.Remove(43);

LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

numeros.AddLast(nodoImportante);

for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
{
    Console.WriteLine(nodo.Value);

}
Console.WriteLine("-----------------------------------------");

string[] colores = { "negro", "Amarillo", "Azul", "Plateado", "Blanco" };
string[] colores2 = { "Gris", "Naranja", "Azul", "Plata", "Beige" };

//agregue elementos del arreglo colores a una lista enlazada

LinkedList<string> color = new LinkedList<string> ();
foreach(string cs in colores)
{
    color.AddLast (cs);
}

LinkedList<string> color2 = new LinkedList<string>(colores2);

//concat lista 2 EN LISTA 1

concatenar(color, color2);

void concatenar<T>(LinkedList<T> color, LinkedList<T> color2)
{
    Console.WriteLine("------------------------");
    foreach(T item in color2)
    {
        color.AddLast(item);
    }
    foreach(T item in color)
    {
        Console.WriteLine (item);
    }

}

//converitr los elementos de color en mayusculas

Mayusculas(color);

void Mayusculas<T>(LinkedList<T> color)
{
    LinkedListNode<T> node = color.First;
    while(node != null)
    {

        node = node.Next;
    }
}