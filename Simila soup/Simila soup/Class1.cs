// written by Ibrahim
// 02/13/25
using System;

public enum FoodType { Soup, Stew, Gumbo }
public enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes }
public enum Seasoning { Spicy, Salty, Sweet }

public class SoupMaker
{
    public (FoodType, Ingredient, Seasoning) MakeSoup()
    {
        Console.WriteLine("Choose type: Soup, Stew, Gumbo");
        FoodType type = (FoodType)Enum.Parse(typeof(FoodType), Console.ReadLine(), true);

        Console.WriteLine("Choose ingredient: Mushrooms, Chicken, Carrots, Potatoes");
        Ingredient ingredient = (Ingredient)Enum.Parse(typeof(Ingredient), Console.ReadLine(), true);

        Console.WriteLine("Choose seasoning: Spicy, Salty, Sweet");
        Seasoning seasoning = (Seasoning)Enum.Parse(typeof(Seasoning), Console.ReadLine(), true);

        return (type, ingredient, seasoning);
    }
}
