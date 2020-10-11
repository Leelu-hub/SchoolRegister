using Microsoft.EntityFrameworkCore;
using SchoolRegister.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolRegister.Repository
{
    public class SchoolRegisterContext:DbContext
    {
        public SchoolRegisterContext(DbContextOptions<SchoolRegisterContext>options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
