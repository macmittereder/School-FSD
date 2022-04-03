using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using School.Api.Data.Entities;
using System;

namespace School.Api.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<CourseEntity> Courses => Set<CourseEntity>();
        public DbSet<DepartmentEntity> Departments => Set<DepartmentEntity>();
        public DbSet<StudentEntity> Students => Set<StudentEntity>();
        public DbSet<TeacherEntity> Teachers => Set<TeacherEntity>();

        public SchoolDbContext(DbContextOptions<SchoolDbContext> ctx) : base(ctx) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CourseEntity>();
            modelBuilder.Entity<DepartmentEntity>();
            modelBuilder.Entity<StudentEntity>();
            modelBuilder.Entity<TeacherEntity>();
        }
    }
}
