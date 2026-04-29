using System;

namespace StudentRegistryApp
{
    public class Student
    {
        private static int _idCounter = 0;
        public int StudentId { get; private set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        private double _gpa;

        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value >= 0.0 && value <= 4.0) _gpa = value;
                else throw new Exception("GPA must be 0.0 - 4.0");
            }
        }

        public Student(string name, double gpa, string faculty)
        {
            this.StudentId = ++_idCounter;
            this.Name = name;
            this.GPA = gpa;
            this.Faculty = faculty;
        }

        public string GetInfo()
        {
            return "ID: " + StudentId + " | Name: " + Name + " | GPA: " + _gpa.ToString("0.00") + " | Faculty: " + Faculty;
        }
    }

    public class Registry
    {
        private Student[] _students = new Student[100];
        private int _count = 0;

        public void Add(Student s)
        {
            if (_count < 100) _students[_count++] = s;
            else Console.WriteLine("Registry full");
        }

        public Student FindById(int id)
        {
            for (int i = 0; i < _count; i++)
                if (_students[i].StudentId == id) return _students[i];
            return null;
        }

        public Student[] FindByName(string name)
        {
            int matchCount = 0;
            for (int i = 0; i < _count; i++)
                if (_students[i].Name.ToLower() == name.ToLower()) matchCount++;

            Student[] matches = new Student[matchCount];
            int index = 0;
            for (int i = 0; i < _count; i++)
                if (_students[i].Name.ToLower() == name.ToLower()) matches[index++] = _students[i];

            return matches;
        }

        public Student[] GetTopStudents(int n)
        {
            int actualN = (n > _count) ? _count : n;
            if (actualN <= 0) return new Student[0];

            Student[] sorted = new Student[_count];
            for (int i = 0; i < _count; i++) sorted[i] = _students[i];

            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = 0; j < _count - i - 1; j++)
                {
                    if (sorted[j].GPA < sorted[j + 1].GPA)
                    {
                        Student temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }

            Student[] result = new Student[actualN];
            for (int k = 0; k < actualN; k++) result[k] = sorted[k];
            return result;
        }

        public void PrintAll()
        {
            for (int i = 0; i < _count; i++) Console.WriteLine(_students[i].GetInfo());
        }
    }

    class Program
    {
        static void Main()
        {
            Registry r = new Registry();
            while (true)
            {
                Console.Write("1.Add \n2.ID \n3.Name \n4.Top \n5.All \n6.Exit \n");
                string op = Console.ReadLine();
                if (op == "6") break;

                try
                {
                    if (op == "1")
                    {
                        Console.Write("Name: "); string n = Console.ReadLine();
                        Console.Write("GPA: "); double g = double.Parse(Console.ReadLine());
                        Console.Write("Faculty: "); string f = Console.ReadLine();
                        r.Add(new Student(n, g, f));
                    }
                    else if (op == "2")
                    {
                        Console.Write("ID: ");
                        Student s = r.FindById(int.Parse(Console.ReadLine()));
                        Console.WriteLine(s != null ? s.GetInfo() : "Not found");
                    }
                    else if (op == "3")
                    {
                        Console.Write("Name: ");
                        Student[] results = r.FindByName(Console.ReadLine());
                        for (int i = 0; i < results.Length; i++) Console.WriteLine(results[i].GetInfo());
                    }
                    else if (op == "4")
                    {
                        Console.Write("N: ");
                        Student[] top = r.GetTopStudents(int.Parse(Console.ReadLine()));
                        for (int i = 0; i < top.Length; i++) Console.WriteLine(top[i].GetInfo());
                    }
                    else if (op == "5") r.PrintAll();
                }
                catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
            }
        }
    }
}