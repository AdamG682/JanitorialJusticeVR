using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftingScript : MonoBehaviour
{
    public AudioSource winAudio;
    public AudioSource triggerZone1;
    public AudioSource triggerZone2;

    public float crafting;

    [SerializeField] GameObject levelTwoInterface;
    [SerializeField] GameObject ComboBroom;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Broom") && gameObject.CompareTag("CraftCollider"))
        {
            crafting++;
            Debug.Log(crafting);
        }

        else if (other.gameObject.CompareTag("BroomTwo") && gameObject.CompareTag("CraftCollider"))
        {
            crafting++;
            Debug.Log(crafting);
        }

        if (crafting >= 2)
        {
            ComboBroom.SetActive(true);
            levelTwoInterface.SetActive(true);
            Debug.Log("Crafted");
            Timer.timerOn = false;
            triggerZone1.Stop();
            triggerZone2.Stop();
            winAudio.Play();
        }
    }
}
