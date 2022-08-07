using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShipCollision : MonoBehaviour {

    public GameObject bigExplosion;
    public GameObject smallExplosion;
    private SpriteRenderer s;
    public HealthBar healthBar;
    public GameObject gameOverScreen;
    private SpriteRenderer player;


    // apply player damage or if player is at 10 health, show game over screen
    private void OnTriggerEnter2D(Collider2D other) {

        FindObjectOfType<AudioManager>().Play("Damage");

        Destroy(other.gameObject);

        if (healthBar.slider.value == 10) {
            ShowGameOverScreen();
            healthBar.slider.value = healthBar.slider.value - 10f;
        }

        if (healthBar.slider.value == 0) {
            healthBar.setHealth(healthBar.slider.value - 10f);
        } else {
            healthBar.setHealth(healthBar.slider.value - 10f);
            StartCoroutine(PlayerHurtAnimation());
        }


    }

    // makes the game over screen active
    public void ShowGameOverScreen() {
            Destroy(gameObject);
            gameOverScreen.SetActive(true);
            
    }

    // flickers the player sprite and disables hitbox temporarily 
    IEnumerator PlayerHurtAnimation() {

        SpriteRenderer player = gameObject.GetComponent<SpriteRenderer>();

        Collider2D hitbox = gameObject.GetComponent<Collider2D>();

        hitbox.enabled = false;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.clear;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.white;
        
        yield return new WaitForSeconds(0.3f);

        player.color = Color.clear;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.white;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.clear;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.white;
        
        yield return new WaitForSeconds(0.3f);

        player.color = Color.clear;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.white;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.clear;

        yield return new WaitForSeconds(0.3f);

        player.color = Color.white;

        hitbox.enabled = true;


    }

}
