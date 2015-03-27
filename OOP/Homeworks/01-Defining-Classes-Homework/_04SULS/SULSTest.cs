using System;
using System.Collections.Generic;
using System.Linq;

namespace _04SULS
{
	class SULSTest
	{
		public static void Main (string[] args)
		{
			JuniorTrainer junTrain = new JuniorTrainer ("Junior", "Trainerov", 25);
			junTrain.CreateCourse ("Stupid Course");
			SeniorTrainer senTrain = new SeniorTrainer ("Senior", "Trainerov", 35);
			senTrain.DeleteCourse ("Stupid Course");
			OnlineStudent onlineStud = new OnlineStudent ("Online", "Studentov", 33, "00003", 5.07, "OOP");
			DropoutStudent droplio = new DropoutStudent("Drop", "Dropov", 20, "00025", 3, "Due to laziness");
			droplio.Reapply ();
			Console.WriteLine ("------------------------------------------");
			OnsiteStudent onsiteStud1 = new OnsiteStudent ("Onsite1", "Studentov", 24, "00001", 6, "OOP", 14);
			OnsiteStudent onsiteStud2 = new OnsiteStudent ("Onsite2", "Studentov", 20, "00010", 4.75, "OOP", 12);
			GraduateStudent graduateStud = new GraduateStudent ("Graduate", "Studentov", 30, "00002", 5.80);

			List<Person> people = new List<Person> () { junTrain, senTrain, onlineStud, droplio, 
				onsiteStud1, onsiteStud2, graduateStud };

			List<CurrentStudent> currentStudents = people.Where(p => p is CurrentStudent)
				.Cast<CurrentStudent>()
				.OrderBy(c => c.AverageGrade)
				.ToList();
			Console.WriteLine ("All current students ordered by average grade:\n");
			foreach (var student in currentStudents) {
				Console.WriteLine (student);
			}
		}
	}
}
