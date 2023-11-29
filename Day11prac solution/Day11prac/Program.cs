using System.Runtime.InteropServices;

namespace Day11prac
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter Your Name;");
			string name = Console.ReadLine();

			
			Console.WriteLine("Enter Your age;");
			string sage;
			int Age;
			do {
				
				sage = Console.ReadLine();
			} while (! int.TryParse(sage, out  Age) && (Age <= 0 || Age >= 100));
			
				//int age = int.Parse(Console.ReadLine());

			
			Console.WriteLine("Enter Your Address;");
			string address = Console.ReadLine();

			Console.WriteLine("Enter Your Email;");
			string email = Console.ReadLine();

			Human human = new Human( name, Age, address,  email);
            Console.WriteLine(human.greetingbyhuman());

			human.Setemail("aaa@gmail.com");
			Console.WriteLine(human.Getemail);
			Console.WriteLine(human.Getid);

			//Human h2 = new Human(name , Age, address, email);
			//{
			//	name = "fffffffff";
			//	Age = 22;
			//	address = "om";
			//	email = "mmmmr@gmail.com";


			//}
		}
	}
}