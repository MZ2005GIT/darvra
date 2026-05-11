using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoretext;

    [SerializeField]
    private TextMeshProUGUI highscoretext;

    [SerializeField]
    private GameObject ball;

    private int scoretotal;

    void Start()
    {
        UpdateHighscore();
        UpdateText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            scoretotal++;
            Debug.Log(scoretotal);
            UpdateText();
            UpdateHighscore();
        }
    }

    private void UpdateText()
    {
        scoretext.text = scoretotal.ToString();
        highscoretext.text = "Highscore: " + PlayerPrefs.GetInt("BBhighscore").ToString();
    }

    private void UpdateHighscore()
    {
        if (PlayerPrefs.HasKey("BBhighscore"))
        {
            if (scoretotal > PlayerPrefs.GetInt("BBhighscore"))
            {
                PlayerPrefs.SetInt("BBhighscore", scoretotal);
            }
        }
        else
        {
            PlayerPrefs.SetInt("BBhighscore", scoretotal);
        }
    }
}
