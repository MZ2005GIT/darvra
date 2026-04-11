using UnityEngine;

public class PinDetector : MonoBehaviour
{
    private bool hasFallen = false;
    private float tiltThreshold = 45f;

    // NEW: Variables to remember the start position
    private Vector3 startPosition;
    private Quaternion startRotation;
    private Rigidbody rb;

    void Awake()
    {
        // Save the "home" position as soon as the game starts
        startPosition = transform.position;
        startRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!hasFallen)
        {
            if (Vector3.Angle(transform.up, Vector3.up) > tiltThreshold)
            {
                hasFallen = true;
                BowlingManager.instance.AddScore();
            }
        }
    }

    // NEW: Function to snap the pin back
    public void ResetPin()
    {
        hasFallen = false;

        // Stop the physics movement
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Move it back home
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}