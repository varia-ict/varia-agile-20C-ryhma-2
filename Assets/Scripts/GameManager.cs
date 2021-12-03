using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button youWinBtn;
    public Button startGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        youWinBtn.onClick.AddListener(() => Restart());
        startGame.onClick.AddListener(() => StartGame());
    }

    private void Restart()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }

    private void StartGame()
    {
        SceneManager.LoadScene(sceneName: "2DGame");
    }
}
