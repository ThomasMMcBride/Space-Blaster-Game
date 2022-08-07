using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

    // Update is called once per frame

    void FixedUpdate() {

      // increase camera x coordinate
      
      transform.Translate(Vector2.right * 0.1f);  
    }
}
