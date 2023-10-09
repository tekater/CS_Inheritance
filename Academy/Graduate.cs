using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Academy
{
	class Graduate:Student
	{
		public string Subject { get; set; }
		public Graduate
			(
			string firstname, string lastname, string gender, int age,
			string speciality, string group, double rating, double attendance,
			string subject
			) : base(firstname, lastname, gender, age, speciality, group, rating, attendance)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor:\t{this.GetHashCode()}");
		}
		public Graduate
			(
			Human human,
			Student student,
			string subject
			) : base(human, student)
		{
			Subject = subject;
			Console.WriteLine($"GCopyConstructor:\t{this.GetHashCode()}");
		}
		public Graduate(Graduate other):base(other)
		{
			this.Subject = other.Subject;
			Console.WriteLine($"GCopyConstructor:\t{this.GetHashCode()}");
		}
		~Graduate()
		{
			Console.WriteLine($"GDenstructor:\t{this.GetHashCode()}");
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				$"Subject:\t{Subject},";
		}
		public override void Print()
		{
			base.Print();
            Console.WriteLine($"Subject:\t{Subject}");
        }

		public override void Init(string[] values)
		{
			base.Init(values);
			Subject = values[11].TrimStart().TrimEnd();
		}
	}
}
