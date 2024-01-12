using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions;

public class HoursWorked : ValueObject
{
    public readonly Hours Hours;

    public HoursWorked(Hours hours)
    {
        this.Hours = hours;
    }
}