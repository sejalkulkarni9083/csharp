using System;
using System.Collections.Generic;
using System.Linq;
using LMSApp.Users;
using LMSApp.Interfaces;
using LMSApp.Singleton;


namespace LMSConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Instructor> instructors = new List<Instructor>();
            List<Course> courses = new List<Course>();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n========= LMS MAIN MENU =========");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Assign Instructor to Course");
                Console.WriteLine("6. View All Students");
                Console.WriteLine("7. View All Instructors");
                Console.WriteLine("8. View All Courses");
                Console.WriteLine("9. Send Notification");
                Console.WriteLine("10. Show System Configuration");
                Console.WriteLine("11. Exit");
                Console.WriteLine("=================================");

                Console.Write("Enter your choice: ");
                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent(students);
                        break;

                    case 2:
                        AddInstructor(instructors);
                        break;

                    case 3:
                        AddCourse(courses);
                        break;

                    case 4:
                        EnrollStudent(students, courses);
                        break;

                    case 5:
                        AssignInstructor(instructors, courses);
                        break;

                    case 6:
                        ViewStudents(students);
                        break;

                    case 7:
                        ViewInstructors(instructors);
                        break;

                    case 8:
                        ViewCourses(courses);
                        break;

                    case 9:
                        SendNotification();
                        break;

                    case 10:
                        ShowConfiguration();
                        break;

                    case 11:
                        exit = true;
                        Console.WriteLine("Exiting LMS...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddStudent(List<Student> students)
        {
            Console.Write("Student Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Name: ");
            string name = Console.ReadLine();

            students.Add(new Student(id, name));

            Console.WriteLine("Student added successfully.");
        }

        static void AddInstructor(List<Instructor> instructors)
        {
            Console.Write("Instructor Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Instructor Name: ");
            string name = Console.ReadLine();

            instructors.Add(new Instructor(id, name));

            Console.WriteLine("Instructor added successfully.");
        }

        static void AddCourse(List<Course> courses)
        {
            Console.Write("Course Id: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();

            Console.Write("Duration: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            Course course = new Course(courseId, courseName, duration);

            courses.Add(course);

            Console.WriteLine("Course added successfully.");
        }

        static void EnrollStudent(List<Student> students, List<Course> courses)
        {
            if (students.Count == 0 || courses.Count == 0)
            {
                Console.WriteLine("Students or Courses not available.");
                return;
            }

            Console.Write("Enter Student Id: ");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Student student = students.FirstOrDefault(s => s.Id == studentId);

            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Console.Write("Enter Course Id: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            Course course = courses.FirstOrDefault(c => c.CourseId == courseId);

            if (course == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }

            student.EnrollCourse(course);

            Console.WriteLine("Student enrolled successfully.");
        }

        static void AssignInstructor(List<Instructor> instructors, List<Course> courses)
        {
            if (instructors.Count == 0 || courses.Count == 0)
            {
                Console.WriteLine("Instructors or Courses not available.");
                return;
            }

            Console.Write("Enter Instructor Id: ");
            int instructorId = Convert.ToInt32(Console.ReadLine());

            Instructor instructor =
                instructors.FirstOrDefault(i => i.Id == instructorId);

            if (instructor == null)
            {
                Console.WriteLine("Instructor not found.");
                return;
            }

            Console.Write("Enter Course Id: ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            Course course =
                courses.FirstOrDefault(c => c.CourseId == courseId);

            if (course == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }

            instructor.AssignCourse(course);
            course.Instructor = instructor;

            Console.WriteLine("Instructor assigned successfully.");
        }

        static void ViewStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("\n----- Students -----");

            List<Person> persons = new List<Person>();

            foreach (var student in students)
            {
                persons.Add(student);
            }

            foreach (Person person in persons)
            {
                person.DisplayInfo(); // Runtime Polymorphism
            }
        }

        static void ViewInstructors(List<Instructor> instructors)
        {
            if (instructors.Count == 0)
            {
                Console.WriteLine("No instructors found.");
                return;
            }

            Console.WriteLine("\n----- Instructors -----");

            List<Person> persons = new List<Person>();

            foreach (var instructor in instructors)
            {
                persons.Add(instructor);
            }

            foreach (Person person in persons)
            {
                person.DisplayInfo(); // Runtime Polymorphism
            }
        }

        static void ViewCourses(List<Course> courses)
        {
            if (courses.Count == 0)
            {
                Console.WriteLine("No courses found.");
                return;
            }

            Console.WriteLine("\n----- Courses -----");

            foreach (var course in courses)
            {
                Console.WriteLine($"Course Id : {course.CourseId}");
                Console.WriteLine($"Course Name : {course.CourseName}");
                Console.WriteLine($"Duration : {course.Duration}");

                if (course.Instructor != null)
                {
                    Console.WriteLine(
                        $"Instructor : {course.Instructor.Name}");
                }
                else
                {
                    Console.WriteLine("Instructor : Not Assigned");
                }

                Console.WriteLine("--------------------------------");
            }
        }

        static void SendNotification()
        {
            Console.WriteLine("1. Email Notification");
            Console.WriteLine("2. SMS Notification");

            Console.Write("Choose option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter message: ");
            string message = Console.ReadLine();

            INotificationService notificationService = null;

            switch (option)
            {
                case 1:
                    notificationService = new EmailNotificationService();
                    break;

                case 2:
                    notificationService = new SmsNotificationService();
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            notificationService.SendNotification(message);
        }

        static void ShowConfiguration()
        {
            LMSConfigurationManager config =
                LMSConfigurationManager.GetInstance();

            Console.WriteLine("\n----- LMS Configuration -----");
            Console.WriteLine($"Institute : {config.InstituteName}");
            Console.WriteLine($"Version : {config.Version}");
            Console.WriteLine($"Admin Contact : {config.AdminContact}");
        }
    }
}