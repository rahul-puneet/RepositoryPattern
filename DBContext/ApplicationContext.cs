using LearnRepositoryPattern.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnRepositoryPattern.DBContext
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> dBContext) : base(dBContext)
        {

        }

        public virtual DbSet<User> Users { get; set; }
    }
}
