using System;

namespace LinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var _students = new LinkedList();

            var breakTime = false;
            while (!breakTime)
            {
                Console.Clear();
                Console.WriteLine("Enter number and then press enter.");
                Console.WriteLine("(1) Insert new student to list");
                Console.WriteLine("(2) Find student in list by student number.");
                Console.WriteLine("(3) Show list records.");
                Console.WriteLine("(4) Exit :( ");
                var key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        var student = Add();
                        _students.Add(student);
                        break;
                    case "2":
                        var find = _students.Find(Find());
                        Console.WriteLine("{0}, {1}, {2}", find.Major, find.Number,
                            find.GPA);
                        Console.WriteLine("Enter a key to back ...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        for (var i = 0; i < _students.Length; i++)
                            Console.WriteLine("{0}) {1}, {2}, {3}", i, _students[i].Major, _students[i].Number,
                                _students[i].GPA);
                        Console.WriteLine("Enter a key to back ...");
                        Console.ReadKey();
                        break;
                    case "4":
                        breakTime = true;
                        break;
                }
            }
        }

        private static Student Add()
        {
            var student = new Student();
            Console.Clear();
            Console.WriteLine("Enter student information to add.");
            Console.Write("Major: ");
            student.Major = Console.ReadLine();
            Console.Write("Number: ");
            student.Number = Console.ReadLine();
            Console.Write("Average: ");
            student.GPA = double.Parse(Console.ReadLine() ?? "0");
            return student;
        }

        private static string Find()
        {
            Console.Clear();
            Console.WriteLine("Enter a student number to find.");
            Console.Write("Number: ");
            return Console.ReadLine();
        }
    }
}