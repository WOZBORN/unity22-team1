using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text Score, highScore;
    public int scoreCounter, highscoreCounter;


    private void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highscoreCounter = PlayerPrefs.GetInt("HighScore");
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        Score.text = "Score: " + scoreCounter;
        highScore.text = "High Score: " + highscoreCounter;
    }
    public void AddScore()
    {
        scoreCounter ++;

        HighScore();
    }

    public void HighScore()
    {
        if (scoreCounter > highscoreCounter)
        {
            highscoreCounter = scoreCounter;
            PlayerPrefs.SetInt("HighScore", highscoreCounter);
        }
    }
}
