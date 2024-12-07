using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starf : MonoBehaviour
{
    public static Starf instance;

    public GameObject trucDisappear;
    public GameObject trucAppear;

    public List<GameObject> parents;

    private void Awake()
    {
        instance = this;

        foreach (GameObject parent in parents)
        {
            parent.SetActive(false);
        }
    }

    public void JEANNAYMAR()
    {
        trucAppear.SetActive(true);
        trucDisappear.SetActive(false);
    }
}
