using FIndMeARoomatate.DataLayer.DatabaseContext;
using FIndMeARoomatate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomatate.DataLayer.Repositories
{
    public class ApplicationRepository
    {
        public void AddAnnouncement(Application application)
        { // DbContext Add Method
            var dbContext = new RoommateDBContext();
            dbContext.Applications.Add(application);
            dbContext.SaveChanges();
        }
        // Get All Student
        public List<Application> GetApplications()
        {
            var context = new RoommateDBContext();
            var applications = context.Applications.ToList();
            return applications;
        }
        // Get By ID
        public Application FindByID(int id)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                var application = dbContext.Applications
                    .Where(p => p.ID == id)
                    .FirstOrDefault();
                return application;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        //Update
        //Remove
        public void DeleteStudent(Application application)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Applications.Remove(application);
                dbContext.SaveChanges();
                Console.WriteLine("Student removed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message.ToString());
                throw ex;
            }
        }
        public void UpdateStudent(Application application)
        {
            try
            {
                var dbContext = new RoommateDBContext();
                dbContext.Applications.Update(application);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

        internal void AddApplication(Application application)
        {
            throw new NotImplementedException();
        }
    }
}
