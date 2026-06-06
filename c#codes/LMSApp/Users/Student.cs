using System.Runtime.InteropServices;

namespace LMSApp.Users;

public class Student : Person
{
    public List<Course> EnrolledCourses { get; set; }

    public Student(int id, string name) : base(id, name)
    {
        EnrolledCourses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        EnrolledCourses.Add(course);

    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Id : {Id}, Name : {Name}");
        Console.WriteLine("Enrolled Courses:");

        foreach(var course in EnrolledCourses)
        {
            Console.WriteLine (course.CourseName);
        }
    }

}