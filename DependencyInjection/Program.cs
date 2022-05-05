using System;

namespace DependencyInjection
{
    public class Employee
    {
        public void Work()
        {
            Console.WriteLine("Employee Working...");
        }
    }// class employee is a dependency of company
  
    public class Company
    {
        private Employee _myDependency;
        private string _emailMessage;
        //by constructor
        public Company(Employee myDependency)
        {
            this._myDependency = myDependency;
        }

        //by setter
        public void SendMail(string message) 
        {
            this._emailMessage= message;
        }
        public void GetEmail()
        {
            Console.WriteLine($"{_emailMessage}");
        }
        public void ActionB()
        {
            _myDependency.Work();
        }
    }// company depend on employee

    public class Program
    {
        static void Main(String[] args)
        {
          
            Company obj2= new Company(new Employee());

            obj2.SendMail("----demo mail from setter----");
            obj2.ActionB();
            obj2.GetEmail();
           
        }
    }
}