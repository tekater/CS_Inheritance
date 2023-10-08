using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Human
	{
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }

		public Human(string firstName,string lastName,string gender, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Gender = gender;
			Age = age;
			Console.WriteLine($"HConstructor:\t {this.GetHashCode()} ");
        }
		public Human(Human human)
		{
			FirstName = human.FirstName;
			LastName = human.LastName;
			Gender = human.Gender;
			Age = human.Age;
			Console.WriteLine($"HCopyConstructor:\t {this.GetHashCode()} ");
		}
		~Human()
		{
			Console.WriteLine($"HDestructor:\t {this.GetHashCode()} ");
		}

		public override string ToString()
		{
			return $"Имя:\t\t{LastName}," +
				$"\nФамилия:\t{FirstName}," +
				$"\nПол:\t\t{Gender}," +
				$"\nВозраст:\t{Age},";
		}
		public virtual void Print()
		{
            Console.WriteLine(this.GetHashCode());
            Console.WriteLine($"First Name:\t{FirstName}");
			Console.WriteLine($"Last Name:\t{LastName}");
			Console.WriteLine($"Gender:\t{Gender}");
			Console.WriteLine($"Age:\t{Age}");
		}

		public virtual void Init(string[] values)
		{
			FirstName = values[1];
			LastName = values[2];
			Gender = values[3];
			Age = Convert.ToInt32(values[4].Split(' ')[1]);
		}
	}
}
