using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBullet : MonoBehaviour
{
    public float speed = 1f; // speed of the bullet
    public Rigidbody2D rb;
    private Vector2 screenBounds;
    private float x;


    // play sound effect when this object is instantiated
    void Awake() {
        FindObjectOfType<AudioManager>().Play("EnemyBullet");
    }

    // sets velocity of the this object
    void Start() {
        rb.velocity = -transform.right * speed; // bullet travels to the right depending on the speed variable
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3; 
    }

    // delete bullet once it leaves the view of the camera
    void Update() {
        screenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        if (transform.position.x < screenBounds.x - 20) {
            Destroy(this.gameObject);
        }
        
    }
}
