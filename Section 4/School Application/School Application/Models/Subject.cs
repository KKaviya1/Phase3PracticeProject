using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Application.Models
{
    [Table("SubTable")]
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }

    }
}