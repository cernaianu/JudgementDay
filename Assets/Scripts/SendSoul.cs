using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendSoul : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    public void SendSoulToHeaven()
    {
        if (gameManager.soulsQueue.Count == 0)
            return;

        if (gameManager.CurrentSoul.Sinner)
            if (gameManager.CurrentSoul.Age <= 21)
                gameManager.Alignment -= 4;
            else gameManager.Alignment -= 2;
        else gameManager.Alignment += 2;

        gameManager.removeCurretSoulFromQueue();
        gameManager.changeCurrentSoul();
        gameManager.ResetTimer();
    }

    public void SendSoulToHell()
    {
        if (gameManager.soulsQueue.Count == 0)
            return;


        if (!gameManager.CurrentSoul.Sinner)
            if (gameManager.CurrentSoul.Age >= 21)
                gameManager.Alignment -= 4;
            else gameManager.alignment -= 2;
        else gameManager.Alignment += 2;

        gameManager.removeCurretSoulFromQueue();
        gameManager.changeCurrentSoul();
        gameManager.ResetTimer();
    }

}
