//Loads the main menu scene when clicking on the "back to menu" button

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}