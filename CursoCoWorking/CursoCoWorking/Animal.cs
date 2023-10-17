using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCoWorking
{

    class Animal
    {
        public string name;
        public int foot;
        public int age;

        public Animal(string name, int foot)
        {
            this.name = name;
            this.foot = foot;
        }
        public Animal(int foot)
        {
            this.foot = foot;
        }

        public Animal() 
        {
            this.name = null;
            this.foot = 0;
        }

    }
}
