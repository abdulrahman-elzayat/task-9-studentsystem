using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;
using task_9_studentsystem.model;

namespace task_9_studentsystem.dataasess
{
    internal class studentDbContaxt : DbContext
    {
        public DbSet<student> studentes { get; set; }
        public DbSet<course> coursees { get; set; }
        public DbSet<homework> homeworkes { get; set; }
        public DbSet<resource> resourcees { get; set; }


        override  protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(" Data Source=.;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");
        }
    }
}
