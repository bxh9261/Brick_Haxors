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

        cake = new Recipe("Red Velvet Cake", new List<string> { "Milk", "Flour", "Egg" });
        recipes.Add(cake);
        breakfast = new Recipe("Balanced Breakfast", new List<string> { "Milk", "Bread", "Cereal", "Egg" });
        recipes.Add(breakfast);
        football = new Recipe("Football Dinner", new List<string> { "Chips", "Meat", "Pop" });
        recipes.Add(football);
        omelette = new Recipe("Fancy Omelette", new List<string> { "Egg", "Cheese", "Meat" });
        recipes.Add(omelette);
        metal = new Recipe("Delicious Metal and Glass", new List<string> { "Bottle", "Can" });
        recipes.Add(metal);

        current = recipes[Random.Range(0, 5)];
    }
    // Update is called once per frame
    void Update()
    {
        //OnGUI();
    }

    //displays recipe
    void OnGUI()
    {
        string temp = "";
        temp += "Current recipe: " + current.RecipeName + "\n";
        for (int i = 0; i < current.Ingredients.Count; i++)
        {
            temp += current.Ingredients[i] + "\n";
        }
        temp += "Points: " + points;

        GUI.Box(new Rect(0, 0, 250, 100), temp);
    }

    void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.name)
        {
            case "Apple(Clone)":
                Destroy(col.gameObject);
                matchFood("Apple");
                break;
            case "Banana(Clone)":
                Destroy(col.gameObject);
                matchFood("Banana");
                break;
            case "Bottle(Clone)":
                Destroy(col.gameObject);
                matchFood("Bottle");
                break;
            case "Bread(Clone)":
                Destroy(col.gameObject);
                matchFood("Bread");
                break;
            case "Can(Clone)":
                Destroy(col.gameObject);
                matchFood("Can");
                break;
            case "Cereal(Clone)":
                Destroy(col.gameObject);
                matchFood("Cereal");
                break;
            case "Cheese(Clone)":
                Destroy(col.gameObject);
                matchFood("Cheese");
                break;
            case "Chips(Clone)":
                Destroy(col.gameObject);
                matchFood("Chips");
                break;
            case "Egg(Clone)":
                Destroy(col.gameObject);
                matchFood("Egg");
                break;
            case "Flour(Clone)":
                Destroy(col.gameObject);
                matchFood("Flour");
                break;
            case "Meat(Clone)":
                Destroy(col.gameObject);
                matchFood("Meat");
                break;
            case "Pop(Clone)":
                Destroy(col.gameObject);
                matchFood("Pop");
                break;
            default:
                Debug.Log("Food not added yet.");
                break;
        }
    }

    private void matchFood(string food)
    {
        if (current.Ingredients.Contains(food))
        {
            points++;
        }
        else
        {
            points--;
        }

    }
}
