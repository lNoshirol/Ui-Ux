using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLoose : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject loosePanel;

    public void AndTheResultIs()
    {
        if (Random.Range(1, 100) % 2 == 0)
        {
            winPanel.SetActive(true);
        }
        else
        {
            loosePanel.SetActive(true);
        }
    }
}