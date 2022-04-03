using HotChocolate;
using School.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Api.Graph.Types
{
    public class StudentType
    {
        private readonly StudentEntity studentEntity;

        [GraphQLName("id")]
        public int Id => studentEntity.Id;

        [GraphQLName("firstName")]
        public string FirstName => studentEntity.FirstName;

        [GraphQLName("lastName")]
        public string LastName => studentEntity.LastName;

        [GraphQLName("dob")]
        public DateTime DOB => studentEntity.DOB;

        [GraphQLName("sex")]
        public string Sex => studentEntity.Sex;

        internal StudentType(StudentEntity studentEntity)
        {
            this.studentEntity = studentEntity;
        }
    }
}
