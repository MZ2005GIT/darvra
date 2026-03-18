using UnityEngine;

public class WinMiniGolf : MonoBehaviour
{
    public GameObject panel;
    void OnTriggerEnter(Collider col) {
        panel.SetActive(true);
    }
}
