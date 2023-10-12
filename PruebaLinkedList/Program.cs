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
    Console.WriteLine("---------------------------");
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
Mayusculas<string>(color);

void Mayusculas<T>(LinkedList<string> color)
{
    LinkedListNode<string> node = color.First;
    while(node != null)
    {
        node = node.Next;
    }
}

//Imprimir lista en orden inverso
Inverso(color);

void Inverso<T>(LinkedList<T> color)
{
    LinkedListNode<T> nodos = color.Last;

    while(nodos != null)
    {
        Console.WriteLine($"{nodos.Value} ");
        nodos = nodos.Previous;
    }
    Console.WriteLine();
}

//eliminar de la cadena 1 los colores Negro y beige
Eliminar(color, "Beige", "Gris");

void Eliminar<T>(LinkedList<T> color, T Inicial, T Final)
{
    LinkedListNode<T> nodoA = color.Find(Inicial);
    LinkedListNode<T> nodoB = color.Find(Final);

    while((nodoA.Next!= null) && (nodoA.Next != nodoB))
    {
        color.Remove(nodoA.Next);

    }
}