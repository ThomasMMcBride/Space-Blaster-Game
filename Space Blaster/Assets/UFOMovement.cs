using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMovement : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    private Vector2 screenBounds;


    // destroys the gameObject after object moves offscreen
    void Update() {
        screenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        if (transform.position.x < screenBounds.x - 20) {
            Destroy(gameObject);
        }

    }


}
