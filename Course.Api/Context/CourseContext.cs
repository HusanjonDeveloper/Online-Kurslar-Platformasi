using Course.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Course.Api.Context;

public class CourseContext : DbContext
{
   public CourseContext(DbContextOptions<CourseContext> options) : base(options)
   {
      Database.EnsureCreated();
      Database.Migrate();
   }


   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      optionsBuilder.UseNpgsql("User ID=localhost;Password=20010410;Host=localhost;Port=5432;Database=Course;");
   }
}