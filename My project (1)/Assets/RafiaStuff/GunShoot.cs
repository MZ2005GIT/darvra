using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunShoot : MonoBehaviour
{

    public float speed = 50f;
    public GameObject bulletPrefab;
    public Transform frontOfGun;


    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bulletPrefab, frontOfGun.position, frontOfGun.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * frontOfGun.forward;
        Destroy(spawnedBullet, 9f);
    }
    // public float damage = 10f;
    // public float impactForce = 100f;

    // public float range = 100f;

    // public float firingRange = 15f;

    // public float nextTimetoFire = 0f;
    // public Camera fpsCam;

    // private void Update()
    // {
    //     if (Input.GetButtonDown("Fire1") && Time.time >= nextTimetoFire)
    //     {
    //         nextTimetoFire = Time.time + 1f / firingRange;
    //         Shoot();
    //     }
    // }

    // void Shoot()
    // {
    //     RaycastHit hit;
    //     if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
    //     {
    //         Debug.Log(hit.transform.name);


    //     }
    // }

}
