using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2._2Ans
{

    public struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
            { get { return gender; } set {
                gender = value; } }

        public int Age
            { get { return age; } set {
                age = value; } }

        public int Std
            { get { return std; } set {
                std = value; } }

        public char Div
        {
            get { return div; }
            set
            {
                div = value;
            }
        }

            public double Marks
            { get { return marks; } set {
                marks = value; } }


        public void AcceptDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char g = char.Parse(Console.ReadLine());
            gender = (g == 'M' || g == 'm');

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Standard: ");
            std = int.Parse(Console.ReadLine());

            Console.Write("Enter Division: ");
            div = char.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            marks = double.Parse(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Name     : " + name);
            Console.WriteLine("Gender   : " + (gender ? "Male" : "Female"));
            Console.WriteLine("Age      : " + age);
            Console.WriteLine("Standard : " + std);
            Console.WriteLine("Division : " + div);
            Console.WriteLine("Marks    : " + marks);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();
        }
    }
}
