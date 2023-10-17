using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{
    class Clase2
    {
        public void ExerciseTwo()
        {
            Person juan = new Person("Juan", 15);
            Person ana = new Person("Ana", 20);
            int num = 4;

            PrintPersonData(juan, ana, num);

            Console.WriteLine($"Name: {juan.name}, Num: {num}");
        }

        public void PrintPersonData(Person person1, Person person2, int numPeople)
        {

            Console.WriteLine($"Num: {numPeople}");

            Console.WriteLine($"Name: {person1.name}, Age: {person1.age}");

            person1.name = "pepe";
            numPeople = 8;

            Console.WriteLine($"Name: {person1.name}, Age: {person1.age}");
            Console.WriteLine($"Name: {person2.name}, Age: {person2.age}");
            Console.WriteLine($"Num: {numPeople}");
        }

        public void PrintPersonData(Person person)
        {
            Console.WriteLine($"Name: {person.name}, Age: {person.age}");
        }


    }
}
