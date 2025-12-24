using System;

namespace Ass2._1
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person() : this(0, "")
        {
        }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public virtual void AcceptRecord()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            Age = int.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age  : " + Age);
        }
    }

    public class Emp : Person
    {
        public int Id { get; set; }
        public double Salary { get; set; } // Base salary

        public Emp() : this(0, 0)
        {
        }

        public Emp(double salary, int id)
        {
            Salary = salary;
            Id = id;
        }

        public override void AcceptRecord()
        {
            base.AcceptRecord();

            Console.Write("Enter Employee Id: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Base Salary: ");
            Salary = double.Parse(Console.ReadLine());
        }

        public virtual double CalSalary()
        {
            return Salary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Emp Id : " + Id);
            Console.WriteLine("Salary : " + CalSalary());
        }
    }

    public class Labor : Emp
    {
        public int Hour { get; set; }
        public int Rate { get; set; }

        public Labor() : this(0, 0)
        {
        }

        public Labor(int hour, int rate)
        {
            Hour = hour;
            Rate = rate;
        }

        public override void AcceptRecord()
        {
            base.AcceptRecord();

            Console.Write("Enter Hours: ");
            Hour = int.Parse(Console.ReadLine());

            Console.Write("Enter Rate: ");
            Rate = int.Parse(Console.ReadLine());
        }

        public override double CalSalary()
        {
            return Hour * Rate;
        }
    }

    public class Manager : Emp
    {
        public int Bonus { get; set; }

        public Manager() : this(0)
        {
        }

        public Manager(int bonus)
        {
            Bonus = bonus;
        }

        public override void AcceptRecord()
        {
            base.AcceptRecord();

            Console.Write("Enter Bonus: ");
            Bonus = int.Parse(Console.ReadLine());
        }

        public override double CalSalary()
        {
            return Salary + Bonus;
        }
    }

    public class Salesman : Emp
    {
        public int Comm { get; set; }

        public Salesman() : this(0)
        {
        }

        public Salesman(int comm)
        {
            Comm = comm;
        }

        public override void AcceptRecord()
        {
            base.AcceptRecord();

            Console.Write("Enter Commission: ");
            Comm = int.Parse(Console.ReadLine());
        }

        public override double CalSalary()
        {
            return Salary + Comm;
        }
    }

    public class Clerk : Emp
    {
        // No extra salary logic
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Manager();
            //p1.AcceptRecord();
            //p1.Display();

            //Console.ReadLine();

            //Person p1 = new Salesman();
            //p1.AcceptRecord();
            //p1.Display();

            //Person p1 = new Person();
            //p1.AcceptRecord();
            //p1.Display();

            Person p1 = new Emp();
            p1.AcceptRecord();
            p1.Display();
        }
    }
}
