using System;
using System.Text;

/// 과제 1: 부분 클래스 기본 문법
/*Person person = new Person();
person.Name = "홍길동";
person.Age = 25;
person.Print();
public partial class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
public partial class Person
{
    public void Print()
    {
        Console.WriteLine($"{Name}: {Age}");
    }
}*/
///과제 2: 부분 클래스 사용 예제
/*Hello hello = new Hello();
hello.Hi();
hello.Bye();
public partial class Hello
{
    public void Hi()
    {
        Console.WriteLine("안녕하세요.");
    }
}
public partial class Hello
{
    public void Bye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}*/
/// 과제 3: 정적 클래스 기본 문법
/*int sum = Calculator.Add(10, 20);
int diff = Calculator.Subtract(30, 10);
int product = Calculator.Multiply(5, 6);
Console.WriteLine($"덧셈:{sum}");
Console.WriteLine($"뺼셈:{diff}");
Console.WriteLine($"곱셈:{product}");
public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b; 
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}*/
///과제 4: 유틸리티 클래스 만들기
/*string Text = "Hello World ";
Console.WriteLine(StringHelper.CleanAndUpper(Text));
Console.WriteLine(StringHelper.Reverse("Hello"));
Console.WriteLine(StringHelper.IsNullOrEmpty(""));
public static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.Trim().ToUpper();
    }
    public static string Reverse(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);
    }
}*/
///과제 5: 닷넷의 정적 클래스 예시
/*double sqrt = Math.Sqrt(16);
double pow = Math.Pow(2,3);
int Max = Math.Max(10, 20);
int Min = Math.Min(10, 20);
Console.WriteLine($"제곱근: {sqrt}");
Console.WriteLine($"거듭제곱: {pow}");
Console.WriteLine($"최댓값: {Max}");
Console.WriteLine($"최솟값: {Min}");*/
///과제 6: StringBuilder의 메서드 체이닝
/*StringBuilder sb1 = new StringBuilder();
sb1.Append("Hello");
sb1.Append(" ");
sb1.Append("World");
string result1 = sb1.ToString();

String result2 = new StringBuilder()
   .Append("Hello")
   .Append(" ")
   .Append("World")
    .ToString();
Console.WriteLine(result1);
Console.WriteLine(result2);
*/
///과제 7: 메서드 체이닝 직접 구현하기
/*string message = new MessageBuilder()
    .AddText("안녕하세요!")
    .AddLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요.")
    .bulid();
Console.WriteLine(message);
public class MessageBuilder
{
    private string _message = "";
    public MessageBuilder AddText(string text)
    {
        _message += text;
        return this;
    }
    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }
    public MessageBuilder AddLine()
    {
        _message += "\n";
        return this;
    }
    public string bulid()
    {
        return _message; 
    }
}*/
///과제 8: 불변 객체와 메서드 체이닝
/*Point point = new Point(0, 0)
    .MoveBy(10, 10)
    .MoveBy(20,20)
    .MoveBy(30, 30);
Console.WriteLine(point);

public class Point
{
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y; 
    }
    public Point MoveBy(int dx, int dy)
    {
        return new Point(X+dx, Y+dy);
    }
    public override string ToString()
    {
        return $"({X}. {Y} )";
    }
}*/
///과제 9: 문자열 메서드 체이닝
/*string text = "  Hello World  ";

string result = text
    .Trim()           
    .ToLower()       
    .Replace(" ", "_");

Console.WriteLine(result);*/
///과제 10: 가변 형식
/*MutableCircle circle = new MutableCircle(10);
Console.WriteLine($"반지름: {circle.Radius}");

circle.Radius = 20; 
Console.WriteLine($"반지름: {circle.Radius}");

public class MutableCircle
{
    public int Radius { get; set; }

    public MutableCircle(int radius)
    {
        Radius = radius;
    }
}*/
///과제 11: 불변 형식
/*Player player = new Player("용사", 1);
Player player1 = player.levelup();
Console.WriteLine($"player1: {player.Name}, 레벨 {player.Level}");
Console.WriteLine($"player2: {player1.Name}, 레벨 {player1.Level}");
public class Player
{
    public readonly string Name;
    public readonly int Level;
    
    public Player(string name, int level)
    {
        Name = name;
        Level = level; 
    }
    public  Player levelup()
    {
        return new Player(Name, Level+1);
    }
}*/
///과제 13: 닷넷의 불변 형식 예시
/*string org = "Hello";
string mof = org.ToUpper();
Console.WriteLine($"원본: {org}");
Console.WriteLine($"수정본: {mof}");*/
///과제 14: 종합 - 부분 클래스로 게임 캐릭터 구현
/*Character hero = new Character("용사");
Console.WriteLine($"{hero.Name} - 레벨: {hero.Level}, 체력: {hero.Health}");
hero.TakeDamage(30);
hero.Heal(10);
public partial class Character
{
    private readonly string _name;
    private int _health;
    private int _level;

    public string Name => _name;
    public int Health => _health;
    public int Level => _level;

    public Character(string name)
    {
        _name = name;
        _health = 100;
        _level = 1;
    }
}
public partial class Character
{
    public void TakeDamage(int damage)
    {
        _health -= damage;
        if(_health <0)
        {
            _health = 0;
        }
        Console.WriteLine($"{_name}이(가) {damage}의 피해를 입음. 남은 체력: {_health}");
    }
    public void Heal(int heal)
    {
        _health += heal;
        Console.WriteLine($"{_name}이(가) {heal}만큼 회복함. 현재 체력: {_health}");
    }
}*/
///과제 15: 종합 - 정적 클래스로 유틸리티 만들기
/*int damage = GameHelper.CalculateDamage(10, 5);
bool alive = GameHelper.IsAlive(50);
string status = GameHelper.GetHealthStatus(30, 100);

Console.WriteLine($"계산된 데미지: {damage}");
Console.WriteLine($"생존 여부: {alive}");
Console.WriteLine($"체력 상태: {status}");

public static class GameHelper
{
    public static int CalculateDamage(int baseDamage, int level)
    {
        return baseDamage + (level * 5);
    }

    public static bool IsAlive(int health)
    {
        return health > 0;
    }

    public static string GetHealthStatus(int health, int maxHealth)
    {
        if (maxHealth <= 0)
        {
            return health > 0 ? "오류" : "사망";
        }

        double ratio = (double)health / maxHealth;

        if (ratio >= 0.7)
        {
            return "양호";
        }
        else if (ratio >= 0.3)
        {
            return "주의";
        }
        else if (ratio > 0)
        {
            return "위험";
        }
        else
        {
            return "사망";
        }
    }
}*/
///과제 16: 종합 - 불변 형식과 메서드 체이닝 결합

Vector2D result = new Vector2D(1, 1)
    .Add(2,3)
    .Multi(2)
    .Add(-1,-2);
Console.WriteLine($"결과 벡터: {result}");
public class Vector2D
{
    public readonly double X;
    public readonly double Y;

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public Vector2D Add(double x, double y)
    {
        return new Vector2D(X + x, Y + y);
    }
    public Vector2D Multi(double scalar)
    {
        return new Vector2D(X * scalar, Y * scalar);
    }
    public override string ToString()
    {
        return $"({X},{Y})";
    }
}