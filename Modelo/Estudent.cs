using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDictionary
{
    public class Estudent
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public Estudent(int id, string nombre, string apellido, int edad)
        {
            Name = nombre;
            Id = id;
            lastName = apellido;
            age = edad;
        }
    }
}
