using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftingScript : MonoBehaviour
{

    //private float broom = 1;
    [SerializeField] GameObject levelTwoInterface;
    [SerializeField] GameObject ComboBroom;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Broom") && gameObject.CompareTag("CraftCollider"))
        {
            ComboBroom.SetActive(true);
            levelTwoInterface.SetActive(true);
            Debug.Log("Crafted");
        }

        //if (other.gameObject.CompareTag("Broom") && gameObject.CompareTag("CraftCollider"))
        //{
        //    if (other.gameObject.TryGetComponent<CraftManager>(out CraftManager craftComponent))
        //    {
        //        craftComponent.CraftedItem(broom);
        //        Debug.Log("1 Broom Added");
        //    }
        //}

        //if (other.gameObject.CompareTag("BroomTwo") && gameObject.CompareTag("CraftCollider"))
        //{
        //    if (other.gameObject.TryGetComponent<CraftManager>(out CraftManager craftComponent))
        //    {
        //         craftComponent.CraftedItem(broom);
        //         Debug.Log("1 Broom Added");
        //    }
        //}

    }
}
