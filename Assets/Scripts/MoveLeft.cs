using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Public Variables
    public float moveForce = 8;
    public float gravityModifier;
    public float speed = 16;
    SpriteRenderer SpriteRenderer;

    // Private Variables
    private bool timerIsRunning;
    private Rigidbody2D playerRb;
    
    // Functions
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        // Get SpawnManager Script
        GameObject manager = GameObject.Find("SpawnManager");
        SpawnManager spawnManager = manager.GetComponent<SpawnManager>();

        // Get timerIsRunning Boolean from spawnManager Script
        timerIsRunning = spawnManager.timerIsRunning;

        if (Input.GetKey(KeyCode.D) && timerIsRunning)
        {
            // If D is pressed and timerIsRunning set player x position, and move player
            transform.position += Vector3.right * speed * Time.deltaTime;
            SpriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A) && timerIsRunning)
        {
            // If A is pressed and timerIsRunning set player x position, and move player
            transform.position += Vector3.right * -speed * Time.deltaTime;
            SpriteRenderer.flipX = true;
        }
    }
}
