using ProductCatalogs.Domain.Topics;

namespace ProductCatalogs.Domain.Tests.Topics;

public class TopicBuilder
{
    private Guid _id = Guid.NewGuid();
    private string _title = "Math";
    private ExpertiseLevelType _level = ExpertiseLevelType.Beginner;

    private TopicBuilder() { }

    public static TopicBuilder New() => new();

    public TopicBuilder WithId(Guid id)
    {
        _id = id;
        return this;
    }

    public TopicBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public TopicBuilder WithExpertiseLevel(ExpertiseLevelType level)
    {
        _level = level;
        return this;
    }

    public Topic Build()
    {
        var topicId = new TopicKey(_id);
        var expertiseLevel = new ExpertiseLevel(_level);
        return new Topic(topicId, _title, expertiseLevel);
    }
}