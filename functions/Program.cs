namespace functions
{
	internal class Program
	{	
		// void doesnot return the value
		void msg()
		{
            Console.WriteLine("simple msg in void method");
        }

		// static method

		public static void msg2()
		{
            Console.WriteLine("static method");
        }

		// parameterized methods

		public static string Person_Details(string firstName = "unknown", string lastName = "unknown", int age = 44)
		{
			return $"your fullname is {firstName} {lastName} and age is {age}";
		}


		class Students
		{
			
			//public void details(int id, string FirstName, string LastName, string Classs, int Age)
			//{
			//	this.Id = id;
			//	this.firstName = FirstName;
			//	this.lastName = LastName;
			//	this.@class = Classs;
			//	this.age = Age;
   //             Console.WriteLine($"Student details are: id = {Id}, fname = {firstName}, lname = {lastName}, class = {@class}, age = {age} ");

   //         }


		}

		public string add(int num1, int num2)
		{
			var result = num1 + num2;
			return $"The Addition of two numbers {result}";
		}

		


		static void Main(string[] args)
		{
			////Students std = new Students();
			////std.details(23, "Usman", "Ghani", "matric", 34);
			////std.details(23, "ALi", "Hassan", "First Year", 34);

			//string result = Program.Person_Details();
			//         Console.WriteLine(result);

			////student std = new student();
			//student std1 = new student("parameter in constructor", " third constructor");
			////student std2 = new student("", "second parameter");
			////std.msg3();
			////std.num1 = 3;
			////std.num2 = 4;
			////std.add();

			//Person p = new Person();
			//Emp1 p1 = new Emp1();
			//Emp2 p2 = new Emp2();

			//p1.person_info(33, "Ali", "Male");
			//p1.emp1_details(23, "Hassan", "Male");

			//p1.id = 32;
			//p1.Name = "Agha";
			//p1.gender = "Male";
			//p1.emp1_details();

			//p2.id = 32;
			//p2.Name = "Agha";
			//p2.gender = "Male";
			//p2.emp2_details();

			Manager manager = new Manager("Ebad" , "UDdin", 20, "Faculty");
			//manager.Details();
			//manager.Emp1();
			//manager.emp2();


		}
	}
}