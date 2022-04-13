using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace School.Api.Data.Entities
{
    [Table("Teachers")]
    public class TeacherEntity
    {
        [Key]
        [Column("Id", Order = 0)]
        public int Id { get; set; }
        
        [MaxLength(25)]
        public string FirstName { get; set; }
        
        [MaxLength(25)]
        public string LastName { get; set; }
        
        public DateTime? DOB { get; set; }
        
        public string? Sex { get; set; }
        
        [ForeignKey("Id")]
        public int DepartmentId { get; set; }
    }
}
