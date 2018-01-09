using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCity : MonoBehaviour {

    int[] angles;
    int angleChoisi;

    public GameObject[] buildings;
    public int mapWidth = 100;
    public int mapHeight = 100;
    public int buildingFootprint = 3;

	void Start ()
    {
        angles = new int[4];

        angles[0] = 0;
        angles[1] = 90;
        angles[2] = 180;
        angles[3] = 270;

        for (int h=0; h < mapHeight; h++)
            for(int w=0; w < mapWidth; w++)
            {
                angleChoisi = Random.Range(0, angles.Length);

                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                int n = Random.Range(0, buildings.Length);
                Instantiate(buildings[n], pos, Quaternion.Euler(new Vector3(-90, angles[angleChoisi], 0)));
            }
	}
	
	
	void Update ()
    {
		
	}
}
