using FIndMeARoomatate.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.DataLayer.Models
{
    public class DormitoryStudent
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Student")] //Here must match
        public int StudentID { get; set; }
        public Student Student { get; set; } //Here name of object must
                                             //match with foreign key annotation name
                                             //(emrin brenda kllapave te foreign key)

        [ForeignKey("Dormitory")]
        public int DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }
    }
}
