using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Variables
    public GameObject Player;

    // Functions
    void Update()
    {
        // Sets the camera position
        transform.position = Player.transform.position + new Vector3(1, 1, -35);
    }
}
