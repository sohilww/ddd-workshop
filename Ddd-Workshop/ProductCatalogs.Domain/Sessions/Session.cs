using Ackee.Domain.Model;
using ProductCatalogs.Domain.Topics;

namespace ProductCatalogs.Domain.Sessions
{
    public class Session : AggregateRoot<SessionKey>
    {
        public Session(SessionKey id, Money price, SessionDayOfWeek dayOfWeek, int count, SpecificTime specificTime, TopicKey topicKey)
        {
            Id = id;
            Price = price;
            DayOfWeek = dayOfWeek;
            Count = count;
            SpecificTime = specificTime;
            TopicKey = topicKey;
        }
        public TopicKey TopicKey { get; private set; }
        public Money Price { get; private set; }
        public SessionDayOfWeek DayOfWeek { get; private set; }
        public int Count { get; private set; }
        public SpecificTime SpecificTime { get; private set; }
    }
}