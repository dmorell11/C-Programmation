namespace Ejercicio2
{
    class Student
    {
        public string name;
        public int age;
        public int id;

        public Student(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Id: {id}");
        }

        public void UpdateInfo(string newName, int newAge)
        {
            name = newName;
            age = newAge;
        }

        public int ReturnAgeTo(int ageObjetive)
        {
            return ageObjetive - age;
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student("Pepe", 21, 1);
            Student student2 = new Student("Maria", 10, 2);

            student.PrintInformation();
            student2.PrintInformation();

            student.UpdateInfo("Juan", 2);

            student.PrintInformation();

            int a = student.ReturnAgeTo(100);

            Console.WriteLine($"Return: {a}");



        }

    }
}

