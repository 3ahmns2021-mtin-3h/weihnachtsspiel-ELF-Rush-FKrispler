using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject homeButton;
    public GameObject elfObjekt;
    public GameObject snowmanObjekt;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI finishText;
    public TextMeshProUGUI timeText;
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
            finishText.text = "TIME IS UP";
            elfObjekt.SetActive(false);
            snowmanObjekt.SetActive(false);
            timeText.enabled = false;
            homeButton.SetActive(true);
        }
    }
}
