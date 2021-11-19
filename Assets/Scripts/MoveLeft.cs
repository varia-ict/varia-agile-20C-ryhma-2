using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float moveForce = 8;
    public float gravityModifier;
    public float moveSpeed = 17;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            spriteRenderer.flipX = true;
        }
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        //playerRb.AddForce(movement * speed * gravityModifier);
    }
}
