using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject gameOver;
    public TextMeshProUGUI timeText;
    private Rigidbody2D playerRb;
    private float timeRemaining = 60;
    private float timeRemaining2 = 180;
    public bool timerIsRunning;

    // Start is called before the first frame update
    void Start()
    {
        timeText.gameObject.SetActive(true);
        timerIsRunning = true;

        GameObject player = GameObject.Find("Player");
        PlayerController playerController = player.GetComponent<PlayerController>();

        playerRb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName("2Dgame2"))
        {
            if (timerIsRunning)
                if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timeText.text = "Time: " + Mathf.RoundToInt(timeRemaining).ToString();
            }
            else
            {
                timeRemaining = 0;
                timeText.gameObject.SetActive(false);
                timerIsRunning = false;

                gameOver.SetActive(true);
                playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;

            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame2"))
        {
            if (timerIsRunning)
            {
                if (timeRemaining2 > 0)
                {
                    timeRemaining2 -= Time.deltaTime;
                    timeText.text = "Time: " + Mathf.RoundToInt(timeRemaining2).ToString();
                }
                else
                {
                    timeRemaining2 = 0;
                    timeText.gameObject.SetActive(false);
                    timerIsRunning = false;

                    gameOver.SetActive(true);
                    playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
                }
            }

        }
    }
}