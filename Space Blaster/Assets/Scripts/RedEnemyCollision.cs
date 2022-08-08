using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyCollision : MonoBehaviour
{

    // only applies score if the colliding object is a player bullet
    public void OnTriggerEnter2D(Collider2D other) {
        string s = other.gameObject.tag;

        if (s == "Bullet") {
            ScoreScript.score += 20;  
        }
       
    }
}
