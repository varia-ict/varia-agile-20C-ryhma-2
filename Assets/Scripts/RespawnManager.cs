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
        if (transform.position.y < -14) { transform.position = StartPoint; }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2DGame"))
        {
            if (transform.position.y > 120)
            {
                SceneManager.LoadScene(sceneName: "2Dgame2");
            }
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame2"))
        {
            if (transform.position.y > 120)
            {
                SceneManager.LoadScene(sceneName: "2Dgame3");
            }
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame3"))
        {
            if (transform.position.y > 116)
            {
                SceneManager.LoadScene(sceneName: "2Dgame4");
            }
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame4"))
        {
            if (transform.position.y > 122)
            {
                SceneManager.LoadScene(sceneName: "2Dgame5");
            }
        }

        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame5"))
        {
            if (transform.position.y > 64)
            {
                SceneManager.LoadScene(sceneName: "YouWin");
            }
        }
    }
}