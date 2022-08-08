using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateUFOs : MonoBehaviour
{
    public GameObject ufo;
    public float respawnTime = 5.0f;
    private Vector2 screenBounds;
    private SpriteRenderer s;
    private Camera mainCamera;

    // Start is called before the first frame update

    void Start() {
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));

        StartCoroutine(ufoSpawner()); // initate meteor spawning coroutine

    }

    // Update is called once per frame

    void Update()
    {

         mainCamera = gameObject.GetComponent<Camera>();
         screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }

    // applies a delay on spawning meteors depending on the respawnTime

    IEnumerator ufoSpawner() {
        yield return new WaitForSeconds(60);
        InvokeRepeating("decrementRespawnTime", 0.0f, 2f); // initiate time decrementer
        while (true) {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
    
    // creates meteors on left side of the screeen at a random screen y coordinate

    private void spawnEnemy() {
        GameObject a = Instantiate(ufo) as GameObject;
        s = a.GetComponent<SpriteRenderer>();
        s.sortingOrder = 1;

        a.transform.position = new Vector3(screenBounds.x + 5, Random.Range(-screenBounds.y * 0.80f, screenBounds.y * 0.80f), 1);
        
    }

    // decreases the respawnTime variable once

    private void decrementRespawnTime() {
     if (respawnTime > 0.5f) {
        respawnTime = respawnTime - 0.02f;
     }
    }
}
