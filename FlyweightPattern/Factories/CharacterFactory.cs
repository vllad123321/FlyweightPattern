using FlyweightPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern.Factories
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, Character> _characters = new();

        public Character GetCharacter(string name, string type, string image)
        {
            // Уникальный ключ для идентификации легковеса
            string key = $"{name}-{type}";

            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new Character(name, type, image);
                Console.WriteLine($"Created new Character: {name}, Type: {type}");
            }
            else
            {
                Console.WriteLine($"Reused existing Character: {name}, Type: {type}");
            }

            return _characters[key];
        }
    }
}
