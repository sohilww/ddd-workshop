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
            var topic = TopicBuilder.New()
                .WithTitle("Math")
                .WithExpertiseLevel(ExpertiseLevelType.Beginner)
                .Build();

            topic.Should().NotBeNull();
            topic.Title.Should().Be("Math");
            topic.ExpertiseLevel.Level.Should().Be(ExpertiseLevelType.Beginner);
            topic.IsActive.Should().BeTrue();
        }

        [Fact]
        public void Inactivate_a_Topic()
        {
            var topic = TopicBuilder.New().Build();

            topic.Should().NotBeNull();
            topic.IsActive.Should().BeTrue();

            topic.Inactivate();

            topic.IsActive.Should().BeFalse();

        }

        [Fact]
        public void Activate_an_inactive_Topic()
        {
            var inactiveTopic = CreateAnInactiveTopic();

            inactiveTopic.Activate();
        }

        private static Topic CreateAnInactiveTopic()
        {
            var topic = TopicBuilder.New().Build();
            topic.Inactivate();
            return topic;
        }
    }
}