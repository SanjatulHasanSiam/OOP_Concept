using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
    //Encapsolution - Course with corresponding attendance
	public class Course
	{
		public string? courseId { get; set; }
		public string? courseName { get; set; }
        private Dictionary<Person, List<DateTime>> attendanceRecords = new Dictionary<Person, List<DateTime>>();
        public Course(string courseId,string courseName)
        {
            this.courseId = courseId;
            this.courseName = courseName;
        }
        public void AddAttendance(Person person,DateTime dateTime)
        {
            if (!attendanceRecords.ContainsKey(person))
            {
                attendanceRecords[person] = new List<DateTime>();
            }
            attendanceRecords[person].Add(dateTime);
        }
        public void AttendaceSheet()
        {
            Console.WriteLine($"Attendance: {courseName}");
			foreach (var attendance in attendanceRecords)
			{
				Console.Write($"{attendance.Key.firstName} {attendance.Key.lastName} ({(attendance.Key is Student ? "ID: " + ((Student)attendance.Key).id : "Teacher: "+ ((Teacher)attendance.Key).id)}): ");
				foreach (var date in attendance.Value)
				{
					Console.Write($"{date.ToShortDateString()} ");
				}
				Console.WriteLine();
			}
		}

    }
}
