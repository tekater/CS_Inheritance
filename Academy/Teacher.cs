using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
	class Teacher:Human
	{
		public string Speciality { get; set; }
		public int Experience { get; set; }
		public Teacher
			(
			string firstname, string lastname, string gender, int age,
			string speciality, int experience
			) : base(firstname, lastname,gender, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TConstructor:\t{this.GetHashCode()}");
		}
		public Teacher
			(
			Human human,
			string speciality, int experience
			) : base(human)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TConstructor:\t{this.GetHashCode()}");
		}
		public Teacher(Teacher other):base(other)
		{
			this.Speciality = other.Speciality;
			this.Experience = other.Experience;
			Console.WriteLine($"TCopyConstructor:\t{this.GetHashCode()}");
		}
		~Teacher()
		{
			Console.WriteLine($"TDestructor:\t{this.GetHashCode()}");
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				$"Специальность:\t{Speciality}," +
				$"\nОпыт:\t\t{Experience},";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine
				(
				$"Специальность:\t{Speciality}" +
				$"\nОпыт:\t\t{Experience}"
			);
		}

		public override void Init(string[] values)
		{
			base.Init(values);
			Speciality = values[9].TrimStart().TrimEnd();
			Experience = Convert.ToInt32(values[10].Split(' ')[1]);
		}
	}
}
