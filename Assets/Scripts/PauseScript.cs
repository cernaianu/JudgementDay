using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    
    public static bool isGamePaused;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        if (!isGamePaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isGamePaused = true;
        }
        else
        {
            return;
        }
    }
}
