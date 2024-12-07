using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TejOnDisable : MonoBehaviour
{
    public GameObject trucToTej;

    private void OnDisable()
    {
        trucToTej.SetActive(false);
    }
}
