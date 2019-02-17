using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodList : MonoBehaviour
{
    public List<GameObject> foodlist;
    private List<Vector3> foodlocs;
    // Start is called before the first frame update
    void Start()
    {
        PutFoodInLocs();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //puts food in locations
    void PutFoodInLocs()
    {
        foodlocs = new List<Vector3>();



        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                foodlocs.Add(new Vector3(7 + j * 10, 2, 8 + i * 17));
            }
        }

        for (int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                foodlocs.Add(new Vector3(70-j*16, 2, 10+i*10));
            }
        }


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
            if(rand >= 8)
            {
                rotation = 270;
            }
            else
            {
                rotation = 180;
            }
            Instantiate(foodlist[i], foodlocs[rand], Quaternion.Euler(0,rotation,0));
        }
    }
}
