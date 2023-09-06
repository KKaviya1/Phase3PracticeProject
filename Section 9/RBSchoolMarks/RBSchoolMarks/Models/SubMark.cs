namespace RBSchoolMarks.Models
{
    public class SubMark
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public int SubjectMark { get; set; }
    }
}
