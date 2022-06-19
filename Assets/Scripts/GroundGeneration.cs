//Generates the ground of the game and the end platform

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGeneration : MonoBehaviour
{
    //snow plot prefab
    public GameObject[] plotPlaneArray;

    //end platform prefab
    public GameObject endPlane;

    //generation variables
    public int groundLength = 10;
    public int groundWidth = 5;
    public int slopAngle = 10;
    public float plotLength = 1;
    public float plotWidth = 1;
    //public Material basicMat;

    void Awake()
    {
        //Calculates the x and y distance between 2 adjacent platforms
        float yBySlot = 10 * Mathf.Sin(Mathf.PI/180f * slopAngle);
        float xBySlot = 10 * Mathf.Cos(Mathf.PI/180f * slopAngle);

        //Calculates the z start of generation
        float zGenerationStart = - plotWidth * (groundWidth-1)  * 5 ;

        //Generates the ground
        for(int i = 0; i < groundLength; i++)
            {
                float zGeneration = zGenerationStart;

                //Generates a ground line
                for(int j = 0; j < groundWidth; j++)
                    {
                    //Generates a snow plot

                        //Defines the snow level of the plot
                        int rand = Random.Range(0,9);
                        GameObject plotPlane = plotPlaneArray[rand];

                        //Instantiates the plot
                        Instantiate(plotPlane, new Vector3(xBySlot * i, -plotLength * yBySlot * i, zGeneration), Quaternion.Euler(0,0,-slopAngle));
                        
                        zGeneration += plotWidth * 10;
                    }
            }

        //Generates the end platform
        Instantiate(endPlane, new Vector3(xBySlot * plotLength * (groundLength-1), -plotLength * yBySlot * groundLength, 0), Quaternion.Euler(0,0,90));
    }
}