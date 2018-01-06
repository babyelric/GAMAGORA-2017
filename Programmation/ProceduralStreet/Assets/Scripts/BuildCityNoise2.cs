using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCityNoise2 : MonoBehaviour {

    int[] angles;
    int angleChoisi;

    public GameObject[] buildings;
    public GameObject xstreets;
    public GameObject zstreets;
    public GameObject crossroad;

    public int mapWidth = 20;
    public int mapHeight = 20;
    int[,] mapgrid;
    public int buildingFootprint = 3;

    void Start()
    {
        angles = new int[4];
        
        angles[0] = 0;
        angles[1] = 90;
        angles[2] = 180;
        angles[3] = 270;


        
        //float seed = Random.Range(0, 100);

        

        mapgrid = new int[mapWidth, mapHeight];

        //generation donnée map
        for (int h = 0; h < mapHeight; h++)
        { 
            for (int w = 0; w < mapWidth; w++)
            {
                mapgrid[w, h] = (int) (Mathf.PerlinNoise(w / 10.0f, h / 10.0f) * 10);
            }
        }


        //build streets
        int x = 0;
        for(int n = 0; n < 50; n++)
        {
            for (int h = 0; h < mapHeight; h++)
            {
                mapgrid[x, h] = -1;
            }

            x += Random.Range(3, 3);
            if (x >= mapWidth) break;
        }


        
		int z = 0;
		for(int n = 0; n < 10; n++)
		{
			for (int w = 0; w < mapWidth; w++)
			{
				if (mapgrid [w, z] == -1)
					mapgrid [w, z] = -3;
				else
					mapgrid [w, z] = -2;
			}

			z += Random.Range(2, 20);
			if (z >= mapHeight) break;
		}






        //Génération city
        for (int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                int result = mapgrid[w, h];
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);



				//angleChoisi = 

				System.Random rnd = new System.Random();
				angleChoisi = rnd.Next(0, 4);

				Debug.Log (angleChoisi);




                if (result < -2)
                    Instantiate(crossroad, pos, crossroad.transform.rotation);
                else if (result < -1)
                    Instantiate(xstreets, pos, xstreets.transform.rotation);
                else if (result < 0)
                    Instantiate(zstreets, pos, zstreets.transform.rotation);



                else if (result < 1)
                    Instantiate(buildings[0], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 2)
                    Instantiate(buildings[1], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 4)
                    Instantiate(buildings[2], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 6)
                    Instantiate(buildings[3], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 7)
                    Instantiate(buildings[4], pos, Quaternion.Euler(new Vector3(0, angles[angleChoisi], 0)));
                else if (result < 10)
                    Instantiate(buildings[5], pos, Quaternion.Euler(new Vector3(0, 0, 0)));
            }
        }            
	}
}
