using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace task_9_studentsystem.model
{

    internal class student
    {
        public int studentId { get; set; }
        [Column(TypeName = "Varchar(100)")]
        public string name { get; set; }
        [MaxLength(10)]
        [Unicode(false)]
        public string? phonenumber { get; set; }
        public DateTime registrediOn { get; set; }
        public DateTime? birthday { get; set; }
        public ICollection<course> courses { get; set; }
        public ICollection<homework> homeworks { get; set; }
    }
}
