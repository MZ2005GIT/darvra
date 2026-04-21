using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GunShoot : MonoBehaviour
{

    [SerializeField] private float speed = 50f;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform frontOfGun;
    //[SerializeField] protected 
    public float score = 0;




    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(frontOfGun.position, transform.TransformDirection(Vector3.forward), out hit, 100f))
        {
            Debug.DrawRay(frontOfGun.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.blue);
            Debug.Log("Raybcast hit!");
            // Fire();
        }
    }

    public void Fire()
    {

        GetComponent<AudioSource>().Play();
        GameObject spawnedBullet = Instantiate(bulletPrefab, frontOfGun.position, frontOfGun.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * frontOfGun.forward;
        Destroy(spawnedBullet, 7f);
        // score += 10;
        // Scorepoint();


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("targetShoot"))
        {
            ScoreUI.Addscore(10);
            Debug.Log("Score: " + score);
        }
        else if (score > 0)
        {
            ScoreUI.Addscore(-5);
        }

    }

    // public void Scorepoint()
    // {
    //     if()
    //     score += 10;
    // }
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
