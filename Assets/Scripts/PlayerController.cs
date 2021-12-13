using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Public Variables
    public AudioSource jumpsound;
    public float jumpForce = 20;
    public float gravityModifier;
    public bool isOnGround = true;
    public AudioSource coinSound;

    // Private Variables
    private Rigidbody2D playerRb;
    private bool timerIsRunning;

    // Functions
    void Start()
    {
        // Get Player RigidBody
        playerRb = GetComponent<Rigidbody2D>();
        // Set Gravity
        Physics.gravity *= gravityModifier;
        // Set JumpSound
        jumpsound = GetComponent<AudioSource>();
    }

    void LateUpdate()
    {
        // Get spawnManager Script
        GameObject manager = GameObject.Find("SpawnManager");
        SpawnManager spawnManager = manager.GetComponent<SpawnManager>();

        // Get timerIsRunning Boolean from spawnManager Script
        timerIsRunning = spawnManager.timerIsRunning;

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && timerIsRunning)
        {
            // If Space is pressed, player is on ground and timer is running
            // Play jump sound
            jumpsound.Play();
            // Add Force to player rigidbody to make player jump
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            // Set isOnGround false
            isOnGround = false;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var obj = collision.gameObject;
        if (collision.gameObject == obj.gameObject)
        {
            // If player touched ground, set isOnGround true
            isOnGround = true;
        }

        if (collision.gameObject.CompareTag("Collectible"))
        {
            // If player collides with gameObject that has tag "Collectible"
            // Destroy other gameObject
            coinSound.Play();
            Destroy(collision.gameObject);
        }
    }
}