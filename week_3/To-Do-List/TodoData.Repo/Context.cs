using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TodoData.Models;

namespace TodoData.Repos
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=(localdb)\\mssqllocaldb;Database=TodoListDb;Trusted_Connection=True;MultipleActiveResultSets=true";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
