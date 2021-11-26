using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject MenuCamera;
    public Button resumeButton;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.GetComponent<GameObject>();
        MenuCamera.GetComponent<GameObject>();
        MenuCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            MenuCamera.SetActive(true);
        }

        resumeButton.onClick.AddListener(() => ResumeGame());
    }

    void ResumeGame()
    {
        MenuCamera.SetActive(false);
    }

}