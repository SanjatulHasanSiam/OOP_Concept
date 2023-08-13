using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
	//Abstraction
	public abstract class Person
	{
		public string? firstName{get;set;}
		public string? lastName{get;set;}
		public int? id { get; set; }
        public Person(string firstName,string lastName,int id)
        {
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = id;
		}
		public abstract void Attendance(Course course,DateTime date);
		
    }
	//Inheritance
	class Teacher : Person
	{
        public Teacher(string firstname,string lastname,int id):base(firstname,lastname,id)
        {
            
        }
        public override void Attendance(Course course, DateTime date)
		{
			course.AddAttendance(this,date);
		}
	}
	//Inheritance
	class Student: Person
	{
		
        public Student(string firstName,string lastname,int id):base(firstName,lastname,id)
        {
			
        }

		public override void Attendance(Course course, DateTime date)
		{
			course.AddAttendance(this,date);
		}
	}
}
