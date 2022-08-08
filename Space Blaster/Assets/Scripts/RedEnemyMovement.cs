using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyMovement : MonoBehaviour
{

    private Vector2 screenBounds;
    public Transform firePointOne;
    public Transform firePointTwo;
    public Transform firePointThree;
    public Transform firePointFour;
    public Transform firePointFive;
    public Transform firePointSix;
    public Transform firePointSeven;
    public Transform firePointEight;
    public GameObject projectileOne;
    public GameObject projectileTwo;
    public GameObject projectileThree;
    public GameObject projectileFour;
    public GameObject projectileFive;
    public GameObject projectileSix;
    public GameObject projectileSeven;
    public GameObject projectileEight;
    public GameObject explosion;


    // Start is called before the first frame update
    // start explosion coroutine
    void Start()
    {
       StartCoroutine(ExplosionAnimation());
       GetComponent<Rigidbody2D>().velocity = transform.right * 2f;
    }

    // Update is called once per frame
    // once gameObject is offscreen, delete gameObject
    void Update() {
        screenBounds = Camera.main.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        if (transform.position.x < screenBounds.x - 20) {
            Destroy(gameObject);
        }

    }

    // flickers the player sprite, destroys player, and creates offshooting projectiles from death point
    IEnumerator ExplosionAnimation() {

        SpriteRenderer player = gameObject.GetComponent<SpriteRenderer>();

        float randomInt = Random.Range(0.5f, 3f);
        
        yield return new WaitForSeconds(randomInt);

        player.color = Color.red;

        yield return new WaitForSeconds(0.5f);

        player.color = Color.white;
        
        yield return new WaitForSeconds(0.5f);

        player.color = Color.red;

        yield return new WaitForSeconds(0.5f);

        player.color = Color.white;

        yield return new WaitForSeconds(0.5f);

        player.color = Color.red;

        yield return new WaitForSeconds(0.5f);

        player.color = Color.white;

        Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(gameObject);


        Instantiate(projectileOne, firePointOne.position, firePointOne.rotation);
        Instantiate(projectileTwo, firePointTwo.position, firePointOne.rotation);
        Instantiate(projectileThree, firePointThree.position, firePointOne.rotation);
        Instantiate(projectileFour, firePointFour.position, firePointOne.rotation);
        Instantiate(projectileFive, firePointFive.position, firePointOne.rotation);
        Instantiate(projectileSix, firePointSix.position, firePointOne.rotation);
        Instantiate(projectileSeven, firePointSeven.position, firePointOne.rotation);
        Instantiate(projectileEight, firePointEight.position, firePointOne.rotation);


    }

}
