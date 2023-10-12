SortedList<int, string> automoviles = new SortedList<int, string>();

automoviles.Add(102, "Nissan");
automoviles.Add(980, "Toyota");
automoviles.Add(123, "Cadilac");
automoviles.Add(098, "BMW");

foreach(var item in automoviles)
{
    Console.WriteLine("({0}, {1})", item.Key, item.Value);
}