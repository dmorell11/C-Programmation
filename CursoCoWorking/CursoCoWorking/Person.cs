using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{
    class Person
    {
        private int age;
        private string name;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

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

        public int GetAge()
        {
            return this.age; 
        }

        public void SetAge(int newAge)
        {
            this.age = newAge; 
        }

    }
}
