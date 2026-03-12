using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace task_9_studentsystem.model
{
    public enum ContentTypeenum
    {
        Application,
        Pdf,
        Zip
    }
    internal class homework
    {
        public int homeworkId { get; set; }
        [Unicode(false)]
        public string content { get; set; }
        public ContentTypeenum contentType { get; set; }
        public int submissonTime { get; set; }
        public int studentId { get; set; }
        public int courseid { get; set; }
        [ForeignKey("courseid")]
        public course course { get; set; }

        public int studentid { get; set; }
        [ForeignKey("studentId")]
        public student student { get; set; }
    }

}
