using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Brad Hanel, and the wonderful folk who teach IGME 202
 * TerrainGenerator: Makes a terrain using perlin values
 */

public class TerrainGeneration : MonoBehaviour 
{

	private TerrainData myTerrainData;
	public Vector3 worldSize;
	public int resolution = 129;			// number of vertices along X and Z axes
	float[,] heightArray;

    // Start is called before the first frame update
    void Start () 
	{
		myTerrainData = gameObject.GetComponent<TerrainCollider> ().terrainData;
		worldSize = new Vector3 (80, 0, 80);
		myTerrainData.size = worldSize;
		myTerrainData.heightmapResolution = resolution;


	}
	

	void Update () 
	{
		//zoop
	}
    
}
