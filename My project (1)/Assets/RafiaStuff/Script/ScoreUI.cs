using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{


    [SerializeField] private TextMeshProUGUI scoretext;
    public static int score = 0;
    public static ScoreUI instance;

    void Awake()
    {
        instance = this;
    }
    public static void Addscore(int point)
    {

        score += point;
        if (score < 0) score = 0;
        ScoreUI.instance.UpdateUI();
    }
    public void UpdateUI()
    {
        scoretext.text = "Score: " + score;
    }
}
