using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace School.Api.Data.Entities
{
    [Table("Departments")]
    public class DepartmentEntity
    {
        [Key]
        [Column("Id", Order = 0)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
