using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RespawnManager : MonoBehaviour
{
    // Variables
    Vector3 StartPoint;
    public TextMeshProUGUI coinText;

    // Start is called before the first frame update
    void Start()
    {
        // Set StartPoint
        StartPoint = transform.position;
    }

    void LateUpdate()
    {
        // If Transform position is less than -14, set player's new position as startpoint
        if (transform.position.y < -14)
        {
            transform.position = StartPoint;
        }

        
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2DGame"))
        {
            if (transform.position.y > 120)
            {   // If all coins have been collected, load next scene/level
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame5");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame5"))
        {
            if (transform.position.y > 73)
            {   // If all coins have been collected, load next scene/level
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame3");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame3"))
        {
            if (transform.position.y > 118)
            {   // If all coins have been collected, load next scene/level
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame4");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame4"))
        {
            if (transform.position.y > 124)
            {   // If all coins have been collected, load next scene/level
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame2");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame2"))
        {
            if (transform.position.y > 120)
            {   // If all coins have been collected, load next scene/level
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "YouWin");
            }
        }
    }

    private void CollectAllCoins()
    {   // If all coins were not collected, set coinText active
        coinText.gameObject.SetActive(true);
        StartCoroutine(waitSeconds(5));
    }

    IEnumerator waitSeconds(int time)
    {   // Wait x seconds and then make the coinText inactive
        yield return new WaitForSeconds(time);
        coinText.gameObject.SetActive(false);
    }
}