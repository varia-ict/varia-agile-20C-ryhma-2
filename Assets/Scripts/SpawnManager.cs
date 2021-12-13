using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    // Public Variables
    public GameObject gameOver;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverTime;
    public bool timerIsRunning;

    // Private Variables
    private Rigidbody2D playerRb;
    private float timeRemaining = 60;
    private float timeRemaining2 = 120;
    private float timeRemaining3 = 60;
    private float timeRemaining4 = 90;
    private float timeRemaining5 = 60;
    private float restartTime = 7;
    private bool gameOverBool = false;

    // Functions
    void Start()
    {
        // When the game starts, make the timer text visible/active.
        timeText.gameObject.SetActive(true);
        timerIsRunning = true;

        // Player Variable to get Player RigidBody
        GameObject player = GameObject.Find("Player");
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check if game is over
        if(gameOverBool == true)
        {
            // If game is over, set GameOver Text visible/active
            gameOverTime.gameObject.SetActive(true);

            // If restartTime is more than 0
            if(restartTime > 0)
            {
                // Set gameOverTime
                restartTime -= Time.deltaTime;
                gameOverTime.text = "Respawning... " + Mathf.RoundToInt(restartTime).ToString();
            }
            else
            {
                // If restartTime equals or is less than 0
                // Set gameOverBool as false, and set gameOverTime text inactive
                // Also load the first scene
                gameOverBool = false;
                gameOverTime.gameObject.SetActive(false);
                SceneManager.LoadScene(sceneName: "2DGame");
            }
        }
        else
        {
            // These else-if statements are to use different time on every scene
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2DGame"))
            {
                if (timerIsRunning)
                    if (timeRemaining > 0)
                    {
                        // If timeRemaining is more than 0 update the timerText
                        timeRemaining -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining).ToString();
                    }
                    else
                    {
                        // Else set timerText inactive
                        timeRemaining = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

                        // Set gameOver screen active and freeze player
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
                        // If timeRemaining is more than 0 update the timerText
                        timeRemaining2 -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining2).ToString();
                    }
                    else
                    {
                        // Else set timerText inactive
                        timeRemaining2 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

                        // Set gameOver screen active and freeze player
                        gameOver.SetActive(true);
                        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
                    }
                }

            }
            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame3"))
            {
                if (timerIsRunning)
                {
                    if (timeRemaining3 > 0)
                    {
                        // If timeRemaining is more than 0 update the timerText
                        timeRemaining3 -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining3).ToString();
                    }
                    else
                    {
                        // Else set timerText inactive
                        timeRemaining3 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

                        // Set gameOver screen active and freeze player
                        gameOver.SetActive(true);
                        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
                    }
                }

            }

            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame4"))
            {
                if (timerIsRunning)
                {
                    if (timeRemaining4 > 0)
                    {
                        // If timeRemaining is more than 0 update the timerText
                        timeRemaining4 -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining4).ToString();
                    }
                    else
                    {
                        // Else set timerText inactive
                        timeRemaining4 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

                        // Set gameOver screen active and freeze player
                        gameOver.SetActive(true);
                        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
                    }
                }

            }

            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame5"))
            {
                if (timerIsRunning)
                {
                    if (timeRemaining5 > 0)
                    {
                        // If timeRemaining is more than 0 update the timerText
                        timeRemaining5 -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining5).ToString();
                    }
                    else
                    {
                        // Else set timerText inactive
                        timeRemaining5 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

                        // Set gameOver screen active and freeze player
                        gameOver.SetActive(true);
                        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;
                    }
                }

            }
        }
    }
}

    