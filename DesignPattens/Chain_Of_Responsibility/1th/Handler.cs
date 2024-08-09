namespace DesignPattens.Chain_Of_Responsibility._1th;

public interface IApprovalHandler
{
    void SetNextHandler(IApprovalHandler next);

    void Process(VacationRequest request);
}

public abstract class ApprovalHandler : IApprovalHandler
{
    private IApprovalHandler _next;

    public abstract void Process(VacationRequest request);

    public void SetNextHandler(IApprovalHandler next)
    {
        _next = next;
    }

    protected void CallNext(VacationRequest request)
    {
        if (_next != null)
            _next.Process(request);
    }
}


public class TeamLeaderApprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.Developer && request.TotalDays <= 3)
        {
            Console.WriteLine("Request has been approved by team leader");
        }
        else
        {
            CallNext(request);
        }
    }
}


public class TechnicalManagerApprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.TeamLeader || 
            request.Employee.JobTitle == JobTitle.Developer  && request.TotalDays > 3)
        {
            Console.WriteLine("Request has been approved by Technical Manager");
        }
        else
        {
            CallNext(request);
        }
    }
}

public class CTOpprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.TechnicalManager)
        {
            Console.WriteLine("Request has been approved by CTO");
        }
        else
        {
            CallNext(request);
        }
    }
}


public class CEOApprovalHandler : ApprovalHandler
{
    public override void Process(VacationRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.CTO)
        {
            Console.WriteLine("Request has been approved by CEO");
        }
        else
        {
            CallNext(request);
        }
    }
}
