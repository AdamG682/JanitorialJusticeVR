using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{

    public AudioSource audioPlayer;
    public AudioSource audioPlayer1;
    
    private float wetFloor = 5;
    private float sponge = 1;


    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("TutorialEnemy") && gameObject.CompareTag("WetFloor"))
        {
            
            if (other.gameObject.TryGetComponent<TutorialEnemyHealth>(out TutorialEnemyHealth enemyComponent))
            {
                audioPlayer.Play();
                audioPlayer1.Play();
                enemyComponent.TakeDamage(wetFloor);
                Debug.Log("5 Damage Taken");
            }
        }

        else if (other.gameObject.CompareTag("TutorialEnemy") && gameObject.CompareTag("Sponge"))
        {

            if (other.gameObject.TryGetComponent<TutorialEnemyHealth>(out TutorialEnemyHealth enemyComponent))
            {
                audioPlayer.Play();
                audioPlayer1.Play();
                enemyComponent.TakeDamage(sponge);
                Debug.Log("1 Damage Taken");
            }
        }
    }

}
