

using FluentAssertions;
using ProductCatalogs.Domain.Sessions;
using ProductCatalogs.Domain.Topics;
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
        public void define_weekly_session_with_specific_time_and_count_and_topic_key()
        {

            var id = new SessionKey(Guid.NewGuid());
            var topicKey = new TopicKey(Guid.NewGuid());
            var money = MoneyFactory.Create(10);
            var count = 10;
            var startTime = new TimeSpan(12, 0, 0);
            var endTime = new TimeSpan(13, 0, 0);
            var specificTime = new SpecificTime(startTime, endTime);
            var session = new Session(id, money, DayOfWeekFactory.Create(DayOfWeek.Friday), count, specificTime, topicKey);

            session.Id.Should().Be(id);
            session.TopicKey.Should().Be(topicKey);
            session.Price.Should().Be(money);
            session.DayOfWeek.Should().Be(DayOfWeekFactory.Create(DayOfWeek.Friday));
            session.Count.Should().Be(count);
            session.SpecificTime.Should().Be(specificTime);
        }
    }
}
