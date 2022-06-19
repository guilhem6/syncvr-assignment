//Sets and displays the score in the main menu

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static float highScore = 0;
    public static float lastScore = 0;
    public Text scoreText;
    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        string lastScoreDisplay = string.Format("{0,5:0.000}",lastScore);
        string highScoreDisplay = string.Format("{0,5:0.000}",highScore);
        scoreText.text = "Last diameter : " + lastScoreDisplay + " m";
        highscoreText.text = "Highest diameter : " + highScoreDisplay + " m";
    }

    // Awake is called whenever the scene changes to the main menu
    private void Awake(){
        string lastScoreDisplay = string.Format("{0,5:0.000}",lastScore);
        string highScoreDisplay = string.Format("{0,5:0.000}",highScore);
        scoreText.text = "Last diameter : " + lastScoreDisplay + " m";
        highscoreText.text = "Highest diameter : " + highScoreDisplay + " m";
    }
}
