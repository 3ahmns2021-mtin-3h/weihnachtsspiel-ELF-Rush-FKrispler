﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public TextMeshProUGUI finishText;
    private float timeInSec;

    // Start is called before the first frame update
    void Start()
    {
        timeInSec = 60f; 
    }

    // Update is called once per frame
    void Update()
    {
        timeInSec -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(timeInSec/60);
        float seconds = Mathf.FloorToInt(timeInSec%60);

        if (timeInSec > 0)
        {
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            Debug.Log("Stop Game");
            finishText.text = "Finished";
        }
    }
}
