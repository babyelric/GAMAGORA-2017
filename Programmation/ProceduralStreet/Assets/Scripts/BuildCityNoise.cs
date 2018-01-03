using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCityNoise : MonoBehaviour {

    int[] angles;
    int angleChoisi;

    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    public int buildingFootprint = 3;

	void Start ()
    {
        angles = new int[4];

        angles[0] = 0;
        angles[1] = 90;
        angles[2] = 180;
        angles[3] = 270;



        float seed = Random.Range(0, 100);


        for (int h=0; h < mapHeight; h++)
            for(int w=0; w < mapWidth; w++)
            {
                angleChoisi = Random.Range(0, angles.Length);


                int result = (int)(Mathf.PerlinNoise(w/10.0f +seed, h/10.0f +seed) * 100);
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);

                if (result < 10)
                    Instantiate(buildings[0], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 15)
                    Instantiate(buildings[1], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 20)
                    Instantiate(buildings[2], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 31)
                    Instantiate(buildings[3], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 42)
                    Instantiate(buildings[4], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 40)
                    Instantiate(buildings[5], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 50)
                    Instantiate(buildings[6], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 60)
                    Instantiate(buildings[7], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 70)
                    Instantiate(buildings[8], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 90)
                    Instantiate(buildings[9], pos, Quaternion.Euler(new Vector3(0, 0, 0)));






                /*angleChoisi = Random.Range(0, angles.Length);

                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                int n = Random.Range(0, buildings.Length);
                Instantiate(buildings[n], pos, Quaternion.Euler(new Vector3(-90, angles[angleChoisi], 0)));*/
            }
	}
	
	
	void Update ()
    {
		
	}
}
