namespace ContosoUniversity.Models
{
public class Enrollment
{
    public int EnrollmentID { get; set; }
    public int CourseID { get; set; }
    public int StudentID { get; set; }
    public Grade? Grade { get; set; }

    public required Course Course { get; set; }
    public required Student Student { get; set; }
}

public enum Grade
{
    A, B, C, D, F
}
}