using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split();
            string name = tokens[0];

            double[] grades = tokens.Skip(1).Select(double.Parse).ToArray();
            Student student = new Student(name, grades);
            students.Add(student);

        }

        List<Student> filteredStudent = students.Where(s => s.Grades.Average() >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.Grades.Average()).ToList();
        foreach (var student in filteredStudent)
        {
            Console.WriteLine($"{student.Name} -> {student.Grades.Average():f2}");
        }
    }
}
class Student
{
    public Student(string name, double[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public string Name { get; set; }
    public double[] Grades { get; set; }
}

