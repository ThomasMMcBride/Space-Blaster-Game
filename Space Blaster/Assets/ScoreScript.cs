using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public static int score = 0;
    public TextMeshProUGUI scoreText;

    // Update score every frame
    void Update() {
        scoreText.text = "Score: " + score;
    }
}
