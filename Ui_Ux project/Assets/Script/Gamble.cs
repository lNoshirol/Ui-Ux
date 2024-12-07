using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Gamble : MonoBehaviour
{
    public List<GameObject> PNJText;
    public List<GameObject> PlayerText;

    public GameObject winPanel;

    public int playerGamble;

    public bool hasWon;

    public async void TheGamble()
    {
        GetComponent<Button>().enabled = false;

        PlayerText[playerGamble].SetActive(true);
        playerGamble++;

        WinCondition();

        await Task.Delay(1000);

        if (hasWon)
        {
            return;
        }
        else
        {
            PNJText[playerGamble].SetActive(true);
            GetComponent<Button>().enabled = true;
        }

    }

    public void Reset()
    {
        foreach (GameObject go in PlayerText)
        {
            go.SetActive(false);
        }
        foreach (GameObject go in PNJText)
        {
            go.SetActive(false);
        }
        PNJText[0].SetActive(true);
        playerGamble = 0;

        GetComponent<Button>().enabled = true;
    }

    public void WinCondition()
    {
        int random = Random.Range(1, 100);

        if (random % 4 == 0)
        {
            winPanel.SetActive(true);
            hasWon = true;
        }

        if (playerGamble == 12)
        {
            winPanel.SetActive(true);
            hasWon = true;
        }
    }
}
