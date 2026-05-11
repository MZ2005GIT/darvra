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
    private GameObject ball;

    private int scoretotal;

    void Start()
    {
        UpdateText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            scoretotal++;
            Debug.Log(scoretotal);
            UpdateText();
        }
    }

    private void UpdateText()
    {
        scoretext.text = scoretotal.ToString();
    }
}
