using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RespawnManager : MonoBehaviour
{
    Vector3 StartPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartPoint = transform.position;
    }

    void LateUpdate()
    {
        if (transform.position.y< -14)
        {
            transform.position = StartPoint;
        }
        if (transform.position.y > 120)
        {
            SceneManager.LoadScene(sceneName: "2Dgame2");
        }
    }
}
