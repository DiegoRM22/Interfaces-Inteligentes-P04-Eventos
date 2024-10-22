using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IncreaseScoreUI : MonoBehaviour
{
    private int score = 0;
    public delegate void OnScoreIncrease();
    public event OnScoreIncrease OnScoreReached100;
    public CubeCollision cubeCollision;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        cubeCollision.OnCubeCollisionWithEgg1 += AddScoreBy5;
        cubeCollision.OnCubeCollisionWithEgg2 += AddScoreBy10;
    }

    void AddScoreBy5() {
        score += 5;
        UpdateScoreText();
    }

    void AddScoreBy10() {
        score += 10;
        UpdateScoreText();
    }

    void UpdateScoreText() {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 100) {
            if (OnScoreReached100 != null) {
                OnScoreReached100();
            }
            score = 0;
        }
        
    }
}
