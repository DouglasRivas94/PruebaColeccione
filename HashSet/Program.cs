HashSet<int> evenNumber = new HashSet<int>();
HashSet<int> oddNumber = new HashSet<int>();

for (int i = 0; i < 5; i++)
{
    evenNumber.Add(i * 2);
    oddNumber.Add((i * 2) + 1);
}

display("Even numbers", evenNumber);
display("odd Numbers", oddNumber);

HashSet<int> numbera = new HashSet<int>(evenNumber);
numbera.UnionWith(oddNumber);
display("Numbers", numbera);

numbera.Add(1);
display("Numbers", numbera);

void display(string v, HashSet<int> Number)
{
    Console.WriteLine(v);
    foreach (var item in Number)
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine();
}

