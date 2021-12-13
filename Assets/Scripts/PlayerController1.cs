using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController1 : MonoBehaviour
{
    // Public Variables
    public AudioSource jumpsound;
    public float jumpForce = 20;
    public float gravityModifier;
    public bool isOnGround = true;
    public AudioSource coinSound1;
    // Private Variables
    private Rigidbody2D playerRb;
    private bool timerIsRunning;

    // Functions
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        jumpsound = GetComponent<AudioSource>();
    }

    void LateUpdate()
    {
        //var isTouch = playerJump.GetComponent<BoxCollider2D>()
        GameObject manager = GameObject.Find("SpawnManager");
        SpawnManager spawnManager = manager.GetComponent<SpawnManager>();

        timerIsRunning = spawnManager.timerIsRunning;

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && timerIsRunning)
        {
            // If Player Presses Space, isOnGround is true and timerIsRunning is true
            // Play jumpsound
            jumpsound.Play();
            // Add force to player to make player jump
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            // Set isOnGround false
            isOnGround = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //var obj = collision.gameObject;
        if (collision.gameObject.CompareTag("Ground"))
        {
            // If Player Touched Ground, set isOnGround true
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Collectible"))
        {
            // If player collides with gameobject that has tag "Collectible"
            // Destroy other gameObject
            coinSound1.Play();
            Destroy(collision.gameObject);
        }
    }

}