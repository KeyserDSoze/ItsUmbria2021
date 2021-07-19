using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS2021.Web.Api.First.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options) 
        {
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
