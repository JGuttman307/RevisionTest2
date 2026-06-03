using Microsoft.EntityFrameworkCore;
using RevTest2.Models;

namespace RevTest2;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<Student> Students { get; set; } 
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //modelBuilder.HasDefaultSchema(configuration["DB:DefaultSchema"]);
        modelBuilder.Entity<Student>(opt =>
        {
            opt.ToTable("Students");
            opt.HasKey(s => s.Id);
            opt.Property(s => s.FirstName).IsRequired().HasMaxLength(50);
            opt.Property(s => s.LastName).IsRequired().HasMaxLength(50);
            opt.Property(s => s.Pesel).HasColumnType("char(11)");
            opt.Property(s => s.Phone).HasColumnType("char(9)");
        });
        modelBuilder.Entity<Course>(opt =>
        {
            opt.ToTable("Courses");
            opt.HasKey(e => e.Id);
            opt.Property(s => s.Name).IsRequired().HasMaxLength(50);
        });
        modelBuilder.Entity<StudentCourse>(opt =>
        {
            opt.ToTable("StudentCourses");
            opt.HasKey(e => new { e.StudentId, e.CourseId });
            opt.Property(e => e.Grade).HasColumnType("decimal(2,1)");

            opt.HasOne(s => s.Student).WithMany(s => s.StudentCourses).HasForeignKey(s => s.StudentId);
            opt.HasOne(s => s.Course).WithMany(s => s.StudentCourses).HasForeignKey(s => s.CourseId);
        });
    }

}