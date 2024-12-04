using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public void Change(float scale)
    {
        gameObject.transform.localScale = new Vector3 (scale, scale, scale);
    }

    public void ResetScale()
    {
        gameObject.transform.localScale = Vector3.one;
    }
}
