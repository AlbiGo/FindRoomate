// See https://aka.ms/new-console-template for more information
using FIndMeARoomatate.BusinessLayer;
using FIndMeARoomatate.DataLayer.DatabaseContext;
using FIndMeARoomatate.DataLayer.Entities;
using FIndMeARoomatate.DataLayer.Repositories;

Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Menu");
Console.WriteLine("1 - Register");
Console.WriteLine("2 - Get All students");
Console.WriteLine("3 - Log In");
Console.WriteLine("4 - My Profile");

int choice =  int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        {
            //Register
            var studentService = new StudentService();
            studentService.RegisterStudent();

            break;
        }
    case 2: 
        {
            //Print all students
            var studentService = new StudentService();
            var students = new List<Student>();
            students = studentService.GetStudents();

            foreach(var s in students)
            {
                Console.WriteLine(s.Name + " " + s.Surname + " " + s.Address + " " + s.Gender);
            }

            break;
        }
    case 3:
        {
            //Get Log in Credentials
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();

            Console.WriteLine("Enter Password");
            var Password = Console.ReadLine();
            //Register
            var studentService = new StudentService();
            studentService.LogIn(Email, Password);

            break;
        }
    case 4:
        {
            //Get My Profile
            //Get Log in Credentials
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();

            //Register
            var studentService = new StudentService();
            studentService.GetMyProfile(Email);
            break;
        }
}


Console.WriteLine("--------------------------------------------------");


