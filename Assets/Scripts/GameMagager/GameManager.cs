using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    bool gameHasEnded = false;

    public Text scoreText;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        Restart();
    }    

    private void Awake()
    {
        inst = this;
    }

    void Restart()
    {
        if(score == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
