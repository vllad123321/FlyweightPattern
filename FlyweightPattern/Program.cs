using System;
using FlyweightPattern.Factories;
using FlyweightPattern.Models;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory factory = new CharacterFactory();

            
            Character warrior1 = factory.GetCharacter("Aragon", "Warrior", "warrior.png");
            warrior1.Level = 10;
            warrior1.Experience = 1500;

            Character warrior2 = factory.GetCharacter("Aragon", "Warrior", "warrior.png"); 
            warrior2.Level = 12;

            Character mage = factory.GetCharacter("Gandalf", "Mage", "mage.png");
            mage.Level = 15;
            mage.Experience = 2000;

            
            warrior1.Display();
            warrior2.Display();
            mage.Display();
        }
    }
}