using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuInteractions : MonoBehaviour
{

    public AudioSource backgroundTrack;
    public Slider volumeSlider;
    public static float gameVolume;
    public GameObject settingsMenu;

    private void Start()
    {
        gameVolume = volumeSlider.value;
        backgroundTrack.volume = gameVolume;
    }

    public void volumeChanged()
    {
        backgroundTrack.volume = volumeSlider.value;
    }

    public void returnToMenu()
    {
        settingsMenu.SetActive(false);
    }

}
