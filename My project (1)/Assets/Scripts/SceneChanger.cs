using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void OnButtonClick (string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
