using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		public static readonly string delimeter = "\n--------------------------------------\n";
		static void Main(string[] args)
		{
			/*
			Human human = new Human("Jin", "Kazama", "male", 15);
            Console.WriteLine($"\n{human}");

            Console.WriteLine($"{delimeter}");


			Student student = new Student("Jin", "Kazama", "male", 15, "fighter", "S", 90, 99);
            Console.WriteLine($"\n{student}\n");

			Console.WriteLine($"{delimeter}
			");

			Teacher teacher = new Teacher("Jun", "Kazama", "female", 22, "fighter", 8);
            Console.WriteLine($"\n{teacher}\n");

			Console.WriteLine($"{delimeter}");


			Graduate graduate = new Graduate("Jin", "Kazama", "male", 15, "fighter", "S", 90, 99, "How to kill dad");
            Console.WriteLine($"\n{graduate}\n");

			*/
			Human human = new Human("Jin", "Kazama", "male", 15);
			Console.WriteLine($"\n{human}");


			Console.WriteLine($"{delimeter}");



			Student student = new Student(human, "fighter", "S", 90, 99);
			Console.WriteLine($"\n{student}\n");

			Console.WriteLine($"{delimeter}");



			Human Thuman = new Human("Jun", "Kazama", "female", 22);

			Teacher teacher = new Teacher(Thuman, "fighter", 8);
			Console.WriteLine($"\n{teacher}\n");

			Console.WriteLine($"{delimeter}");



			Graduate graduate = new Graduate(human, student, "How to kill dad");
			Console.WriteLine($"\n{graduate}\n");


			Console.WriteLine(delimeter);
			Console.WriteLine(delimeter);

			Human[] group = new Human[] { student, teacher, graduate,
				new Teacher("Diaz", "Ricardo", "male", 30, "Thief", 20)
			};
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
                Console.WriteLine(delimeter);
            }
			Console.WriteLine(delimeter);
			Console.WriteLine(delimeter);
			for (int i = 0; i < group.Length; i++)
			{
				group[i].Print();
                Console.WriteLine(delimeter);
            }

			Console.WriteLine(delimeter);
		}
	}
}
