using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour {

    int score = 0;
    //int highScore;

    //void Start()
    //{
    //    highScore = PlayerPrefs.GetInt("HighScore", 0);
   // }

    private void Awake()
    {
        SetUpSingleton();
    }

    // Game Session
    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Score
    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    /*
    // HighScore
    public void HighScore()
    {    
        if  (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;
        }
    }

    public int GetHighScore()
    {
        return highScore;
    }
    */

 }
