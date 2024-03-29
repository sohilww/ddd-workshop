﻿using Ackee.Domain.Model;

namespace ProductCatalogs.Domain.Sessions;

public class Hours : ValueObject
{
    public readonly int Amount;

    public Hours(int amount)
    {
        this.Amount = amount;
    }

    public static Hours operator -(Hours left, Hours right)
    {
        return new Hours(left.Amount - right.Amount);
    }

}