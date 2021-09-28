using System;

namespace humans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Human firsthuman = new Human("Todd");
            // Console.WriteLine(firsthuman.Health);
            Human second = new Human("Fan", 4,5,6,100);
            // Console.WriteLine($"Name: {second.Name}, Strength: {second.Strength}, Intelligence: {second.Intelligence}, Dexterity: {second.Dexterity}, Health: {second.Health}");
            // Console.WriteLine($"Name: {firsthuman.Name}, Strength: {firsthuman.Strength}, Intelligence: {firsthuman.Intelligence}, Dexterity: {firsthuman.Dexterity}, Health: {firsthuman.Health}");
            Console.WriteLine(firsthuman.Attack(second)); 
            Console.WriteLine(firsthuman.Attack(second)); 
            Console.WriteLine(second.Attack(firsthuman)); 
        }
    }
    public class Human
    {
        public string Name;
        public int Strength;                        
        public int Intelligence;
        public int Dexterity;
        public int Health;
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        // Add a constructor to assign custom values to all fields
        
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
        // Build Attack method
        public string Attack(Human target)
        {
            target.Health -= 5*(Strength);
            return $"{target.Name}'s remaining health is: {target.Health}";
        }
    }
}
