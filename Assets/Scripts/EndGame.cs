//Triggers a return to the main menu and a score save when the snowball collides with the ending platform

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Snowball")
        {
            //score save
            ScoreManager.lastScore = SnowballSize.score;

            //highscore update
            if(ScoreManager.highScore < SnowballSize.score)
                {
                    ScoreManager.highScore = SnowballSize.score;
                }
            
            //return to the main menu
            SceneManager.LoadScene("MainMenu");
        }
    }
}