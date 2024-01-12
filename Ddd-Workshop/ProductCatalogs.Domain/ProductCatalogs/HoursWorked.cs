using Ackee.Domain.Model;

public class HoursWorked : ValueObject
{
    public readonly Hours Hours;

    public HoursWorked(Hours hours)
    {
        this.Hours = hours;
    }
}