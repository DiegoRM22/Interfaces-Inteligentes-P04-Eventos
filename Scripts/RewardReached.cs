using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RewardReached : MonoBehaviour
{
    public IncreaseScoreUI increaseScoreUI;
    public TextMeshProUGUI rewardText;
    public CubeMovement cubeMovement;


    void Start()
    {
        increaseScoreUI.OnScoreReached100 += RewardPlayer;
    }

    void RewardPlayer() {
        rewardText.text = "Reward: Speed Increased!!";
        cubeMovement.moveSpeed += 5;
    }

    void Update() {
        // Cada 5 segundos, limpiar el texto de la recompensa
        if (Time.time % 5 == 0) {
            rewardText.text = "";
        }
    }
}
