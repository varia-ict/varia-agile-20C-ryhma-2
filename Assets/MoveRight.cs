using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float moveForce = 15;
    public float gravityModifier;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerRb.AddForce(Vector3.right * moveForce, ForceMode2D.Impulse);
        }
    }
}
