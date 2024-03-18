using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
	public class Person
	{
		protected int id;
		protected string Name;
		protected string gender;

		public void person_info(int id, string name, string gender)
		{
			this.id = id;
			this.Name = name;
			this.gender = gender;
            Console.WriteLine($"{id}\n{Name}\n{gender}" );
        }
	}

	public class Emp1 : Person
	{
		
		public void emp1_details(int id, string name, string gender)
		{
			Console.WriteLine($"Emp1 details are {id}\n{name}\n{gender}");
		}
	}public class Emp2 : Person
	{
		public void emp2_details()
		{
			Console.WriteLine($"Emp2 details are {id}\n{Name}\n{gender}");
		}
	}




}
