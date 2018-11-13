using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLiteDemo.Models
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<Todo> Todos { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
              : base(options)
        {
        }
    }
}
