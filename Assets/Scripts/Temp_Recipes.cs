using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_Recipes : MonoBehaviour
{

    Recipe cake;
    Recipe breakfast;
    Recipe football;
    Recipe omelette;
    Recipe metal;

    Recipe current;

    List<Recipe> recipes;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        recipes = new List<Recipe>();

        cake = new Recipe("Red Velvet Cake", new List<string> { "Milk", "Flour", "Eggs" });
        recipes.Add(cake);
        breakfast = new Recipe("Balanced Breakfast", new List<string> { "Milk", "Bread", "Cereal", "Eggs" });
        recipes.Add(breakfast);
        football = new Recipe("Football Dinner", new List<string> { "Chips", "Meat", "Pop" });
        recipes.Add(football);
        omelette = new Recipe("Fancy Omelette", new List<string> { "Eggs", "Cheese", "Meat" });
        recipes.Add(omelette);
        metal = new Recipe("Delicious Metal and Glass", new List<string> { "Bottle", "Can" });
        recipes.Add(metal);

        current = recipes[Random.Range(0, 5)];
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //displays recipe
    void OnGUI()
    {
        string temp = "";
        temp += "Current recipe: " + current.RecipeName + "\n";
        for(int i = 0; i < current.Ingredients.Count; i++)
        {
            temp += current.Ingredients[i] + "\n";
        }

        GUI.Box(new Rect(0, 0, 200, 100), temp);
    }
}
