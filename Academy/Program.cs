//#define WRITE_TO_FILE
//#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			Console.WriteLine("\n");
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
			Console.WriteLine("\n");
			Console.WriteLine(delimeter);
			for (int i = 0; i < group.Length; i++)
			{
				group[i].Print();
				Console.WriteLine(delimeter);
			}

			Console.WriteLine(delimeter);
			Console.WriteLine("\n");
			Console.WriteLine(delimeter);

			//. - ссылка на текущий каталог
			//.. - ссылка на родительский каталог

			Directory.SetCurrentDirectory("..\\..");
			string currentDirector = Directory.GetCurrentDirectory();
			Console.WriteLine(currentDirector);

			string filename = "NoteBook.txt";
			string cmd = $"{currentDirector}\\{filename}";

#if WRITE_TO_FILE // На самом деле очень просто, я когда пытался делать сильно заморачивался....
			
			StreamWriter sw = new StreamWriter(filename,true);

			sw.WriteLine(delimeter);

			for(int i = 0;i < group.Length; i++)
			{
				sw.WriteLine($"{group[i]}\n");
			}

			sw.Close();

			//Process.Start("NoteBook.txt",filename);
			System.Diagnostics.Process.Start("notepad", cmd);
#endif


#if READ_FROM_FILE // тоже довольно просто
			StreamReader sr = new StreamReader(filename);
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
			System.Diagnostics.Process.Start("notepad", cmd);


			save(group, "group2.txt");
#endif
			Human[] groupt = Load("group.txt");
			for (int i = 0; i < group.Length; i++)
			{
                Console.WriteLine();
            }
		}

		static void save(Human[] group,string filename)
		{
			Directory.SetCurrentDirectory("..\\..");
			string currentDirector = Directory.GetCurrentDirectory();

			string cmd = $"{currentDirector}\\{filename}";

			StreamWriter sw = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine($"{group[i].GetType()}:\n{group[i]};");
			}
			sw.Close();
			

			System.Diagnostics.Process.Start("notepad", cmd);

		}

		static Human[] Load(string filename)
		{
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				string[] values = buffer.Split(';', ',');
				group.Add(HumanFactory(values[0]));
			}
			sr.Close();
			return group.ToArray();
		}
		static Human HumanFactory(string type)
		{
			Human human = null;
			if(type == typeof(Academy.Student).ToString())
			{
				human = new Student("", "", "", 0, "", "", 0, 0);
			}

			if (type == typeof(Academy.Teacher).ToString())
			{
				human = new Teacher("", "", "", 0, "", 0);
			}
			if (type == typeof(Academy.Graduate).ToString())
			{
			    human = new Graduate("", "", "", 0, "","", 0,0,"");
			}
			return human;
		}
	}
}
