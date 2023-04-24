using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialEnemyHealth : MonoBehaviour
{
    public AudioSource winAudio;
    public AudioSource triggerZone1;
    public AudioSource triggerZone2;
    public AudioSource triggerZone3;

    [SerializeField] GameObject levelThreeInterface;
    [SerializeField] GameObject healthInterface;

    private float health= 200;
    public TextMeshProUGUI healthCounter;

    void Start()
    {
        TakeDamage(0);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        healthCounter.text = " " + health;

        if (health <= 0)
        {
            Destroy(gameObject);
            winAudio.Play();
            triggerZone1.Stop();
            triggerZone2.Stop();
            triggerZone3.Stop();
            levelThreeInterface.SetActive(true);
            Timer.timerOn = false;
        }
    }
}
