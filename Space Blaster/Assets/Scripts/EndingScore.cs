using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScore : MonoBehaviour
{

    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + ScoreScript.score;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
