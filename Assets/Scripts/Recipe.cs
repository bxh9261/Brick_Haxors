using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe
{
    string recipeName;
    List<string> ingredients;

    public Recipe(string p_recipeName, List<string> p_ingredients)
    {
        recipeName = p_recipeName;
        ingredients = p_ingredients;
    }

    public string RecipeName
    {
        get
        {
            return recipeName;
        }
        set
        {
            recipeName = value;
        }
    }

    public List<string> Ingredients
    {
        get
        {
            return ingredients;
        }
        set
        {
            ingredients = value;
        }
    }
}
