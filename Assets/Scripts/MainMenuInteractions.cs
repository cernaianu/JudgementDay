using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuInteractions : MonoBehaviour
{
    public GameObject settingsPanel;
    public AudioSource menuItemAudioClip;

    public void StartGame()
    {
        menuItemAudioClip.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void EnterSettings()
    {
        menuItemAudioClip.Play();
        settingsPanel.SetActive(true);
    }

    public void ExitGame()
    {
        menuItemAudioClip.Play();
        Application.Quit();
    }




}
