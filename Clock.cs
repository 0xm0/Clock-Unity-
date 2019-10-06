using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public int seconds;
    public int minutes;
    public int hours;
    public string amPm;
    public Text clockText;
    public Image imgSecond, imgMin, imgHour;

    public string currentTime;
    // Start is called before the first frame update
    void Start()
    {
        seconds = DateTime.Now.Second;
        minutes = DateTime.Now.Minute;
        hours = DateTime.Now.Hour;
        amPm = DateTime.Now.ToString("tt");

        InvokeRepeating("UpdateWidget", 0,1);
    }

    // Update is called once per frame
    void Update()
    {
        // Add code to keep the clock updated here


        // Call to Update the Widget
        
    }

    private void UpdateWidget()
    {
        // Add code to update the text on the widget to display the current time
        // currentTime = ???


        seconds = (seconds + 1) % 60;

        if (seconds == 0)
        {
            minutes = (minutes + 1) % 60;
            if (minutes == 0)
            {
                hours = (hours + 1) % 24;
            }
        }

        imgSecond.transform.localRotation = Quaternion.Euler(0, 0, -seconds * 6);
        imgMin.transform.localRotation = Quaternion.Euler(0, 0, -minutes * 6);
        imgHour.transform.localRotation = Quaternion.Euler(0, 0, -(hours * 30 + minutes / 6.0f));
        
        clockText.text = GetNumString(hours) + ":" + GetNumString(minutes) + ":" + GetNumString(seconds) + " " + amPm;

        //
    }
    private string GetNumString(int num)
    {
        return num < 10 ? "0" + num : num.ToString();
    }
}
