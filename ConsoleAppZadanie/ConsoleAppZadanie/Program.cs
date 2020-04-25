using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleAppZadanie
{
	class Program
	{
		class Subject
		{
			public string Name = "";
			public string Surname = "";
			public int Semester = 0;
		}
		static class Plan
		{
			static public int Size;
			static public List<Subject> SubjectSemester = new List<Subject>();
			static public void SubjectItems()
			{
				Console.Write("Размер массива = ");
				Size = Convert.ToInt32(Console.ReadLine());
				for (int i = 0; i < Size; i++)
				{
					Subject TempSubject = new Subject();
					Console.Write("Название предмета №" + i + " = ");
					TempSubject.Name = Console.ReadLine().ToString();
					Console.Write("Фамилия преподавателя №" + i + " = ");
					TempSubject.Surname = Console.ReadLine().ToString();
					bool hasLetters;
					do
					{
						Console.Write("Семестр №" + i + " = ");
						string t = Console.ReadLine();
						hasLetters = t.AsEnumerable().Any(ch => char.IsLetter(ch));
						if (!hasLetters)
							TempSubject.Semester = Convert.ToInt32(t);
						else
						{
							Console.Write("Номер семестра не должен содержать буквы. Только цифры. Повторите ввод номера семестра №" + i + " = ");
						}
					}
					while (hasLetters);
					SubjectSemester.Add(TempSubject);
				}
			}
			static void Main(string[] args)
			{
			}
		}
	}
}