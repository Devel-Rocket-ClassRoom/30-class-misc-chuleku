using System;
Console.WriteLine("=== 초기 화폐 ===");
Money money = new Money(100, 50);
Console.WriteLine($"지갑: {money}");
Console.WriteLine();
Console.WriteLine("=== 화폐 추가 ===");
Console.WriteLine($"추가 후: {money.Add(50,30)}");
Console.WriteLine($"원본 지갑: {money}");
Console.WriteLine();
Console.WriteLine("=== 화폐 차감 ===");
Console.WriteLine($"차감 후: {money.Subtract(20,30)}");
Console.WriteLine($"원본 지갑: {money}");
Console.WriteLine();
Console.WriteLine("=== 메서드 체이닝 ===");
Money Nmoney = money.Add(50, 30).Subtract(30, 50);
Console.WriteLine($"결과: {Nmoney}");


public class Money
{
    public int Gold { get; }
    public int Silver { get; }
    public Money(int gold, int silver)
    {
        Gold = Math.Max(0, gold);
        Silver = Math.Max(0, silver);
    }

    public Money Add(int gold,int silver)
    {
        return new Money(Gold+gold,Silver+silver);
    }
    public Money Subtract(int gold, int silver)
    {
        int newGold = Math.Max(0, Gold - gold);
        int newSilver = Math.Max(0, Silver - silver);

        return new Money(newGold, newSilver);
    }
    public override string ToString()
    {
        return $"{Gold}골드 {Silver}실버";
    }
}