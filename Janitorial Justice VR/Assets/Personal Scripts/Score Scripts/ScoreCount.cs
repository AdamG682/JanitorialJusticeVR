using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{

    public AudioSource scoreAudio;

    private float brick = 1;

    private void OnTriggerEnter(Collider other)
    {  
        if(other.gameObject.CompareTag("TrashCan") && gameObject.CompareTag("Brick"))
        {
            if (other.gameObject.TryGetComponent<ScoreManager>(out ScoreManager trashComponent))
            {
                scoreAudio.Play();
                trashComponent.UpdatedScore(brick);
                Destroy(gameObject);
                Debug.Log("1 Point");
            }
        }

    }
}
