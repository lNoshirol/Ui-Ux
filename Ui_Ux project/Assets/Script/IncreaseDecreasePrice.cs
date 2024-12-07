using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IncreaseDecreasePrice : MonoBehaviour
{
    public TextMeshProUGUI textTochange;
    public int amount;

    public void Change()
    {
        textTochange.text = (int.Parse(textTochange.text) + amount).ToString();
    }
}
