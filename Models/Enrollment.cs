namespace CodigoSistClases.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public DateTime Date { get; set; }

        //Foreign key with Course
        public int CourseID { get; set; }
        public Course Course { get; set; }


        //Foreign key with Student
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
