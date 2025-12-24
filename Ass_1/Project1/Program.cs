using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

    public class Student
    {
        private int id;
        private string name;
        private int age;

        private bool gender;
        private int std;
        private char div;
        private double marks;



        public Student() { }

        public Student(int id, string name, int age, bool gender, int std, char div ,double marks)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public int Id
        {
            set { this.id = value; }

            get { return this.id; }
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get { return this.age; }   
            set { this.age = value; }
        }

        public string Gender
        {
            get;
            set;
        }

        public string Std
        {
            get;
            set;
        }

        public string Div
        {
            get;
            set;
        }

        public string Marks
        {
            get;
            set;
        }




        public void Diasplay()
        {
            Console.WriteLine("ID of Student :"+this.id);
            Console.WriteLine("Name of the Student"+this.name);
            Console.WriteLine("Age of Student is: " + this.age);

            Console.WriteLine("gender of Student is: " + this.gender);
            Console.WriteLine("std of Student is: " + this.std);
            Console.WriteLine("div of Student is: " + this.div);
            Console.WriteLine("marks of Student is: " + this.marks);
        }

        public void AddData()
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            this.name = name;

            Console.WriteLine("Enter the Id: ");
            string Id = Console.ReadLine();
            int id1 = int.Parse(Id);
            this.id = id1;


            Console.WriteLine("Enter the age: ");
            string age = Console.ReadLine();
            int age1 = int.Parse(age);
            this.age= age1;

            Console.WriteLine("Enter gender: ");
            bool gender = Console.ReadLine() == "true";
            this.gender = gender;

            Console.WriteLine("Enter the std: ");
            String std1 = Console.ReadLine();

            int std = int.Parse(std1);
            this.std = std;

            Console.WriteLine("Enter the div");
            String div = Console.ReadLine();
            char ch = char.Parse(div);
            this.div = ch;

            Console.WriteLine("Enter the marks: ");
            String marks = Console.ReadLine();
            double markks1 = double.Parse(marks);
            this.marks = markks1;
        }

        public void Display()
        {
            Console.WriteLine("name : {0} Age : {1} Id : {2} Gender : {3} Std : {4} Div : {5}  marks : {6} ",this.name,this.age, this.id, this.gender, this.std, this.div, this.marks);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Jay Ganesh...!!");

                //Student s1 = new Student(12, "Shubham", 22);
                //s1.Display();

                Student s2 = new Student();
                s2.AddData();
                s2.Display();
            }
        }
    }
}