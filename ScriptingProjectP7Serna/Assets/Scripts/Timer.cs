using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private float timer;
    public TextMeshProUGUI timerUI;

    public bool isGameActive;


    public void StartGame(int difficulty)
    {
        StartCoroutine(UpdateTimer());
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    IEnumerator UpdateTimer()
    {
        while (timer > 0 && isGameActive)
        {
            yield return new WaitForSeconds(1);
            timer += 1;
            timerUI.text = "Timer: " + timer;
        }
        GameOver();
    }
}
