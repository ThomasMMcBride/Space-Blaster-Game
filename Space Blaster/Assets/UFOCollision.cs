using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOCollision : MonoBehaviour
{
    // only adds to the player score if the colliding object is a bullet
    public void OnTriggerEnter2D(Collider2D other) {
        string s = other.gameObject.tag;

        if (s == "Bullet") {
            ScoreScript.score += 10;
        }
    }
}
