using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RespawnManager : MonoBehaviour
{
    Vector3 StartPoint;
    public TextMeshProUGUI coinText;

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

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2DGame"))
        {
            if (transform.position.y > 120)
            {
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame5");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame5"))
        {
            if (transform.position.y > 73)
            {
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame3");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame3"))
        {
            if (transform.position.y > 118)
            {
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame4");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame4"))
        {
            if (transform.position.y > 124)
            {
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "2Dgame2");
            }
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("2Dgame2"))
        {
            if (transform.position.y > 120)
            {
                if (GameObject.Find("coin") != null) CollectAllCoins();
                else SceneManager.LoadScene(sceneName: "YouWin");
            }
        }
    }

    private void CollectAllCoins()
    {
        coinText.gameObject.SetActive(true);
        StartCoroutine(waitSeconds(5));
    }
    IEnumerator waitSeconds(int time)
    {
        yield return new WaitForSeconds(time);
        coinText.gameObject.SetActive(false);
    }
}