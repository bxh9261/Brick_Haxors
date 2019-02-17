using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAisles : MonoBehaviour
{
    public Transform iWouldWalk500Aisles;
    public Transform buildAWall;
    const int SCALE_DOWN = 4;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 7; j++)
            {
                Instantiate(iWouldWalk500Aisles, new Vector3((290/SCALE_DOWN)-i*(70/SCALE_DOWN), (10/SCALE_DOWN), (20/SCALE_DOWN)+j*(40/SCALE_DOWN)), Quaternion.Euler(new Vector3(0, 0, 0)));
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Instantiate(iWouldWalk500Aisles, new Vector3((90/SCALE_DOWN) - i * (40/SCALE_DOWN), (10/SCALE_DOWN), (35/SCALE_DOWN) + j * (70/SCALE_DOWN)), Quaternion.Euler(new Vector3(0, 90, 0)));
            }
        }

        //w- w- wall
        Instantiate(buildAWall, new Vector3(40, 5, 0), Quaternion.identity);
        Instantiate(buildAWall, new Vector3(40, 5, 80), Quaternion.identity);
        Instantiate(buildAWall, new Vector3(0, 5, 40), Quaternion.Euler(0,90,0));
        Instantiate(buildAWall, new Vector3(80, 5, 40), Quaternion.Euler(0, 90, 0));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
