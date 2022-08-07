using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    // velocity of this object is dependant on its tag
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (gameObject.tag == "One") {
            rb.velocity = new Vector2(1.5f, 1.5f);
        } else if (gameObject.tag == "Two") {
            rb.velocity = new Vector2(-1.5f, 1.5f);
        } else if (gameObject.tag == "Three") {
            rb.velocity = new Vector2(1.5f, -1.5f); 
        } else if (gameObject.tag == "Four") {
            rb.velocity = new Vector2(-1.5f, -1.5f);
        } else if (gameObject.tag == "Five") {
            rb.velocity = new Vector2(0, 2);
        } else if (gameObject.tag == "Six") {
            rb.velocity = new Vector2(2, 0);
        } else if (gameObject.tag == "Seven") {
            rb.velocity = new Vector2(0, -2);
        } else {
            rb.velocity = new Vector2(-2, 0);
        }
        StartCoroutine(DespawnProj());
    }

    // destroys this object after 5 seconds
    IEnumerator DespawnProj() {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
