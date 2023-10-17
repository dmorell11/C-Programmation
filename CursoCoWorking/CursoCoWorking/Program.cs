
using System;

namespace CursoCoWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Clase1 clase1 = new Clase1();
            clase1.ExerciseOne();
            */

            /*
            Clase2 clase2 = new Clase2();
            clase2.ExerciseTwo();
            */

            /*
            Student pipa = new Student("pipa", 17, 3);
            pipa.PrintInformation();
            pipa.UpdateInfo("jalapeno", 23);
            pipa.PrintInformation();
            */

            Animals animal1 = new Animals("dog", 3, 13);
            Animals animal2 = new Animals("cat", 5, 15);
            animal1.Greet();
            animal2.Greet();

            int life1 = animal1.CalculateRestOfLife();
            int life2 = animal2.CalculateRestOfLife();

            Console.WriteLine($"Rest of life dog: {life1}, Rest of life cat: {life2}");
        }
    }
}
