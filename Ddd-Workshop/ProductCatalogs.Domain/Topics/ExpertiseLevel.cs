using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Topics;

public class ExpertiseLevel : ValueObject
{

    public ExpertiseLevel(ExpertiseLevelType level)
    {
        Level = level;
    }
    public ExpertiseLevelType Level { get; private set; }

}