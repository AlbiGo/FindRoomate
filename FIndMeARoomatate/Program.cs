// See https://aka.ms/new-console-template for more information
using FIndMeARoomatate.BusinessLayer;
using FIndMeARoomatate.DataLayer.DatabaseContext;
using FIndMeARoomatate.DataLayer.Entities;
using FIndMeARoomatate.DataLayer.Repositories;

Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Menu");
Console.WriteLine("1 - Register");
Console.WriteLine("2- Get All Stundets");
int choice = int.Parse(Console.ReadLine());



switch (choice)
{
    case 1:
        {

            
            var  studentService = new StudentService();
            studentService.RegisterStudent();



            break;
        }
        case 2:
        {

           var StudentService = new StudentService();
           var students  = new  List<Student>();
            
          students = StudentService.GetStudents();

            foreach (var s in students)
            {
                Console.WriteLine(s.Name + " "    + " " + s.Address + " " + s.Gender);
            }
               
            //Print all students
            break;
        }
}

Console.WriteLine("--------------------------------------------------");





