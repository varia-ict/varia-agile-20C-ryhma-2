using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    // Variables
    public GameObject MainCamera;
    public GameObject MenuCamera;
    public Button resumeButton;

    // Functions
    void Start()
    {
        // On Start Set MainCamera inactive
        MainCamera.GetComponent<GameObject>();
        MenuCamera.SetActive(false);
    }

    void Update()
    {
        // If ESC is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Set MenuCamera active
            Time.timeScale = 0;
            MenuCamera.SetActive(true);
        }

        // Add listener to resumeButton
        resumeButton.onClick.AddListener(() => ResumeGame());
    }

    void ResumeGame()
    {
        // Set MenuCamera inactive
        MenuCamera.SetActive(false);
        Time.timeScale = 1;
    }
}


