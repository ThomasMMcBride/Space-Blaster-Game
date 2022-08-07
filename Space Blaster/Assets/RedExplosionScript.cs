using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedExplosionScript : MonoBehaviour
{

    // play sound effect 
    void Awake() {
       FindObjectOfType<AudioManager>().Play("Explosion2");
    }

    // Start is called before the first frame update
    // start despawn coroutine
    void Start()
    {
        StartCoroutine(DestroyObject());
    }

    // destroy this object after 5 seconds
    IEnumerator DestroyObject() {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
