using System;
Console.WriteLine("=== Clamp 테스트 ===");
GameUtils.Clamp(-10, 0, 100);
GameUtils.Clamp(50, 0, 100);
GameUtils.Clamp(100, 0, 100);
Console.WriteLine();
Console.WriteLine("=== GetPercentage 테스트 ===");
GameUtils.GetPercentage(75, 100);
GameUtils.GetPercentage(30, 200);
Console.WriteLine();
Console.WriteLine("=== ISInRange 테스트 ===");
GameUtils.IsInRange(50, 0, 100);
GameUtils.IsInRange(-5, 0, 100);
GameUtils.IsInRange(150, 0, 100);

public class GameUtils
{

    public static void Clamp(int value, int min, int max)
    {
        int temp =value;
        if (value < min)
        {
            value = min;
        }
        else if (value > max)
        {
            value = max;
        }
        Console.WriteLine($"Clamp({temp},{min},{max}) = {value}");
    }
    public static void GetPercentage(int current, int max)
    {
        float temp = ((float)current / max) * 100;
        Console.WriteLine($"GetPercentage({current},{max}) = {temp:F0}%");
    }
    public static void IsInRange(int value, int min, int max)
    {
        bool check = (value >= min && value <= max);
        Console.WriteLine($"IsInRange({value}, {min}, {max}) = {check}");
    }
}
