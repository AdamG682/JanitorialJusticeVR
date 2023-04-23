using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{

    //identify audio that is being played
    public AudioSource audioPlayer;

    //the damage value of each weapon
    private float wetFloor = 5;
    private float sponge = 1;


    private void OnTriggerEnter (Collider other)
    {
        //checking to see if the enemy tag and wet floor sign tag are colliding, each time it does enemy takes 5 hit points of damage
        if (other.gameObject.CompareTag("TutorialEnemy") && gameObject.CompareTag("WetFloor"))
        {
            
            if (other.gameObject.TryGetComponent<TutorialEnemyHealth>(out TutorialEnemyHealth enemyComponent))
            {
                //audio that is played whenever enemy is hit, altering pitch of the audio clip
                audioPlayer.pitch = (Random.Range(0.95f, 1.25f));
                audioPlayer.Play();

                enemyComponent.TakeDamage(wetFloor);
                Debug.Log("5 Damage Taken");
            }
        }

        //checking to see if the enemy tag and sponge tag are colliding, each time it does enemy takes 1 hit point of damage
        else if (other.gameObject.CompareTag("TutorialEnemy") && gameObject.CompareTag("Sponge"))
        {

            if (other.gameObject.TryGetComponent<TutorialEnemyHealth>(out TutorialEnemyHealth enemyComponent))
            {
                //audio that is played whenever enemy is hit, altering pitch of the audio clip
                audioPlayer.pitch = (Random.Range(0.95f, 1.25f));
                audioPlayer.Play();

                enemyComponent.TakeDamage(sponge);
                Debug.Log("1 Damage Taken");
            }
        }
    }

}
