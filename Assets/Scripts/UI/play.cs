using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class play : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void quitGame()
    {
        Application.Quit();
    }

}