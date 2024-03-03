// See https://aka.ms/new-console-template for more information
using FIndMeARoomatate.DataLayer.DatabaseContext;
using FIndMeARoomatate.DataLayer.Entities;

Console.WriteLine("Welcome to Find Roomate Application!");

//Retrieve and print all student records
var context = new RoommateDBContext();
var students = context.Students.ToList();

foreach (var s in students)
{
    Console.WriteLine(s.Name + "    " + s.Surname + "   " + "   " + s.Address);
}

//Add a dormitory
//Take data from UI (Console)
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Register");

var student = new Student();

Console.WriteLine("Enter Name");
student.Name = Console.ReadLine();

Console.WriteLine("Enter Surname");
student.Surname = Console.ReadLine();

Console.WriteLine("Enter Address");
student.Address = Console.ReadLine();

Console.WriteLine("Enter Gender");
student.Gender = Console.ReadLine();

Console.WriteLine("Enter Email");
student.Email = Console.ReadLine();

Console.WriteLine("Enter Password");
student.Password = Console.ReadLine();

//Add student to db

//Test Commit