using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaPereLaPute : MonoBehaviour
{
    public static SaPereLaPute instance;

    public GameObject cardToAdd;
    public GameObject emptySlotToRemove;

    public List<GameObject> parents;

    private void Awake()
    {
        instance = this;
        foreach (GameObject parent in parents)
        {
            parent.SetActive(false);
        }
    }

    public void ExecuteTaMere()
    {
        cardToAdd.SetActive(true);
        emptySlotToRemove.SetActive(false);
    }
}
