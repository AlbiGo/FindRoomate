// See https://aka.ms/new-console-template for more information
using FIndMeARoomatate.BusinessLayer;
using FIndMeARoomatate.DataLayer.DatabaseContext;
using FIndMeARoomatate.DataLayer.Entities;
using FIndMeARoomatate.DataLayer.Repositories;
using FindMeARoommate.BusinessLayer;

Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Welcome to Find Roomate Application!");

Console.WriteLine("--------------------------------------------------");

Console.WriteLine("Menu");
Console.WriteLine("1 - Register student");
Console.WriteLine("2 - Get All students");
Console.WriteLine("3 - Register dormitories");
Console.WriteLine("4 - Get All dormitories");
Console.WriteLine("5 - Register application");
Console.WriteLine("6 - Get All applications");
Console.WriteLine("7 - Register announcement");
Console.WriteLine("8 - Get All announcements");
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

    case 3:
        {
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();

            Console.WriteLine("Enter Password");
            var Password = Console.ReadLine();

            var studentService = new StudentService();
            studentService.LogIn(Email, Password);
            break;  
        }

    case 4:
        {
            //GetMyProfile
            Console.WriteLine("Enter Email");
            var Email = Console.ReadLine();

    
            var studentService = new StudentService();
            studentService.GetMyProfile(Email);
            break;
        }

        case 5:
        {
            Console.WriteLine("Enter Student Email");
            var Email = Console.ReadLine();
            var studentService = new AnnouncementService();
            studentService.AddAnnouncement(Email);
            break;
        }


        
           case 6:
                {  //Print all application
                    var applicationService = new ApplicationService();
                    var application = new List<Application>();
                    application = applicationService.GetApplications();
                    foreach (var a in application)
                    {
                        Console.WriteLine(a.AnnouncementID + "   " + a.Announcement + "    " + a.Status + "     " + a.StudentID + "      " + a.Applicant + "     " + a.ApplicationDate + "     " + a.IsActive);
                    }
                    break;
                }
                
case 8:
                {  //Print all   announcement



                    var announcementService = new AnnouncementService();
                  
                  var announcement = announcementService.GetAnnouncements ();
                    foreach (var a in announcement)
                    {
                        Console.WriteLine(a.StudentID + "   " + a.Title + "    " + a.Description + "     " + a.PublishedDate + "      " + a.AnnouncementOwner + "     " + a.IsSameGender + "     " + a.IsActive);
                    }
                    break;
                }


            }







        


Console.WriteLine("--------------------------------------------------");





