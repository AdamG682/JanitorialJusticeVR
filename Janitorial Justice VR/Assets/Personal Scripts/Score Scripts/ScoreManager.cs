using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public AudioSource winAudio;

    [SerializeField] GameObject levelOneInterface;
    //[SerializeField] GameObject scoreInterface;
    //[SerializeField] GameObject wristInterface;

    private float score;
    public TextMeshProUGUI scoreCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdatedScore(0);
    }

    public void UpdatedScore (float points)
    {
        score += points;
        scoreCounter.text = ": " + score;

        if (score >= 20)
        {
            Debug.Log("Winner");
            winAudio.Play();
            //scoreInterface.SetActive(false);
            levelOneInterface.SetActive(true);
        }
    }
}
