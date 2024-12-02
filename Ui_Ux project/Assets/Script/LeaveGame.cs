using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveGame : MonoBehaviour
{
    public void OnCLick()
    {
        Application.Quit();
        Debug.Log("Vous quittez le jeu");
    }
}