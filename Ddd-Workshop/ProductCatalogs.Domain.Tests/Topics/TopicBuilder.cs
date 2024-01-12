using ProductCatalogs.Domain.Topics;

namespace ProductCatalogs.Domain.Tests.Topics;

public class TopicBuilder
{
    private int _id = 1;
    private string _title = "Math";
    private ExpertiseLevel _expertiseLevel = ExpertiseLevel.Beginner;

    private TopicBuilder() { }

    public static TopicBuilder New() => new();

    public TopicBuilder WithId(int id)
    {
        _id = id;
        return this;
    }

    public TopicBuilder WithTitle(string title)
    {
        _title = title;
        return this;
    }

    public TopicBuilder WithExpertiseLevel(ExpertiseLevel level)
    {
        _expertiseLevel = level;
        return this;
    }

    public Topic Build()
    {
        var topicId = new TopicId(_id);
        return new Topic(topicId, _title, _expertiseLevel);
    }
}