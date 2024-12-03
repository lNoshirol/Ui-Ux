using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InshallahAdrienIlVerraPas : MonoBehaviour
{
    public GameObject viewPortToChange;

    public GameObject InshallahIlVerraPas;

    public void Change()
    {
        viewPortToChange.GetComponent<ScrollRect>().content = InshallahIlVerraPas.GetComponent<RectTransform>();
    }
}