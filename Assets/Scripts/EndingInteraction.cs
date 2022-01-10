using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingInteraction : MonoBehaviour
{
    private bool isEndingReached = false;

    private void Awake()
    {
        isEndingReached = true;
    }

    private void Update()
    {
        
        if(isEndingReached)
            if(Input.anyKey)
                SceneManager.LoadScene(0);
    }


}
