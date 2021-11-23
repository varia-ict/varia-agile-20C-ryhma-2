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
        if (transform.position.y < -14)
        {
            transform.position = StartPoint;
        }
        if (transform.position.y > 120)
        {
            SceneManager.LoadScene(sceneName: "2Dgame2");
        }
        if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame2")))
        {
            if (transform.position.y > 120)
            {
                SceneManager.LoadScene(sceneName: "2Dgame3");
            }
        }
        if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame3")))
        {
            if (transform.position.y > 50)
            {
                SceneManager.LoadScene(sceneName: "2Dgame4");
            }
        }
        if ((SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame4")))
        {
            if (transform.position.y > 123)
            {
                SceneManager.LoadScene(sceneName: "2Dgame5");
            }
        }
    }
}