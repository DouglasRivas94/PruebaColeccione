using Modelo;

Stack<Punto> PUNTOS = new Stack<Punto>();
PUNTOS.Push(new Punto(3, 4));
PUNTOS.Push(new Punto(4, 2));
PUNTOS.Push(new Punto(6, 5));
PUNTOS.Push(new Punto(9, 7));

Display(PUNTOS);

Console.WriteLine("Peek {0}", PUNTOS.Peek());
Display(PUNTOS);

Console.WriteLine("Pop {0} ", PUNTOS.Pop());
Display(PUNTOS);

void Display(Stack<Punto> pUNTOS)
{
    foreach(var punto in PUNTOS)
    {
        Console.WriteLine("-> {0} ", punto);
    }
    Console.WriteLine("-----------------------------");
}