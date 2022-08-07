using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public GameObject explosion;
    private SpriteRenderer s;

    // bullet can only affect entities that are not the player
    private void OnTriggerEnter2D(Collider2D other) {
        if (!(other.gameObject.tag == "Player")) {
        GameObject e = Instantiate(explosion) as GameObject;
        s = e.GetComponent<SpriteRenderer>();
        s.sortingOrder = 2;
        Instantiate(e, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(other.gameObject);
        }

    }
}
