using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Models
{
    public class Character
    {
        public string Name { get; }
        public string Type { get; }
        public string Image { get; }

        // Данные, не относящиеся к легковесным
        public int Level { get; set; }
        public int Experience { get; set; }

        public Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Image: {Image}, Level: {Level}, Experience: {Experience}");
        }
    }
}
