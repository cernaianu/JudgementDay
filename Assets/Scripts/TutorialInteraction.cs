using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInteraction : MonoBehaviour
{

    public GameObject tutorialScreen;
    private bool isTutorialOn = false;

    public void OnEnable()
    {
        Time.timeScale = 0f;
        isTutorialOn = true;
    }

    private void Update()
    {
        if(isTutorialOn)
            if (Input.anyKey)
                tutorialScreen.SetActive(false);
    }

    public void OnDisable()
    {
        Time.timeScale = 1f;
        isTutorialOn = false;
    }
}
