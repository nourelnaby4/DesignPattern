namespace DesignPattens.Chain_Of_Responsibility._1th;

public class VacationRequest
{
    public Employee Employee { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double TotalDays => EndDate.Subtract(StartDate).TotalDays;
}
