using FluentAssertions;
using ProductCatalogs.Domain.ProductCatalogs;
using Xunit;

namespace ProductCatalogs.Domain.Tests
{
    //weekly
    //he can define session's time,topic,weekly price  for example every Friday at 6 pm math 
    //he can define daily session's with price and without and without topic 
    //he can define specific session that means session with datetime and topic and price

    public class SessionTests
    {
        [Fact]
        public void define_weekly_session_with_specific_time_and_multipleTime()
        {
            var money = MoneyFactory.Create(10);
            var count = 10;
            var session = new Session(money, DayOfWeekFactory.Create(DayOfWeek.Friday),count);

            session.Price.Should().Be(money);
            session.DayOfWeek.Should().Be(DayOfWeekFactory.Create(DayOfWeek.Friday));
            session.Count.Should().Be(count);
        }
    }
}
