using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{

    //[SerializeField] private hitTarget gs;
    [SerializeField] private TextMeshProUGUI scoretext;
    public static int score = 0;
    public static ScoreUI instance;

    void Awake()
    {
        instance = this;
    }
    public static void Addscore(int score)
    {
        score += score;
        ScoreUI.instance.UpdateUI();
    }
    public void UpdateUI()
    {
        scoretext.text = "Score: " + score;
    }
}
