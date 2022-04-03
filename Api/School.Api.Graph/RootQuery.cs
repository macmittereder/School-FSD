using HotChocolate;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
using School.Api.Data;
using School.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Api.Graph
{
    public class RootQuery
    {        
        [UseFiltering]
        [GraphQLName("courses")]
        public IQueryable<CourseEntity> GetCourses([ScopedService] SchoolDbContext db)
        {
            return db.Courses.AsNoTracking();
        }

        [UseFiltering]
        [GraphQLName("departments")]
        public IQueryable<DepartmentEntity> GetDepartments([ScopedService] SchoolDbContext db)
        {
            return db.Departments.AsNoTracking();
        }

        [UseFiltering]
        [GraphQLName("students")]
        public IQueryable<StudentEntity> GetStudents([ScopedService] SchoolDbContext db)
        {
            return db.Students.AsNoTracking();
        }

        [UseFiltering]
        [GraphQLName("teachers")]
        public IQueryable<TeacherEntity> GetTeachers([ScopedService] SchoolDbContext db)
        {
            return db.Teachers.AsNoTracking();
        }

        [UseFiltering]
        [GraphQLName("departmentTeachers")]
        public IQueryable<TeacherEntity> GetDepartmentTeachers(string departmentName, [ScopedService] SchoolDbContext db)
        {
            var department = db.Departments.Where(d => d.Name == departmentName).FirstOrDefault();
            return db.Teachers.Where(t => t.DepartmentId == department.Id).AsNoTracking();
        }
    }
}
