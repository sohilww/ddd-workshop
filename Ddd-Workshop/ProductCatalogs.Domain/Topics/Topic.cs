using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Topics
{
    public class Topic : AggregateRoot<TopicId>
    {
        public Topic(TopicId id, string title, ExpertiseLevel expertiseLevel)
        {
            Id = id;
            Title = title;
            ExpertiseLevel = expertiseLevel;
            IsActive = true;
        }

        public string Title { get; private set; }
        public ExpertiseLevel ExpertiseLevel { get; private set; }
        public bool IsActive { get; private set; }

        public void Inactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }
    }
}
