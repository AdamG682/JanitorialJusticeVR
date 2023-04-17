using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeRemaining;
    static public bool timerOn = false;

    public TextMeshProUGUI timer;

    public int sceneIndex;

    void Start()
    {
        timerOn = true;
    }

    void Update()
    {
        if (timerOn)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                updateTimer(timeRemaining);
            }

            else
            {
                Debug.Log("You're Fired");
                timeRemaining = 0;
                timerOn = false;
                SceneManager.LoadScene(sceneIndex);
            }
        }
        
    }

    void updateTimer (float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
