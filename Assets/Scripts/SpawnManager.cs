using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject timer;
    public TextMeshProUGUI timeText;

    private float timeRemaining = 60;
    private bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timer.SetActive(true);
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timeText.text = "Time: " + Mathf.RoundToInt(timeRemaining).ToString();
            }
            else
            {
                timeRemaining = 0;
                timeText.text = "Time ran out!";
                timerIsRunning = false;
            }
        }
    }
}