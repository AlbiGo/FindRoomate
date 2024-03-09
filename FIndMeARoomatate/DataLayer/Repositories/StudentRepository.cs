﻿using FIndMeARoomatate.DataLayer.DatabaseContext;
using FIndMeARoomatate.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomatate.DataLayer.Repositories
{
    public class StudentRepository
    {
        public void AddStudent(Student student)
        {
            //DbContext Add Method
            var dbContext = new RoommateDBContext();
            dbContext.Students.Add(student);
            dbContext.SaveChanges();

        }
        //get All Students 
    
        public  List<Student> GetAllStudent()
        {
            var context = new RoommateDBContext();
            var students = context.Students.ToList();

            foreach (var s in students)
            {
                Console.WriteLine(s.Name + "         " + s.Surname + "        " + s.Address);
            }
            return students;

        }
        // Get By ID

        public Student FindByID(int id)
        {
            try
            {
                var dbContext = new RoommateDBContext();

                var student = dbContext.Students.Where(p => p.Id == id)
                    .FirstOrDefault();

                return student;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        //Update
        //Remove
        public void DeleteStudent(Student student)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Students.Remove(student);
                dbContext.SaveChanges();
                Console.WriteLine("Student removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Students.Update(student);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }

}

