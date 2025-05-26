using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinnerScript : MonoBehaviour
{
    [Header("UI Elements (assign in Inspector)")]
    public GameObject backgroundWindow;
    public Image star1;
    public Image star2;
    public Image star3;
    public Text timerResult;

    [Header("Star thresholds (seconds)")]
    public float threeStarTime = 30f;  
    public float twoStarTime = 60f;  

    private TimerScript timerScript;

    void Start()
    {
        // Sākumā nerāda logu
        backgroundWindow.SetActive(false);
        star1.enabled = star2.enabled = star3.enabled = false;

        // Sameklē ainā timerscript
        timerScript = FindObjectOfType<TimerScript>();
    }

    public void ShowWinWindow()
    {
        // aptur taimeri
        timerScript.StopTimer();

        // parāda uzvaras logu
        backgroundWindow.SetActive(true);
        backgroundWindow.transform.SetAsLastSibling();
        // parāda iegūto laiku
        timerResult.text = "Laiks: " + timerScript.timerText.text;

        string[] parts = timerScript.timerText.text.Split(':');
        int seconds = int.Parse(parts[0]) * 3600
                    + int.Parse(parts[1]) * 60
                    + int.Parse(parts[2]);

        // nosaka iegūtās zvaigznes pēc laika
        if (seconds <= threeStarTime)
        {
            star1.enabled = star2.enabled = star3.enabled = true;
        }
        else if (seconds <= twoStarTime)
        {
            star1.enabled = star2.enabled = true;
        }
        else
        {
            star1.enabled = true;
        }
    }
}
