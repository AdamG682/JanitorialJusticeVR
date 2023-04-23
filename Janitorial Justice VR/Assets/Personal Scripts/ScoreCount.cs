using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{

    //identify audio that is being played
    public AudioSource scoreAudio;

    //point value of the brick item
    private float brick = 5;

    private void OnTriggerEnter(Collider other)
    {  
        //checking to see if the trash can tag and brick tag are colliding
        if(other.gameObject.CompareTag("TrashCan") && gameObject.CompareTag("Brick"))
        {
            if (other.gameObject.TryGetComponent<ScoreManager>(out ScoreManager trashComponent))
            {
                //audio that is played whenever a brick is dropped into the dumpster, altering pitch of the audio clip
                scoreAudio.pitch = (Random.Range(0.95f, 1.25f));
                scoreAudio.Play();

                //adds points to the score while also destroying the brick everytime it hits the dumpster score collider
                trashComponent.UpdatedScore(brick);
                Destroy(gameObject);
                Debug.Log("5% Clean");
            }
        }

    }
}
