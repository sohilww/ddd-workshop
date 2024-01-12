using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions;

public class SessionDayOfWeek : ValueObject
{
    public SessionDayOfWeek(DayOfWeek dayOfWeek)
    {
        DayOfWeek = dayOfWeek;
    }

    public DayOfWeek DayOfWeek { get; private set; }
}
