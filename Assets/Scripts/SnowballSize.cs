//Updates the size and the mass of the snowball

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnowballSize : MonoBehaviour
{
    //Snowball properties
    public float minimumSize = 0.2f;
    public float maximumSize = 4f;
    public float meltingSpeed = 0.3f;
    public float growthSpeed = 0.15f;
    public Text currentScore;
    public static float score;

    // Update is called once per frame
    void Update()
    {
    //Define the diameter and the score
        float diameter = transform.localScale.x;
        score = diameter;
    
    // Update the mass of the snowball
        GetComponent<Rigidbody>().mass = diameter * diameter * 2;
        string scoreDisplay = string.Format("{0,5:0.000}",score);

    //Update the score
        currentScore.text = "Diameter : "+ scoreDisplay + "m";
    }

    //Growth of the snowball depending the floor and variables
    void OnTriggerStay(Collider other)
    {
        //define and calculate the variables
        if(other.tag == "SnowPlot")
        {
            float diameter = transform.localScale.x;
        float speed = GetComponent<Rigidbody>().velocity.x;
        float snowLevel = other.gameObject.GetComponent<SnowLevel>().snowLevel;
        float onTimeGrowthSpeed = growthSpeed * Time.deltaTime * (snowLevel- meltingSpeed) * speed;
        
        //apply the growth or decrease if the size of the snowball is respected
        if((onTimeGrowthSpeed<0 && diameter>minimumSize) || (onTimeGrowthSpeed>0 && diameter<maximumSize))
            {
                transform.localScale = transform.localScale + new Vector3(onTimeGrowthSpeed,onTimeGrowthSpeed,onTimeGrowthSpeed);
            }
        }
    }
}