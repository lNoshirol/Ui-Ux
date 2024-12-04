using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class TejPopUp : MonoBehaviour
{
    public int millisecondeTimer = 3000;

    private async void OnEnable()
    {
        await Task.Delay(millisecondeTimer);
        gameObject.SetActive(false);
    }
}
