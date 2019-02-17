using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_Recipes : MonoBehaviour
{

    Recipe cake;


    // Start is called before the first frame update
    void Start()
    {
        cake = new Recipe("Red Velvet Cake", new List<string> { "Milk", "Flour", "Eggs" });
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    //displays recipe
    void OnGUI()
    {
        string temp = "";
        temp += "Current recipe: " + cake.RecipeName + "\n";
        for(int i = 0; i < cake.Ingredients.Count; i++)
        {
            temp += cake.Ingredients[i] + "\n";
        }

        GUI.Box(new Rect(0, 0, 200, 100), temp);
    }
}
