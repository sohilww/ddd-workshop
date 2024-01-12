using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions
{
    public class Session : AggregateRoot<ProductCatalogKey>
    {
        public Session(Money price, SessionDayOfWeek dayOfWeek, int count)
        {
            Price = price;
            DayOfWeek = dayOfWeek;
            Count = count;
        }

        public Money Price { get;private set; }
        public SessionDayOfWeek DayOfWeek { get;private set; }
        public int Count { get;private set; }
    }
}