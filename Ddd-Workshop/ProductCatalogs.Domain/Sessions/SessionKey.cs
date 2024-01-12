using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions;

public class SessionKey : Id<Guid>
{
    public SessionKey(Guid key)
    {
        DbId = key;
    }
}