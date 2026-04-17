using System;
public class Student
{
    private static int _idCounter = 1; 
    private double _gpa;

    public int StudentId { get; private set; }
    public string Name { get; set; }
    public string Faculty { get; set; }

    public double GPA
    {
        get => _gpa;
        set
        {
            if (value >= 0.0 && value <= 4.0)
            {
                _gpa = value;
            }
            else
            {
                _gpa = 0.0;
            }
        }
    }

    public Student(string name, double gpa, string faculty)
    {
        StudentId = _idCounter++;
        Name = name;
        GPA = gpa;
        Faculty = faculty;
    }

    public override string ToString()
    {
        return $"[ID: {StudentId}] {Name} | Факультет: {Faculty} | GPA: {GPA:F1}";
    }
}

public class Registry
{
    private Student[] _students = new Student[100];
    private int _count = 0;

    public void Add(Student student)
    {
        if (_count < 100)
        {
            _students[_count++] = student;
            Console.WriteLine("Студент успешно добавлен.");
        }
        else
        {
            Console.WriteLine("Ошибка: Реестр заполнен (макс. 100).");
        }
    }

    public void FindById(int id)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].StudentId == id)
            {
                Console.WriteLine("Найден: " + _students[i]);
                return;
            }
        }
        Console.WriteLine("Студент с таким ID не найден.");
    }

    public void FindByName(string name)
    {
        bool found = false;
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].Name.ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine(_students[i]);
                found = true;
            }
        }
        if (!found) Console.WriteLine("Студенты с таким именем не найдены.");
    }

    public void GetTopStudents(int n)
    {
        if (_count == 0) return;

        Student[] temp = new Student[_count];
        Array.Copy(_students, temp, _count);

        for (int i = 0; i < _count - 1; i++)
        {
            for (int j = 0; j < _count - i - 1; j++)
            {
                if (temp[j].GPA < temp[j + 1].GPA)
                {
                    Student b = temp[j];
                    temp[j] = temp[j + 1];
                    temp[j + 1] = b;
                }
            }
        }

        Console.WriteLine($"\n Топ {n} студентов");
        int limit = n < _count ? n : _count;
        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine(temp[i]);
        }
    }

    public void PrintAll()
    {
        Console.WriteLine("\n Список всех студентов");
        if (_count == 0) Console.WriteLine("Реестр пуст.");
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine(_students[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Registry myRegistry = new Registry();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Найти по ID");
            Console.WriteLine("3. Найти по имени");
            Console.WriteLine("4. Показать ТОП по GPA");
            Console.WriteLine("5. Показать всех");
            Console.WriteLine("0. Выход");
            Console.Write("Выбор: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Имя: "); string n = Console.ReadLine();
                    Console.Write("GPA (0-4): "); double g = double.Parse(Console.ReadLine());
                    Console.Write("Факультет: "); string f = Console.ReadLine();
                    myRegistry.Add(new Student(n, g, f));
                    break;
                case "2":
                    Console.Write("Введите ID: ");
                    int id = int.Parse(Console.ReadLine());
                    myRegistry.FindById(id);
                    break;
                case "3":
                    Console.Write("Введите имя для поиска: ");
                    string searchName = Console.ReadLine();
                    myRegistry.FindByName(searchName);
                    break;
                case "4":
                    Console.Write("Сколько студентов вывести? ");
                    int count = int.Parse(Console.ReadLine());
                    myRegistry.GetTopStudents(count);
                    break;
                case "5":
                    myRegistry.PrintAll();
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
        }
    }
}