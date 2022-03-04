using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public static GameManager inst;

    public Text ScoreText;
    public GameObject QuaMan;

    public bool endGame;

    private void Start()
    {
        QuaMan.SetActive(false);
        endGame = false;
    }

    public void IncrementScore()
    {
        if (score >= 100)
        {
            WinGame();
            endGame = true;
        }
        score++;
        ScoreText.text = "SCORE: " + score;
        
    }

    public void WinGame()
    {
        QuaMan.SetActive(true);
        return;
    }

    private void Awake()
    {
        inst = this;
    }
}