using System;



public class Money
{
    public int Gold { get; }
    public int Silver { get; }
    public Money(int gold, int silver)
    {
        Gold = gold;
        Silver = silver;
    }

    public Money Add(int gold,int silver)
    {
        return new Money(Gold+gold,Silver+silver);
    }
    public Money Subtract(int gold, int silver)
    {
        if (Gold < gold)
        {

        }
        else if (gold > 0)
        {
            return new Money(Gold - gold, Silver);
        }
        else if (Silver < silver)
        {
            
        }
        else if (Silver > 0) {
            return new Money(Gold, Silver - silver);
        }
        else
        {
           
        }
    }
}