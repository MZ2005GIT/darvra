using UnityEngine;

public class UIToggle : MonoBehaviour
{
    public GameObject panel;

    void OnTriggerEnter(Collider col) {
        panel.SetActive(true);
    }
    void OnTriggerExit(Collider col) {
        panel.SetActive(false);
    }
}
