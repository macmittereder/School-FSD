using HotChocolate;
using School.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace School.Api.Graph.Types
{
    public class CourseType
    {
        private readonly CourseEntity courseEntity;

        [GraphQLName("id")]
        public int Id => courseEntity.Id;

        [GraphQLName("name")]
        public string? Name => courseEntity.Name;

        [GraphQLName("teacherId")]
        public int TeacherId => courseEntity.TeacherId;

        [GraphQLName("startTime")]
        public string? StartTime => courseEntity.StartTime;

        [GraphQLName("endTime")]
        public string? EndTime => courseEntity.EndTime;

        [GraphQLName("maxSize")]
        public int MaxSize => courseEntity.MaxSize;

        internal CourseType(CourseEntity courseEntity)
        {
            this.courseEntity = courseEntity;
        }
    }
}
