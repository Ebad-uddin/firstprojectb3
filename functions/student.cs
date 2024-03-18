using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
	public class student
	{
		public int num1;
		public int num2;
		// constructor function
        public student()
        {
			Console.WriteLine("constructor function"); 
        }

		public student(string cons) : this()
		{
            Console.WriteLine("second constructor function" + cons);
        }
		public student(string cons1, string cons2) : this(" usama")
		{
            Console.WriteLine("second constructor function" + cons1 + cons2);
        }


        public void msg3()
		{
			Console.WriteLine("student class");
		}
		public void add()
		{
            Console.WriteLine(num1 + num2);
        }
		
	

	}



}
