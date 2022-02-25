using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllMenu : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject PauseButton;

    public bool GamePaused;

    private void Start()
    {
        GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void PauseGame()
    {
        GamePaused = true;
        PauseScreen.SetActive(true);
        PauseButton.SetActive(false);
    }   

    public void ResumeGame()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        PauseButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OutMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
