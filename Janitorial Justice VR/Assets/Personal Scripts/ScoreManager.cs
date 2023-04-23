using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public AudioSource winAudio;
    public AudioSource backgroundAudio;

    [SerializeField] GameObject levelOneInterface;

    public float score;
    public TextMeshProUGUI scoreCounter;
    
    void Start()
    {
        UpdatedScore(0);
    }

    public void UpdatedScore (float points)
    {
        score += points;
        scoreCounter.text = score + "%";

        if (score >= 100)
        {
            Debug.Log("All Cleaned Up");
            winAudio.Play();
            backgroundAudio.Stop();
            levelOneInterface.SetActive(true);
            Timer.timerOn = false;
        }
    }
}
