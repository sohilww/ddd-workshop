using Ackee.Domain.Model;

public class Money : ValueObject
{
    protected readonly decimal Value;

    public Money()
        : this(0m)
    {
    }

    public Money(decimal value)
    {
        Value = value;
    }

    public Money Add(Money money)
    {
        return new Money(Value + money.Value);
    }

    public Money Subtract(Money money)
    {
        return new Money(Value - money.Value);
    }
}