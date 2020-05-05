using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    Text highScoreText;
    GameSession gameSession;

    // Use this for initialization
    void Start()
    {       
        highScoreText = GetComponent<Text>();
        gameSession = FindObjectOfType<GameSession>();

        highScoreText.text = PlayerPrefs.GetInt("highScoreText", 0).ToString();

    }

    void Update()
    {
        if (gameSession.GetScore() > PlayerPrefs.GetInt("highScoreText", 0))
        {
            PlayerPrefs.SetInt("highScoreText", gameSession.GetScore());
            highScoreText.text = gameSession.GetScore().ToString();
        }
        
    }
}
