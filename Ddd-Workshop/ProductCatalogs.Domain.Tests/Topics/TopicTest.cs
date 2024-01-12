using FluentAssertions;
using ProductCatalogs.Domain.Topics;
using Xunit;

namespace ProductCatalogs.Domain.Tests.Topics
{
    public class TopicTest
    {
        [Fact]
        public void Define_a_Topic()
        {
            var title = "Math";
            var topic = CreateTopic(title);

            topic.Should().NotBeNull();
            topic.Title.Should().Be(title);
        }

        private static Topic CreateTopic(string title)
        {
            var topic = new Topic(title);
            return topic;
        }
    }
}
