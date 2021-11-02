using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public int seconds = 57;
    public int minutes = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(time());
    }

    // Update is called once per frame
    void Update()
    {
        if (minutes >= 1) { timer.text = "Time " + minutes + ":" + (seconds < 10 ? "0" + seconds.ToString() : seconds.ToString()); }
        else { timer.text = "Time " + seconds; }

        /*
        if(peliLoppui)
        {
        StopCoroutine(time());
        }
         */
    }

    void timeCount()
    {
        seconds += 1;
        if (seconds > 60)
        {
            seconds = 0;
            minutes += 1;
        }
    }

    IEnumerator time()
    {
        while (true)
        {
            timeCount();
            yield return new WaitForSeconds(1);
        }
    }
}
