using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{
    class Person
    {
        public int age;
        public string name;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {
            this.name = null;
            this.age = 0;
        }

        public void Greet()
        {
            Console.WriteLine("Hello");
        }

    }
}
