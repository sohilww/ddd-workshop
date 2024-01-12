using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Topics;

public class TopicKey : Id<Guid>
{
    public TopicKey(Guid id)
    {
        DbId = id;
    }
}