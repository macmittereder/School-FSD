using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace School.Api.Data.Entities
{
    [Table("Courses")]
    public class CourseEntity
    {
        [Key]
        [Column("Id", Order = 0)]
        public int Id { get; set; }

        [MaxLength(25)]
        public string? Name { get; set; }
        
        [Required]
        [ForeignKey("Id")]
        public int TeacherId { get; set; }
        
        [MaxLength(4)]
        public string? StartTime { get; set; }
        
        [MaxLength(4)]
        public string? EndTime { get; set; }
        
        [Required]
        public int MaxSize { get; set; }
    }
}
