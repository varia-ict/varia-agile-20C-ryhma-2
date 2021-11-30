using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject gameOver;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverTime;
    private Rigidbody2D playerRb;
    private float timeRemaining = 60;
    private float timeRemaining2 = 180;
    private float timeRemaining3 = 60;
    private float timeRemaining4 = 90;
    private float timeRemaining5 = 60;
    private float restartTime = 7;
    public bool timerIsRunning;
    private bool gameOverBool = false;

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

        if(gameOverBool == true)
        {
            gameOverTime.gameObject.SetActive(true);

            if(restartTime > 0)
            {
                restartTime -= Time.deltaTime;
                gameOverTime.text = "Respawning... " + Mathf.RoundToInt(restartTime).ToString();
            }
            else
            {
                gameOverBool = false;
                gameOverTime.gameObject.SetActive(false);
                SceneManager.LoadScene(sceneName: "2DGame");
            }
        }
        else
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2DGame"))
            {
                if (timerIsRunning)
                    if (timeRemaining > 0)
                    {
                        timeRemaining -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining).ToString();
                    }
                    else
                    {
                        timeRemaining = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

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
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining2).ToString();
                    }
                    else
                    {
                        timeRemaining2 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

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
                        timeRemaining3 -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining3).ToString();
                    }
                    else
                    {
                        timeRemaining3 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

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
                        timeRemaining4 -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining4).ToString();
                    }
                    else
                    {
                        timeRemaining4 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

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
                        timeRemaining5 -= Time.deltaTime;
                        timeText.text = "Time:" + Mathf.RoundToInt(timeRemaining5).ToString();
                    }
                    else
                    {
                        timeRemaining5 = 0;
                        timeText.gameObject.SetActive(false);
                        timerIsRunning = false;
                        gameOverBool = true;

                        gameOver.SetActive(true);
                        playerRb.constraints = RigidbodyConstraints2D.FreezePositionX;


                    }
                }

            }
        }
    }
}

    