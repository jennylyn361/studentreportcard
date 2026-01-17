using System;
using System.Collections.Generic;
using System.Linq;

// Student class to store details
public class Student
{
    public string Name { get; set; }
    public int English { get; set; }
    public int Math { get; set; }
    public int Computer { get; set; }
    public int TotalMarks => English + Math + Computer;
}

// Main program class with required entry point
class Program
{
    // This is the correct static Main method signature .NET needs
    static void Main(string[] args)
    {
        Console.Write("Enter Total Students: ");
        int totalStudents = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();

        // Collect student data
        for (int i = 0; i < totalStudents; i++)
        {
            Console.WriteLine($"\n--- Student {i + 1} ---");
            Student s = new Student();

            Console.Write("Name: ");
            s.Name = Console.ReadLine();

            Console.Write("English Marks (1-100): ");
            s.English = int.Parse(Console.ReadLine());

            Console.Write("Math Marks (1-100): ");
            s.Math = int.Parse(Console.ReadLine());


            Console.Write("Computer Marks (1-100): ");
            s.Computer = int.Parse(Console.ReadLine());

            students.Add(s);
        }

        // Rank and display results
        var ranked = students.OrderByDescending(s => s.TotalMarks).ToList();
        Console.WriteLine("\n\n--- REPORT CARD ---");
        for (int pos = 0; pos < ranked.Count; pos++)
        {
            var student = ranked[pos];
            Console.WriteLine($"\nPosition {pos + 1}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Total Marks: {student.TotalMarks}/300");
        }
    }
}

