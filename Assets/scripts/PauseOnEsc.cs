using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOnEsc : MonoBehaviour
{
    [SerializeField]
    GameObject pausemenu = null;
    void Start()
    {
        pausemenu.SetActive(false);
    }
    public static bool isPaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Time.timeScale = 0.00001f;
                isPaused = true;
            }
            else
            {
                Time.timeScale = 1;
                isPaused = false;

            }

        }
        pausemenu.SetActive(isPaused);


    }
}
