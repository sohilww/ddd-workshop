using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions
{
    public class Session : AggregateRoot<SessionKey>
    {
        public Session(SessionKey id,Money price, SessionDayOfWeek dayOfWeek, int count, SpecificTime specificTime)
        {
            Id = id;
            Price = price;
            DayOfWeek = dayOfWeek;
            Count = count;
            SpecificTime = specificTime;
        }

        public Money Price { get;private set; }
        public SessionDayOfWeek DayOfWeek { get;private set; }
        public int Count { get;private set; }
        public SpecificTime SpecificTime { get;private set; }
    }

    public class SpecificTime : ValueObject
    {
        public SpecificTime(TimeSpan startTime, TimeSpan endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeSpan StartTime { get;private set; }
        public TimeSpan EndTime { get;private set; }
    }
}