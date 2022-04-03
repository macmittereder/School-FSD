using HotChocolate;
using School.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Api.Graph.Types
{
    public class DepartmentType
    {
        private readonly DepartmentEntity departmentEntity;

        [GraphQLName("id")]
        public int Id => departmentEntity.Id;

        [GraphQLName("name")]
        public string Name => departmentEntity.Name;

        internal DepartmentType(DepartmentEntity departmentEntity)
        {
            this.departmentEntity = departmentEntity;
        }
    }
}
