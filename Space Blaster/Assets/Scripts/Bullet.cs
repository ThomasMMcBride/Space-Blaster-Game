using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed = 10f; // speed of the bullet
    public Rigidbody2D rb;
    private Vector2 screenBounds;
    private float x;

    // play sound effect when object is instantiated
    void Awake() {
       FindObjectOfType<AudioManager>().Play("Bullet");
    }
    // Start is called before the first frame update

    void Start() {
        rb.velocity = transform.right * speed; // bullet travels to the right depending on the speed variable
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3; 
    }

    // delete bullet once it leaves the view of the camera
    void Update() {
        screenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


        if (transform.position.x > screenBounds.x + 20) {
            Destroy(this.gameObject);
        }
        
    }

}
