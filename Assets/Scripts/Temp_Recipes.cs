using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_Recipes : MonoBehaviour
{

    int recComplete;

    Recipe cake;
    Recipe breakfast;
    Recipe football;
    Recipe omelette;
    Recipe metal;

    Recipe current;

    List<Recipe> recipes;
    public int points;

    public List<GameObject> foodlist;
    private List<Vector3> foodlocs;

    List<Recipe> used;

    // Start is called before the first frame update
    void Start()
    {
        used = new List<Recipe>();
        foodlocs = new List<Vector3>();



        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                foodlocs.Add(new Vector3(10 + j * 10, 2, 8 + i * 17));
            }
        }

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                foodlocs.Add(new Vector3(70 - j * 16, 2, 13 + i * 10));
            }
        }

        PutFoodInLocs();
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

        do
        {
            current = recipes[Random.Range(0, 5)];
            
        }
        while (used.Contains(current));
        used.Add(current);

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
            case "Milk(Clone)":
                Destroy(col.gameObject);
                matchFood("Milk");
                break;
            case "Pop(Clone)":
                Destroy(col.gameObject);
                matchFood("Pop");
                break;
            default:
                Debug.Log("Can't eat that.");
                break;
        }
    }

    private void matchFood(string food)
    {
        if (current.Ingredients.Contains(food))
        {
            points++;
            current.Ingredients.Remove(food);
            if(current.Ingredients.Count == 0)
            {
                recComplete++;
                do
                {
                    current = recipes[Random.Range(0, 5)];
                    
                }
                while (used.Contains(current));
                used.Add(current);

                DestroyAll();
                PutFoodInLocs();
            }
        }
        else
        {
            points--;
        }

    }

    void PutFoodInLocs()
    {
        


        List<int> positions = new List<int>();
        int rotation;
        int rand;

        for (int i = 0; i < foodlist.Count; i++)
        {

            //checks to make sure random position isn't already occupied
            do
            {
                rand = Random.Range(0, 26);
            }
            while (positions.Contains(rand));

            positions.Add(rand);

            //rotation based on aisle
            if (rand >= 8)
            {
                rotation = 180;
            }
            else
            {
                rotation = 270;
            }
            Instantiate(foodlist[i], foodlocs[rand], Quaternion.Euler(0, rotation, 0));
        }
    }

    void DestroyAll()
    {
        for (int i = 0; i < foodlist.Count; i++)
        {
            Object[] allObjects = FindObjectsOfType(typeof(GameObject));
            foreach (GameObject obj in allObjects)
            {
                if(obj.name == "Apple(Clone)" || obj.name == "Banana(Clone)" || obj.name == "Bottle(Clone)" 
                    || obj.name == "Bread(Clone)" || obj.name == "Can(Clone)" || obj.name == "Cereal(Clone)" 
                    || obj.name == "Chips(Clone)" || obj.name == "Cheese(Clone)" || obj.name == "Egg(Clone)" 
                    || obj.name == "Flour(Clone)" || obj.name == "Meat(Clone)" || obj.name == "Milk(Clone)" || obj.name == "Pop(Clone)") 
                {
                    Destroy(obj);
                }
                
            }
        }
    }
}
