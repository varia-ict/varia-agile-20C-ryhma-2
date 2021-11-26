using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController1 : MonoBehaviour
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
            Debug.Log("ilmassa");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //var obj = collision.gameObject;
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            Debug.Log("osuu maahan");
        }

        if (collision.gameObject.CompareTag("Collectible"))
        {
            Destroy(collision.gameObject);
            scoreText.text = "Score:" + score++.ToString();
        }
    }

}