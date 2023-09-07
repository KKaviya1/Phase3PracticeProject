using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudStatistics.Models
{
    [Table("StudStatistics")]
    public class StudentStatistics
    {
        [Key]
        public int StudentCount { get; set; }
        public Student MaxMarkStudent { get; set; }
        public Student MinMarkStudent { get; set; }
        public List<Student> StudentsWithLessThan50Marks { get; set; }
        public double AverageMark { get; set; }
    }
}