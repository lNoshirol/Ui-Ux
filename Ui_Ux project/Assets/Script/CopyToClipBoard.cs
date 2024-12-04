using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CopyToClipBoard : MonoBehaviour
{
    public void OnClick()
    {
        GUIUtility.systemCopyBuffer = GetComponentInChildren<TextMeshProUGUI>().text;
    }
}
