using PruebaDictionary;

Estudent std1 = new(1, "Marco", "Rivera", 20);
Estudent std2 = new(2, "juan", "mena", 30);
Estudent std3 = new(3, "Diego", "Rios", 17);
Estudent std4 = new(4, "Moises", "suarez", 25);

Dictionary<int, Estudent> dic = new Dictionary<int, Estudent>();

dic.Add(std1.Id, std1 );
dic.Add(std2.Id, std2 );
dic.Add(std3.Id, std3 );
dic.Add(std4.Id, std4 );

foreach(var item in dic.Values)
{
    Console.WriteLine("Nombre: {0}; Edad: {1}; ", item.Name, item.age);
}