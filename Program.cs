using System;

namespace _PROJECT_Students
{
    class Program
{
    static List<Student> students = new List<Student>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n==== Menu ====");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show all students");
            Console.WriteLine("3. Search student by name");
            Console.WriteLine("4. Calculate average grade");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    DisplayStudents();
                    break;
                case "3":
                    SearchStudent();
                    break;
                case "4":
                    CalculateAverage();
                    break;
                case "5":
                    System.Console.WriteLine("Exiting the program...");
                    return;
                default:
                    System.Console.WriteLine("Invalid option. Try again!");
                    break;

            }
        }
    }

    static void AddStudent()
    {
        System.Console.Write("Enter student's name: ");
        string name = Console.ReadLine();

        System.Console.WriteLine("Enter student's grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        if (grade < 2.00 || grade > 6.00)
        {
            System.Console.WriteLine("Invalid grade.");
        }

        students.Add(new Student(name, grade));
        System.Console.WriteLine("Student added!");
    }

    static void DisplayStudents()
    {
        if (students.Count == 0)
        {
            System.Console.WriteLine("There are no students to be shown.");
            return;
        }
        foreach (Student s in students)
        {
            System.Console.WriteLine($"{s.name} - {s.grade:F2}");
        }
    }

    static void SearchStudent()

    {
        System.Console.Write("Search by name: ");
        string input = Console.ReadLine();
        bool match = false;

        foreach (Student s in students)
        {
            if (s.name.ToLower().Contains(input))
            {
                System.Console.WriteLine($"{s.name} - {s.grade:F2}");
                match = true;
            }
        }

        if (!match)
        {
            System.Console.WriteLine("No such students found!");
        }
    }

    static void CalculateAverage()
    {
        if (students.Count == 0)
        {
            System.Console.WriteLine("There are no added students!");
            return;
        }

        double total = 0;
        foreach (Student s in students)
        {
            total += s.grade;
        }
        System.Console.WriteLine($"Average: {total / students.Count:F2}");
    }
}
}
