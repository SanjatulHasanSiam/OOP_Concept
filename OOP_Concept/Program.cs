using OOP_Concept;

class Program
{
	static void Main()
	{
		
		Teacher teacher = new Teacher("Abul", "Hasan",50001);
		Student student1 = new Student("Sanjatul", "Hasan",1001);
		Student student2 = new Student("Hasan", "Ahmed", 1002);
		Course math = new Course("MATH101", "Introduction to Mathematics");
		Course english = new Course("ENG202", "English Fundamentals");

		// Polymorphism: Marking attendance
		teacher.Attendance(math, DateTime.Now.AddDays(-3));
		student1.Attendance(math, DateTime.Now.AddDays(-3));
		student2.Attendance(math, DateTime.Now.AddDays(-3));

		teacher.Attendance(english, DateTime.Now.AddDays(-2));
		student2.Attendance(english, DateTime.Now.AddDays(-2));
		
		math.AttendaceSheet();
		Console.WriteLine();
		english.AttendaceSheet();

		Console.ReadLine();
	}
}