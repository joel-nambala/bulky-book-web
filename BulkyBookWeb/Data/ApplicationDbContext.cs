using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }
    }
}
