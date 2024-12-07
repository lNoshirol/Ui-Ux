using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaMereLaPute : MonoBehaviour
{
    public GameObject cardToAdd;
    public GameObject emptySlotToRemove;

    public GameObject timer;

    public List<GameObject> buttons;

    public void GiveObjects()
    {
        SaPereLaPute.instance.cardToAdd = cardToAdd;
        SaPereLaPute.instance.emptySlotToRemove = emptySlotToRemove;

        foreach (GameObject button in buttons)
        {
            button.GetComponent<SaMereLaPute>().timer = timer;
        }
    }

    public void GiveTime(int time)
    {
        timer.GetComponent<Timer>().startTime = time;
    }
}
