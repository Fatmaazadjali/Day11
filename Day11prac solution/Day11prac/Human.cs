using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day11prac
{
	internal class Human
	{
		public static int idd = 0;
		 int id;
		public string Name;
		public int Age;
		public string Address;
		private string email;

		public Human()
		{


		}
		public Human(string Name, int age, string Address, string email)
		{
			idd += 1;
			this.id = idd;
			this.Name = Name;
			this.Age = age;
			this.Address = Address;
			this.email = email;

		     }
		public string greetingbyhuman() => $"{idd}\n{this.Name} \n  your age is: {this.Age} your email is: {this.email} \n" ;
		public static bool greetingValid(int age)
	        	{
			if (age <= 0 || age>=100)
			{ return false;
			}
			return true;
		  }

		public int Getid()=>this.id;
		
		//public void Setid(int newId)
		//{
		//	this.id = newId;
		//}

		public string Getemail() => this.email;
		
		public void Setemail(string newEmail)=> this.email = newEmail;
		

	}
	
}
