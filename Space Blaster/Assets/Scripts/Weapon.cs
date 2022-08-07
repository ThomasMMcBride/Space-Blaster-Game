using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

 
    // determines if player is pressing spacebar and the game is not paused
    void Update(){
        if (Input.GetButtonDown("Fire1") && !PauseMenu.isPaused) {
            Shoot();
        }
    }

    // createsa a bullet at the location of the gameObject's firePoint
    void Shoot() {
        // shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
