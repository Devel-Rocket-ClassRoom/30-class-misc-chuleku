using System;
Recipe bibim = new Recipe("비빔밥",2,5);
bibim.AddIngredient("밥");
bibim.AddIngredient("고추장");
bibim.AddIngredient("계란");
bibim.AddIngredient("시금치");
bibim.AddIngredient("당근");
bibim.PrintRecipe();
Console.WriteLine();
bibim.HasIngredient("계란");
bibim.HasIngredient("소고기");
Console.WriteLine();
Recipe sand = new Recipe("샌드위치",1,3);
sand.AddIngredient("빵");
sand.AddIngredient("햄");
sand.AddIngredient("치즈");
sand.PrintRecipe();
public partial class Recipe
{
    public string Name { get; }
    public int Serving { get; }
    public string[] _ingredient = new string[0];
    private int _Count;

    public Recipe(string Rname, int HowServing, int Maxingredient)
    {
        _Count = 0;
        Name = Rname;
        Serving = HowServing;
        _ingredient = new string[Maxingredient];
    }

}
public partial class Recipe
{
    public void AddIngredient(string ingerdient)
    {
        if (_Count < _ingredient.Length)
        {
            _ingredient[_Count] = ingerdient;
            _Count++;
        }
        else
        {
            Console.WriteLine("재료가 가득 찼습니다.");
        }
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"=== {Name} ({Serving}인분) ===");
        Console.WriteLine("재료:");
        for (int i = 0; i < _Count;i++)
        {
            Console.WriteLine($"    {i+1}. {_ingredient[i]}");
        }
    }
    public void HasIngredient(string ingredient)
    {
        bool checkingredient=false;
        for (int i = 0; i < _ingredient.Length; i++)
        {
            if (_ingredient[i] == ingredient)
            {
                checkingredient = true;
                break;
            }
        }
        Console.WriteLine($"{ingredient} 포합: {checkingredient}");

    }

}