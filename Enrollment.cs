namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-05-jeong98-dykstra1] - To set the grades for the students
    public enum Grade
    {
        A, B, C, D, F
    }
    //tinfo200:[2021-03-05-jeong98-dykstra1] - This is really just creating the data model the basket if I can say
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}