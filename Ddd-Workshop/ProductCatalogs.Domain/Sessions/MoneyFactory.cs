
namespace ProductCatalogs.Domain.Sessions;

public static class MoneyFactory
{
    public static Money Create(decimal price)
    {
        return new Money(price);
    }
}

public class DayOfWeekFactory
{
    public static SessionDayOfWeek Create(DayOfWeek dayOfWeek)
    {
        return new SessionDayOfWeek(dayOfWeek);
    }
}