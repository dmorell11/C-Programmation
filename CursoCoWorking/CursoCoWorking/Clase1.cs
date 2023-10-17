using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{
    class Clase1
    {
        //una enumeración, es una lista de nombres y puede estar fuera del método:
        enum Day { Mon, Tues, Wed };

        //crea un método main. Siempre va primero tipo, nombre de la variable y valor. Si queremos añadir cosas, como que una variable sea constante, esto debe ir delante del tipo.
        public void ExerciseOne()
        {
            //Hay 2 tipos de "tipos". 1_tipos de valor:
            int numInt = (int)30.5;
            long numLong = 30000000;
            float numFloat = 30.5f; //para hacer un decimal float, poner la f al final
            double numDouble = 40.6;
            bool flag = false;

            int a = 15;
            int b = 7;
            int c = a + b;
            Console.WriteLine($"c: {c}");
            // lo que va después del dolar es el nombre que le asignamos y lo que hay entre corches es el valor.


            int d = 10;
            float e = 3;
            float h = d / e;
            Console.WriteLine($"h: {h}");
            //al dividir, uno de los números es float (es decir, con decimales) para que al imprimirlo lo tengamos con decimales y no un entero.

            Console.WriteLine(numInt);
            Console.WriteLine(numLong);
            Console.WriteLine($"Hello {numLong}, {numDouble}, World"); //Para que imprima en este caso los números y no los sume, los tenemos que poner entre corchetes. De esta forma imprime los valores que le hemos dado previamente.

            //podemos hacer los tipos constantes, de esta forma si quisieramos cambiar el número nos daría error.
            const long numLongconst = 7;

            //instanciar = crear (new)
            Person juan = new Person();

            Day monday = Day.Mon;

            //2_Tipos de referencia: almacenan referencias a sus datos.

            Animal perro = new Animal();
            perro.foot = 4;

            Animal canguro = new Animal(2);

            Animal perro2 = perro;

            perro2.foot = 3;

        }
    }

}
