using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncrementBallScore : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public BallOutNotificator ballOutNotificator;
    void Start()
    {
        ballOutNotificator.OnBallOutEvent += IncrementScore;
    }

    void IncrementScore() {
        score++;
        UpdateScoreText();
    }

    void UpdateScoreText() {
        scoreText.text = "Score: " + score;
    }
}
