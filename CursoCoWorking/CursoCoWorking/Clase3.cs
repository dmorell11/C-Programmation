using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{
    internal class Clase3
    {
        public void ExerciseThree()
        {
            VarExample();

            SumasExample();

            GetSetExample();
        }

        //Var
        public void VarExample()
        {
            var a = 2;
            var b = "c";
            var c = new Student("name", 4, 2);

            Console.WriteLine($"a: {a.GetType().Name}, b: {b.GetType().Name}, c: {c.GetType().Name}");
        }


        //Sumas
        int Suma(int a, int b)
        {
            return a + b;
        }
        int Suma(int a, int b, int c)
        {
            return a + b + c;
        }

        void SumasExample()
        {
            var resultadoA = Suma(5, 3); // 8
            var resultadoB = Suma(5, 3, 2); // 10
            var resultadoC = Suma(Suma(resultadoA, 2), resultadoB); // 9
            
            int num = 2;
            num++; //3
            num = num + 1; //4
            num += 4; //8
            num = num + 4; //12
            num *= 2; //24

            Console.WriteLine(resultadoA);
            Console.WriteLine(resultadoB);
            Console.WriteLine(resultadoC);
        }

        void GetSetExample()
        {
            Person person = new Person("pepe", 5);

            Console.WriteLine(person.GetAge());
            person.SetAge(8);
            Console.WriteLine(person.GetAge());

            Console.WriteLine(person.Name);
            person.Name = "Juan";
            Console.WriteLine(person.Name);
        }
    }
}
