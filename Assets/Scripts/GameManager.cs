using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variables
    public Button youWinBtn;
    public Button startGame;

    // Functions
    void Update()
    {
        // Add listeners to youWin Button and startGame Button
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
