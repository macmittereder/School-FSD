using HotChocolate;
using System;
using System.Collections.Generic;
using System.Text;
using School.Api.Data.Entities;

namespace School.Api.Graph.Types
{
    public class TeacherType
    {
        private readonly TeacherEntity teacherEntity;

        [GraphQLName("id")]
        public int Id => teacherEntity.Id;

        [GraphQLName("firstName")]
        public string FirstName => teacherEntity.FirstName;

        [GraphQLName("lastName")]
        public string LastName => teacherEntity.LastName;

        [GraphQLName("dob")]
        public DateTime? DOB => teacherEntity.DOB;

        [GraphQLName("sex")]
        public string Sex => teacherEntity.Sex;

        [GraphQLName("departmentId")]
        public int DepartmentId => teacherEntity.DepartmentId;

        internal TeacherType(TeacherEntity teacherEntity)
        {
            this.teacherEntity = teacherEntity;
        }
    }
}
