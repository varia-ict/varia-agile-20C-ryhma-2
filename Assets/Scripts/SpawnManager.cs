using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float secondsCount;
    private int minuteCount;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
    }

    public void UpdateTimerUI()
    {
        secondsCount += Time.deltaTime;
        if (minuteCount >= 1) { timerText.text = "Time: " + minuteCount + "." + (int)secondsCount; }
        else { timerText.text = "Time: " + (int)secondsCount; } 

        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
    }
}
