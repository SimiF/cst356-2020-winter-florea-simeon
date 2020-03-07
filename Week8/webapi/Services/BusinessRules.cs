public static class BusinessRules
{
    public static bool hasValidEmailAddress(Student student) => 
        student.EmailAddress.Contains('@');

    public static bool hasValidStudentId(Student student) =>
        student.StudentId != 0;

    public static bool isSpecial(Student student) => 
        student.StudentId % 2 != 0;
}