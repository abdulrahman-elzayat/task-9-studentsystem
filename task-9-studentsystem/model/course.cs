using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text;

namespace task_9_studentsystem.model
{
    internal class course
    {
        public int courseId { get; set; }
        [Column(TypeName ="Varchar(80)")]
        public string name { get; set; }
        public string? description { get; set; }
        public int startDate { get; set; }
        public int endDate { get; set; }
        public decimal price { get; set; }

        public int studentId { get; set; }
        [ForeignKey("studentId")]
        public  student student { get; set; }
        ICollection<student> students { get; set; }
        ICollection<homework> homeworks { get; set; }

    }
}
