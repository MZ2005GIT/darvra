using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("targetShoot"))
        {
            ScoreUI.Addscore(10);
            // Debug.Log("Score: " + score);
            Destroy(gameObject);
        }
        else
        {
            ScoreUI.Addscore(-5);
            Destroy(gameObject);
        }
    }
}
