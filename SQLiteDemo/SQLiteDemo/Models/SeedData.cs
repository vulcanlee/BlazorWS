using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLiteDemo.Models
{
    static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                if (context.Todos.Any())
                {
                    return;   // DB has been seeded
                }

                context.Todos.AddRange(
                    new Todo() { Title = "Title1", HasCompleted = false },
                    new Todo() { Title = "Title2", HasCompleted = false },
                    new Todo() { Title = "Title3", HasCompleted = true },
                    new Todo() { Title = "Title4", HasCompleted = false }
                    );
                context.SaveChanges();
            }
        }
    }
}
