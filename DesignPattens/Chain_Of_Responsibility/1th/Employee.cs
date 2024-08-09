namespace DesignPattens.Chain_Of_Responsibility._1th;

public class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public DateOnly HireDate { get; set; }

    public JobTitle JobTitle { get; set; }

    public bool IsTerminated { get; set; }
}
