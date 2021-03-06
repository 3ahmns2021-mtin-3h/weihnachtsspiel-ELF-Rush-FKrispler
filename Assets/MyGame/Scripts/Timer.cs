﻿using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject santaButton;
    public GameObject elfObjekt;
    public GameObject snowmanObjekt;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI finishText;
    public TextMeshProUGUI timeText;
    private float timeInSec;

    void Start()
    {
        timeInSec = 60f; 
    }

    void Update()
    {
        timeInSec -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(timeInSec/60);
        float seconds = Mathf.FloorToInt(timeInSec%60);

        if (timeInSec > 0)
        {
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            santaButton.SetActive(false);
        }
        else
        {
            finishText.text = "TIME IS UP";
            elfObjekt.SetActive(false);
            snowmanObjekt.SetActive(false);
            timeText.enabled = false;
            santaButton.SetActive(true);
        }
    }
}
