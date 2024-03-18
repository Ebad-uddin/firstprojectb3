using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
	public class Employee
	{
		public string firstName;
		public string lastName;
		public int Age;

		public Employee()

		{
			
			Console.WriteLine("employee constructor");
		}

		public void Emp1()
		{
			Console.WriteLine($"emp1 details are {firstName} {lastName} {Age}");
		}


	}

	public class Worker : Employee
	{
		//public Worker(string fname, string lname, int age)
		//{
		//	this.firstName = fname;
		//	this.lastName = lname;
		//	this.Age = age;
		//	Console.WriteLine($"worker Details are {firstName} {lastName} {Age}");
		//}
		public string Designation;
		public void emp2()
		{
            Console.WriteLine($"emp2 details  {firstName} {lastName} {Age}");
        }

				
	}
	public class Manager : Worker
	{
		public Manager(string fname, string lname, int age, string designation)
		{
			this.firstName = fname; this.lastName = lname; this.Age = age; this.Designation = designation;
            Console.WriteLine($"third child properties {firstName} {lastName} {Age} {Designation}");

        }
		public void Details()
		{

			Console.WriteLine("manager details");
		}

	}




}
