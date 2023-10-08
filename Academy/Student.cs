using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Student : Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }

		public Student
			(
			string firstname, string lastname,string gender, int age,
			string speciality,string group,double rating,double attendance
			) :base(firstname, lastname,gender, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{this.GetHashCode()}");
        }
		public Student
			(
			Human human,
			string speciality, string group, double rating, double attendance
			) : base(human)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"SHConstructor:\t{this.GetHashCode()}");
		}
		public Student
			(
			Human human,
			Student student
			) : base(human)
		{
			Speciality = student.Speciality;
			Group = student.Group;
			Rating = student.Rating;
			Attendance = student.Attendance;
			Console.WriteLine($"SCopyConstructor:\t{this.GetHashCode()}");
		}

		public Student(Student other) : base(other)
		{
			this.Speciality = other.Speciality;
			this.Group = other.Group;
			this.Rating = other.Rating;
			this.Attendance = other.Attendance;
			Console.WriteLine($"SCopyConstructor:\t{this.GetHashCode()}");
		}

		~Student()
		{
			Console.WriteLine($"SDestructor:\t{this.GetHashCode()}");
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				$"Специальность:\t{Speciality} ," +
				$"\nГруппа:\t\t{Group} ," +
				$"\nRating:\t\t{Rating} ," +
				$"\nAttendance:\t{Attendance} ,";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine
				(
				$"Специальность:\t{Speciality}" +
				$"\nГруппа:\t\t{Group}" +
				$"\nRating:\t\t{Rating}" +
				$"\nAttendance:\t{Attendance}"
				);
        }
		public override void Init(string[] values)
		{
			base.Init(values);
			Speciality = values[5];
			Group = values[6];
			Rating = Convert.ToDouble(values[7].Split(' ')[1]);
			Attendance = Convert.ToDouble(values[8].Split(' ')[1]);
		}

	}
}
