using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class menuManager : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject MenuCamera;
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
        if (Input.GetKeyDown(KeyCode.R))
        {
            MenuCamera.SetActive(false);
            Time.timeScale = 1;
        }
    }
}


