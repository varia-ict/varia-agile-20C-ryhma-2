using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public AudioSource jumpsound;
    public float jumpForce = 20;
    public float gravityModifier;
    private bool timerIsRunning;
    public bool isOnGround = true;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    //private GameObject spawnManager2;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        jumpsound = GetComponent<AudioSource>();

        scoreText.gameObject.SetActive(true);
        scoreText.text = "Score:" + score.ToString();
    }

    // Update is called once per frame

    void LateUpdate()
    {
        GameObject manager = GameObject.Find("SpawnManager");
        SpawnManager spawnManager = manager.GetComponent<SpawnManager>();

        timerIsRunning = spawnManager.timerIsRunning;

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && timerIsRunning)
        {
            jumpsound.Play();
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;

        }

       }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if (collision.gameObject == obj.gameObject)
        {
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Collectible"))
        {
            score++;
            Destroy(collision.gameObject);
<<<<<<< HEAD
            scoreText.text = "Score:" + score++.ToString();
=======
            scoreText.text = "Score: " + score.ToString();
>>>>>>> Aleksi/Säätöä
        }
    }
}