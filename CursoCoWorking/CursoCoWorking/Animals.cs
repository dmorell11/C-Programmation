using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{
    class Animals
    {
        string type;
        int age;
        int lifeExpentancy;

        public Animals(string type, int age, int lifeExpentancy)
        {
            this.type = type;
            this.age = age;
            this.lifeExpentancy = lifeExpentancy;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, I`m a {type} and I`m {age} years old");
        }

        public int CalculateRestOfLife()
        {
            return lifeExpentancy - age;
        }
    }
}
