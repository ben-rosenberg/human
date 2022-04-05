using System;

namespace Human
{
    class Human
    {
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            _Health = 100;
        }

        public Human(
                string name,
                int strength,
                int intelligence,
                int dexterity,
                int health
            )
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            _Health = health;
        }

        public int Attack(Human target)
        {
            Console.WriteLine($"{this.Name} attacking {target.Name}...");
            int targetHealth = target.Health;
            int attackAmount = (this.Strength * 5 < target.Health) ? this.Strength * 5 : targetHealth;
            targetHealth -= attackAmount;
            Console.WriteLine($"Damage Dealt: {attackAmount}");
            Console.WriteLine($"{target.Name}'s New Health: {targetHealth}");
            return targetHealth;
        }

        public int Health
        {
            get => _Health;
        }

        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;

        private int _Health;
    }
}