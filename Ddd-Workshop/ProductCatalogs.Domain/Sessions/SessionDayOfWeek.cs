using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions;

public class SessionDayOfWeek : ValueObject
{
    private readonly DayOfWeek _dayOfWeek;

    public SessionDayOfWeek(DayOfWeek dayOfWeek)
    {
        _dayOfWeek = dayOfWeek;
    }
    public DayOfWeek DayOfWeek { get; set; }
}

public class InvalidRangeException : Exception
{
}