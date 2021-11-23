using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    //public GameObject playerJump;
    public AudioSource jumpsound;
    public TextMeshProUGUI scoreText;

    
    public float jumpForce = 20;
    public float gravityModifier;
    public bool isOnGround = true;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        jumpsound = GetComponent<AudioSource>();
        //playerJump = playerJump.GetComponent<BoxCollider2D>();
        scoreText.gameObject.SetActive(true);
        scoreText.text = "Score:" + score.ToString();
    }

    // Update is called once per frame

    void LateUpdate()
    {
        //var isTouch = playerJump.GetComponent<BoxCollider2D>()

        
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
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
            Destroy(collision.gameObject);
            scoreText.text = "Score:" + score++.ToString();
        }
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //isOnGround = true;
    //    var component = collision.gameObject.GetComponent<BoxCollider2D>();
    //    Debug.Log(component);
    //    if (component.CompareTag("Ground"))
    //    {
    //        isOnGround = true;
    //    }

    //}
}