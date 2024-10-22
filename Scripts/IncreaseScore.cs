using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    private int score = 0;
    public CubeCollision cubeCollision;
    void Start()
    {
        cubeCollision.OnCubeCollisionWithEgg1 += AddScoreBy5;
        cubeCollision.OnCubeCollisionWithEgg2 += AddScoreBy10;
    }

    void AddScoreBy5() {
        score += 5;
        Debug.Log("Score: " + score);
    }

    void AddScoreBy10() {
        score += 10;
        Debug.Log("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
