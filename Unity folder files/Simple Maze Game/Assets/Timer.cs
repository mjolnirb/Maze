using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{   
    public float timeRemaining = 0;
    public bool timeIsRunning = true; // Corrected 'True' to 'true'
    public TMP_Text timeText; // Corrected 'TMP_TEXT' to 'TMP_Text'
    public TextMeshProUGUI timerText;

    void Start()
    {
        timeIsRunning = true;
    }

    void Update()
    {
        if (timeIsRunning)
        {
            if(timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining); // Added semicolon at the end
            }
        }
    }

    void DisplayTime(float timeToDisplay) // Added parameter type
    {
        timeToDisplay += 1; // Added semicolon at the end
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Corrected division to modulo
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // Added seconds parameter
    }
}
