using FIndMeARoomatate.DataLayer.Entities;
using FindMeeARoomMate.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndMeARoomatate.DataLayer.DatabaseContext
{
    public class RoommateDBContext : DbContext
    {
        public RoommateDBContext() { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<DormitoryStudent> DormitoryStudents { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set your own connection string
            optionsBuilder.UseSqlServer("Data Source=WINDOWS-4PGG12B;Initial Catalog=FindARoomate;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
