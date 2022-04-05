using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human ben = new Human("Ben");
            Human daniel = new Human("Daniel");
            daniel.Attack(ben);
        }
    }
}
