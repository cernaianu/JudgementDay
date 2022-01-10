using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    private float currentTime;
    private bool isTimerStarted;
    private bool isTimerStopped;
    private float startingTime = 60f;

    public float CurrentTime { get => currentTime; 
    
        set
        {
            currentTime = value;

            GetComponent<TextMeshProUGUI>().text = "Timer: " + currentTime.ToString("0");
        }

    }

   

    // Update is called once per frame
    void Update()
    {
        if (isTimerStarted)
        {
            CurrentTime -= 1 * Time.deltaTime;
            
            if (currentTime <= 0)
            {
                int randomChoice = Random.Range(0, 2);

                if(randomChoice == 0)
                    FindObjectOfType<GameManager>().GetComponent<SendSoul>().SendSoulToHeaven();
                else FindObjectOfType<GameManager>().GetComponent<SendSoul>().SendSoulToHell();

                //ResetTimer();
            }
        }
        else if (isTimerStopped)
            return;
        
        


    }

    public void StartTimer()
    {

        isTimerStarted = true;
    }

    public void ResetTimer()
    {
        currentTime = startingTime;
    }

    public void PauseTimer()
    {
        isTimerStopped = true;
    }

    public void InitializeTimer()
    {
        currentTime = startingTime;
    }

}
