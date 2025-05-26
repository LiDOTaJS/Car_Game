using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerScript : MonoBehaviour
{
    public Text timerText;

    private float elapsedTime = 0f;
    private bool timerRunning = true;

    void Start()
    {
        if (timerText == null)
            timerText = GetComponent<Text>();

        // Atiestata taimeri
        elapsedTime = 0f;
        timerRunning = true;
        UpdateDisplay();
    }

    void Update()
    {
        // Ja taimeris nav aktīvs, neko nedara
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

        // Formāts: 00:00:00
        timerText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }

    public void StopTimer()
    {
        timerRunning = false;
    }
}
