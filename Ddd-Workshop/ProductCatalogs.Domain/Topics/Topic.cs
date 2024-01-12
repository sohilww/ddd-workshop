using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Topics
{
    public class Topic : AggregateRoot<TopicKey>
    {
        public Topic(TopicKey key, string title, ExpertiseLevel expertiseLevel)
        {
            Id = key;
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