using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions;

public class SpecificTime : ValueObject
{
    public SpecificTime(TimeSpan startTime, TimeSpan endTime)
    {
        GuardForDateValidate(startTime, endTime);
        StartTime = startTime;
        EndTime = endTime;
    }

    public TimeSpan StartTime { get;private set; }
    public TimeSpan EndTime { get;private set; }

    public void GuardForDateValidate(TimeSpan startTime, TimeSpan endTime)
    {
        if (endTime <= startTime) throw new Exception("Not Valid");
    }
}