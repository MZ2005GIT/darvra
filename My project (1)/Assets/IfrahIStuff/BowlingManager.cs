// using UnityEngine;
// using TMPro;
// using System.Collections;

// public class BowlingManager : MonoBehaviour
// {
//     public static BowlingManager instance;

//     [Header("UI Text Elements")]
//     public TextMeshProUGUI scoreText;
//     public TextMeshProUGUI triesText;

//     [Header("Game Rules")]
//     public int score = 0;
//     public int tries = 2;
//     public int totalPins = 10;

//     private bool isResetting = false;

//     void Awake()
//     {
//         if (instance == null) instance = this;
//     }

//     void Start()
//     {
//         FullReset();
//     }

//     // Called by PinDetector script
//     public void AddScore()
//     {
//         score++;
//         UpdateUI();

//         // If they get a Strike (all pins down), reset immediately!
//         if (score >= totalPins && !isResetting)
//         {
//             StartCoroutine(AutoResetTimer());
//         }
//     }

//     // This is called by the "BallPitTrigger" when a ball is thrown
//     public void BallThrown()
//     {
//         if (isResetting) return;

//         tries--;
//         UpdateUI();

//         if (tries <= 0 && !isResetting)
//         {
//             StartCoroutine(AutoResetTimer());
//         }
//     }

//     void UpdateUI()
//     {
//         if (scoreText != null) scoreText.text = "Score: " + score;
//         if (triesText != null) triesText.text = "Tries: " + tries;
//     }

//     IEnumerator AutoResetTimer()
//     {
//         isResetting = true;
//         yield return new WaitForSeconds(5f); 
//         FullReset();
//         isResetting = false;
//     }

//     public void FullReset()
//     {
//         score = 0;
//         tries = 2;
//         UpdateUI();

//         // Reset all pins to their starting spots
//         PinDetector[] allPins = FindObjectsOfType<PinDetector>();
//         foreach (PinDetector pin in allPins)
//         {
//             pin.ResetPin();
//         }
//     }
// }