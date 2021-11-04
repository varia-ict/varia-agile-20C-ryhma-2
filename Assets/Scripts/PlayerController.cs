using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public AudioSource jumpsound;
    public float jumpForce = 20;
    public float gravityModifier;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        jumpsound = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            jumpsound.Play();
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;

        }

       }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }
}