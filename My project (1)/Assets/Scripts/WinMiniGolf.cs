using UnityEngine;

public class WinMiniGolf : MonoBehaviour
{
    public GameObject panel;
    public void OnTriggerEnter(Collider col)
    {
        panel.SetActive(true);
        //GetComponent<AudioSource>().Play();
    }
}
