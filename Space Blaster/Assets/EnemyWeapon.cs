using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public float reloadTime;
    public GameObject bulletPrefab;
    public Transform firePoint; 

    // fires weapon at a random, fixed interval
    void Start() {
        float number = Random.Range(1f, 4f);
        InvokeRepeating("fireWeaponHelper", 0, number);
    }

    // instantiates bullet at fire point
    private void fireWeaponHelper() {

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}
