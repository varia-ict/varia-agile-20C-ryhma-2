using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float moveForce = 8;
    public float gravityModifier;
    public float speed = 16;
    SpriteRenderer SpriteRenderer;
    private bool timerIsRunning;

    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        SpriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    /*void LateUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //playerRb.AddForce(Vector3.left * moveForce, ForceMode2D.Impulse);
            GetComponent<Rigidbody2D>().velocity = new Vector3(-25, 0, 0);
        }
    }*/
    private void FixedUpdate()
    {
        GameObject manager = GameObject.Find("SpawnManager");
        SpawnManager spawnManager = manager.GetComponent<SpawnManager>();

        timerIsRunning = spawnManager.timerIsRunning;

        if (Input.GetKey(KeyCode.D) && timerIsRunning)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            SpriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A) && timerIsRunning)
        {
            transform.position += Vector3.right * -speed * Time.deltaTime;
            SpriteRenderer.flipX = true;
        }
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //playerRb.AddForce(movement * speed * gravityModifier);
    }
}
