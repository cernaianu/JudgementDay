using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuInteractions : MonoBehaviour
{
    
    public void ResumeGame()
    {
        if(PauseScript.isGamePaused)
        {
            gameObject.SetActive(false);
            Time.timeScale = 1f;
            PauseScript.isGamePaused = false;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
