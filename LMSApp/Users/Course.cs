namespace LMSApp.Users;

public class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; }

    public int Duration { get; set; }

    public Instructor Instructor { get; set; }

    public Course(int id,string name)
    {
        CourseId=id;
        CourseName=name;
    }

    public Course(int id,string name,int duration)
    {
        CourseId=id;
        CourseName=name;
        Duration=duration;
    }
}