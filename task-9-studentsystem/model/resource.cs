using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace task_9_studentsystem.model
{
    public enum ResourceTypeenum
    {
        Video,
        Presentation,
        Document,
        Other
    }
    internal class resource
    {
        public int resourceId { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string name { get; set; }
        [Unicode(false)]
        public int URL { get; set; }
        public ResourceTypeenum ResourceType { get; set; }
        public int courseid { get; set; }
        [ForeignKey("courseid")]
        public course course { get; set; }
    }
}
