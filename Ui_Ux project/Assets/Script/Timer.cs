using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float startTime;
    public int intTime;

    public int hour;
    public string stringHour;

    public int minute;
    public string stringMinute;

    public int second;
    public string stringSecond;

    public TextMeshProUGUI timerText;

    void Update()
    {
        startTime -= Time.deltaTime;

        intTime = (int)startTime;

        hour = intTime / 3600;
        if (hour.ToString().Length == 1)
        {
            stringHour = "0" + hour.ToString();
        }
        else if (hour.ToString().Length == 0)
        {
            stringHour = "00";
        }
        else
        {
            stringHour = hour.ToString();
        }

        minute = (intTime%3600) / 60;
        if (minute.ToString().Length == 1)
        {
            stringMinute = "0" + minute.ToString();
        }
        else if (minute.ToString().Length == 0)
        {
            stringMinute = "00";
        }
        else
        {
            stringMinute = minute.ToString();
        }

        second = intTime%60;
        if (second.ToString().Length == 1)
        {
            stringSecond = "0" + second.ToString();
        }
        else if (second.ToString().Length == 0)
        {
            stringSecond = "00";
        }
        else
        {
            stringSecond = second.ToString();
        }

        timerText.text = stringHour.ToString() + ":" + stringMinute.ToString() + ":" + stringSecond.ToString();
    }
}