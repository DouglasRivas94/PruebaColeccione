using Modelo;

Queue<Punto> puntos = new Queue<Punto>();

puntos.Enqueue(new Punto(3,7));
puntos.Enqueue(new Punto(9,1));
puntos.Enqueue(new Punto(8,3));
puntos.Enqueue(new Punto(2,6));

Display(puntos);


//Hacemos Peek
Console.WriteLine("Peek{0} ", puntos.Peek());
Display(puntos);

//Quitar elementos
Console.WriteLine("DeQueue {0}", puntos.Dequeue());
Console.WriteLine("DeQueue {0}", puntos.Dequeue());
Display(puntos);


void Display(Queue<Punto> puntos)
{
    foreach (var item in puntos)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("--------------------------------");
}