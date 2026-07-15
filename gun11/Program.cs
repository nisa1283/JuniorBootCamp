using gun11;
using System.Linq;

List<Student> students = new List<Student>
{
    new Student { Name = "Alice", Department = "Computer Science", Grade = 95 },
    new Student { Name = "Bob", Department = "Mathematics", Grade = 85 },
    new Student { Name = "Charlie", Department = "Physics", Grade = 90 },
    new Student { Name = "David", Department = "Chemistry", Grade = 75 },
    new Student { Name = "Eve", Department = "Biology", Grade = 85 },
    new Student{ Name = "Frank", Department = "Computer Science", Grade = 90 },
    new Student{ Name = "Grace", Department = "Mathematics", Grade = 80 },
    new Student{ Name = "Heidi", Department = "Physics", Grade = 70 },
    new Student{ Name = "Ivan", Department = "Chemistry", Grade = 55 },
    new Student{ Name = "Judy", Department = "Biology", Grade = 85 },
    new Student { Name = "Kevin", Department = "Computer Science", Grade = 75 },
    new Student { Name = "Laura", Department = "Mathematics", Grade = 60 },
    new Student { Name = "Mallory", Department = "Physics", Grade = 65 },
    new Student { Name = "Niaj", Department = "Chemistry", Grade = 50 },
};

var passedStudents = students.Where(students => students.Grade >= 70).ToList();
    foreach(var student in passedStudents)
    {
        Console.WriteLine($"Name: {student.Name}, Department: {student.Department}, Grade: {student.Grade}");
    }

var upperNames = students.Select(students => students.Name.ToUpper()).ToList();
    foreach(var name in upperNames)
    {
        Console.WriteLine(name);
    }

var orderedStudents = students.OrderByDescending(students => students.Grade).ToList();
    foreach(var student in orderedStudents)
    {
        Console.WriteLine($"Name: {student.Name}, Department: {student.Department}, Grade: {student.Grade}");
    }

var groupedStudents = students.GroupBy(students => students.Department).ToList();
    foreach(var group in groupedStudents)
    {
        Console.WriteLine("--------------------");
        Console.WriteLine($"Department: {group.Key}");
        Console.WriteLine("--------------------");
    foreach (var student in group)
        {
            Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
        }
    }

