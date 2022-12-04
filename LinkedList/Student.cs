using System;

namespace LinkedList
{
    public class Student
    {
        public string Major;
        public string Number;
        public double GPA;
        public override string ToString()
        {
            Console.WriteLine();
            return String.Format("Number: {0}, Major: {1}, GPA: {2}", Number, Major, GPA);
        }
    }
}