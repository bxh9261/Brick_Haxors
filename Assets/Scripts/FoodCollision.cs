using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    Temp_Recipes tr = new Temp_Recipes();
    private GameObject colled;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        switch (col.gameObject.name)
        {
            case "Apple":
                Destroy(this);
                tr.matchFood("Apple");
                break;
            case "Banana":
                Destroy(this);
                tr.matchFood("Banana");
                break;
            case "Bottle":
                Destroy(this);
                tr.matchFood("Bottle");
                break;
            case "Bread":
                Destroy(this);
                tr.matchFood("Bread");
                break;
            case "Can":
                Destroy(this);
                tr.matchFood("Can");
                break;
            case "Cereal":
                Destroy(this);
                tr.matchFood("Cereal");
                break;
            case "Cheese":
                Destroy(this);
                tr.matchFood("Cheese");
                break;
            case "Chips":
                Destroy(this);
                tr.matchFood("Chips");
                break;
            case "Egg":
                Destroy(this);
                tr.matchFood("Egg");
                break;
            case "Flour":
                Destroy(this);
                tr.matchFood("Flour");
                break;
            case "Meat":
                Destroy(this);
                tr.matchFood("Meat");
                break;
            case "Pop":
                Destroy(this);
                tr.matchFood("Pop");
                break;
            default:
                Debug.Log("Food not added yet.");
                break;
        }
    }
}
