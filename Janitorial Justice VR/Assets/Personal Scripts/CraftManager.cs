using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CraftManager : MonoBehaviour
{

    [SerializeField] GameObject levelTwoInterface;
    [SerializeField] GameObject ComboBroom;

    private float crafter;

    // Start is called before the first frame update
    void Start()
    {
        CraftedItem(0);

    }

    public void CraftedItem (float items)
    {
        crafter += items;

        if (crafter >= 2)
        {
            ComboBroom.SetActive(true);
            levelTwoInterface.SetActive(true);
            Debug.Log("Crafted");
        }
    }
}
