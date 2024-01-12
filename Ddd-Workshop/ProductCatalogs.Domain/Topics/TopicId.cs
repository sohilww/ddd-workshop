using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Topics;

public class TopicId : Id
{
    private readonly int _id;

    public TopicId(int id)
    {
        _id = id;
    }

    public override object GetIdValue()
    {
        return _id;
    }
}