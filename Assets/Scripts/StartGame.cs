//Loads the game scene when clicking on the "Play" menu button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("GrowSnow");
    }
}