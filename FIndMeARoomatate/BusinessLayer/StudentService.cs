using FIndMeARoomatate.DataLayer.Entities;
using FIndMeARoomatate.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomatate.BusinessLayer
{
    public class StudentService
    {
        #region Business Layer

        //Student Business Logic

        //Get All students
        public List<Student> GetStudents()
        {
            var studentRepo = new StudentRepository();
            var students = studentRepo.GetAllStudent();
            return students;
        }

        //Register Student
        public void RegisterStudent()
        {
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

            //Add student
            var studentRepository = new StudentRepository();
            studentRepository.AddStudent(student);
        }

        //Log in
        public void LogIn(string email, string password)
        {
            //Create Repository
            var studentRepository = new StudentRepository();


            //Get Al students
            var allStudents = studentRepository.GetAllStudent();

            //Check in database
            var student = allStudents
                .Where(p => p.Password == password &&
                            p.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase))//Ignore Case Password
                .FirstOrDefault();

            //Check the result
            if (student == null)
            {
                Console.WriteLine("Invalid Credentials");
                throw new Exception("Invalid Credentials"); //Returns nothing as method is void
            }

            Console.WriteLine("Log In successfull");
        }

        public void GetMyProfile(string email)
        {
            var studentRepository = new StudentRepository();

            var allStudents = studentRepository.GetAllStudent();
            
            var student = allStudents
                .Where(p => p.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase))//Ignore Case Password
                .FirstOrDefault();
            
            //Check the result
            if (student == null)
            {
                Console.WriteLine("Profile not exist");
                throw new Exception("Profile not exist"); //Returns nothing as method is void
            }
            else
            {
                //Print the result
                Console.WriteLine(student.Name + "   " + student.Surname + "    " + student.Address + "   " + student.Gender + "   " + student.Email + "  " + student.Password + "  " + student.Birthday);
            }
        }

        #endregion
    }
}
