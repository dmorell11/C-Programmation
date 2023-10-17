using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{
    class Student
    {
        private string name;
        private int age;
        private int id;

        public Student(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"name: {name}, age: {age}, id: {id}");
        }

        public void UpdateInfo(string newName, int newAge)
        {
            name = newName;
            age = newAge;
        }

    }
}
