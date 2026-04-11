using UnityEngine;

public class BallPitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object is tagged "Ball"
        if (other.CompareTag("Ball"))
        {
            // Tell the manager to reduce the Tries count
            BowlingManager.instance.BallThrown();

            // Destroy the ball so the player has to grab a new one from the rack
            // (We wait 0.5 seconds just so it doesn't vanish instantly)
            Destroy(other.gameObject, 0.5f);
        }

        // Optional: If pins fall into the pit, destroy them too 
        // to keep the pit clean, but the PinDetector already handles scoring.
        if (other.CompareTag("Pin"))
        {
            Destroy(other.gameObject, 1.0f);
        }
    }
}