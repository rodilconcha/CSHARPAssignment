
using System;
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public LastName { get; set; }
    public int GradeId { get; set; }
    public Grade Grade { get; set; }
}

public class Grade
{
    public int GradeId { get; set; }
    public string GradeName { get; set; }
    public IList<Student>Students{ get; set; 
    }
   