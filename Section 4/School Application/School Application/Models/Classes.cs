using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace School_Application.Models
{
    [Table("ClTable")]
    public class Classes
    {
        [Key]
        public int ClassId { get; set; }
        [Required]
        public string ClassName { get; set; }

    }
}