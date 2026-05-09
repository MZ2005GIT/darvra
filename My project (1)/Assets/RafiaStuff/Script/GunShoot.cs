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
        //Destroy(spawnedBullet, 7f);
        // score += 10;
        // Scorepoint();


    }


}
