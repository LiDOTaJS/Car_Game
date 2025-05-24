using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    [Tooltip("Drag your Legacy Text component here (or leave null to auto-find).")]
    public Text timerText;

    private float elapsedTime = 0f;
    private bool timerRunning = true;

    void Start()
    {
        // if you forgot to assign in the Inspector, try to grab it on this GameObject
        if (timerText == null)
            timerText = GetComponent<Text>();

        // reset
        elapsedTime = 0f;
        timerRunning = true;
        UpdateDisplay();
    }

    void Update()
    {
        if (!timerRunning) return;

        elapsedTime += Time.deltaTime;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        int totalSeconds = (int)elapsedTime;
        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        // format as 00:00:00
        timerText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }

    /// <summary>
    /// Call this from your own code once you've determined all objects are placed.
    /// After this, the timer will freeze on its last value.
    /// </summary>
    public void StopTimer()
    {
        timerRunning = false;
    }
}
