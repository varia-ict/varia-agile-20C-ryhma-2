using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float moveForce = 8;
    public float gravityModifier;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    /*void LateUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerRb.AddForce(Vector3.right * moveForce, ForceMode2D.Impulse);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(25, 0, 0);
        }
    }*/
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        playerRb.AddForce(movement * speed * gravityModifier);
    }
}
