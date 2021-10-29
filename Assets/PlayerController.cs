using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float jumpForce = 10;
    public float moveForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D)&& isOnGround)
        {
            playerRb.AddForce(Vector3.right * moveForce, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.A) && isOnGround)
        {
            playerRb.AddForce(Vector3.left * moveForce, ForceMode2D.Impulse);
        }
    }
}