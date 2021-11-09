using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject gameOver;

    public TextMeshProUGUI timeText;
    private Rigidbody2D playerRb;

    private float timeRemaining = 5;
    public bool timerIsRunning;

    // Start is called before the first frame update
    void Start()
    {
        timeText.gameObject.SetActive(true);
        timerIsRunning = true;

        GameObject player = GameObject.Find("Player");

        playerRb = player.GetComponent<Rigidbody2D>();

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
                GameOver();
            }
        }
    }

    public void GameOver()
    {
        timeRemaining = 0;
        timeText.gameObject.SetActive(false);
        timerIsRunning = false;

        gameOver.SetActive(true);
        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
    }
}