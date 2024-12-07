using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeName : MonoBehaviour
{
    public TextMeshProUGUI dungeonText;
    public TextMeshProUGUI levelText;

    public List<GameObject> stars;
    public int starsNumber;

    public void AledFunction(string name)
    {
        foreach (GameObject go in stars)
        {
            go.SetActive(false);
        }

        dungeonText.text = name;
        
        levelText.text = "level " + name[name.Length-1];
        
        for (int i = 0; i < starsNumber; i++)
        {
            stars[i].SetActive(true);
        }
    }
}
