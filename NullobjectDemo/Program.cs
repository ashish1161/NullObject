using System;

namespace NullobjectDemo
{
    abstract class Emp
    {
        protected string name;
        public abstract string getName();
    }
    class Coder : Emp
    {
        public Coder (string name)
        {
            this.name = name;
        }
        public override string getName()
        {
            return name;
        }

    }
    class NoClient : Emp
    {
        public override string getName()
        {
            return "Not Available";
        }
    }
    class EmpData
    { 
        public static  string[] names = {"Lokesh" , "Kushagra", "Vikram" };
        public static Emp getClient(string name)
        {
            for(int i =0; i< names.Length; i++)
            {
                if (names[i].Equals(name))
                {
                    return new Coder(name);
                }
            }
            return new NoClient();
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Emp emp1 = EmpData.getClient("Lokesh");
            Emp emp2 = EmpData.getClient("Kushagra");
            Emp emp3 = EmpData.getClient("Vikram");
            Emp emp4 = EmpData.getClient(null);

            Console.WriteLine(emp1.getName());
            Console.WriteLine(emp2.getName());
            Console.WriteLine(emp3.getName());
            Console.WriteLine(emp4.getName());
        }
    }
}

