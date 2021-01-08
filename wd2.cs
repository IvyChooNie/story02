using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wd2 : MonoBehaviour
{
    public float maxTime = 4f;
    float timeLeft;
    public GameObject timesUp;

    void Start()
    {
        timesUp.SetActive(false);
        // timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            // timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timesUp.SetActive(true);
            Time.timeScale = 0;
        }
    }
}