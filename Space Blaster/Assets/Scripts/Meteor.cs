using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {
    public float speed = 1f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    private float x;

    // Start is called before the first frame update

    void Start() {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);

    }

    // Update is called once per frame

    void Update() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        // remove the meteor once the meteor has left the camera
        
        if (transform.position.x < screenBounds.x - 20) {
            Destroy(this.gameObject);
        }
    }
}
