namespace DesignPattens.Chain_Of_Responsibility._1th;

public class ChainResponsiplityExecuet
{
    public void Run()
    {
        /*
        Team leader can approve Developer Request up to 3 days otherwise it goes to Technical Manager
        Technical Manager can approve Developer Request with more than days and Team Leader request as well
        CTO can approve Technical Manager requests
        CEO can aprrove CTO requests
         */

        var employee = new Employee
        {
            Id = 1,
            Name = "Ahmed Nour",
            DateOfBirth = new DateOnly(2000, 8, 25),
            HireDate = new DateOnly(2021, 3, 1),
            JobTitle = JobTitle.TeamLeader
        };

        var request = new VacationRequest
        {
            Employee = employee,
            StartDate = DateTime.Today.AddDays(5),
            EndDate = DateTime.Today.AddDays(15)
        };


        var teamLeaderHandler = new TeamLeaderApprovalHandler();
        var technicalManagerHandler = new TechnicalManagerApprovalHandler();
        var ctoHandler = new CTOpprovalHandler();
        var ceoHandler = new CEOApprovalHandler();

        teamLeaderHandler.SetNextHandler(technicalManagerHandler);
        technicalManagerHandler.SetNextHandler(ctoHandler);
        ctoHandler.SetNextHandler(ceoHandler);

        teamLeaderHandler.Process(request);
    }
}
  