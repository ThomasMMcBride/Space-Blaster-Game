using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{

    // play sound effect when this object is instantiated
    void Awake() {
       FindObjectOfType<AudioManager>().Play("Explosion");
    }

    // Despawn this gameObject after 5 seconds
    void Start()
    {
        StartCoroutine(DestroyObject());
    }

    IEnumerator DestroyObject() {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
