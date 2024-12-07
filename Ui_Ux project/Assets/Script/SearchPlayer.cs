using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SearchPlayer : MonoBehaviour
{
    public TMP_InputField TMP_if;

    public GameObject playerOwnProfile;
    public GameObject otherPlayerPanel;
    public TextMeshProUGUI otherPlayerCodeText;

    public GameObject codeTooShort;
    public GameObject codeTooLong;

    public GameObject realOptionPanel;

    public GameObject userNotFound;

    public int testNumber;

    
    private void Start()
    {
        TMP_if = GetComponent<TMP_InputField>();
    }

    public void OnEndEdit()
    {
        if (TMP_if.text.Length < 6)
        {
            codeTooShort.SetActive(true);
            TMP_if.text = string.Empty;
        }
        else if (TMP_if.text.Length > 6)
        {
            codeTooLong.SetActive(true);
            TMP_if.text = string.Empty;
        }
        else if (TMP_if.text == "619269")
        {
            playerOwnProfile.SetActive(true);
            TMP_if.text = string.Empty;
            realOptionPanel.SetActive(false);
        }
        else if (IsPrimeNumber(int.Parse(TMP_if.text)))
        {
            userNotFound.SetActive(true);
            TMP_if.text = string.Empty;
        }
        else if (!IsPrimeNumber(int.Parse(TMP_if.text)))
        {
            otherPlayerCodeText.text = TMP_if.text;
            otherPlayerPanel.SetActive(true);
            TMP_if.text = string.Empty;
            realOptionPanel.SetActive(false);
        }
    }

    public bool IsPrimeNumber(int number)
    {
        for ( int i = 1; i < number/2 +1; i++ )
        {
            if ( !(i % 2 == 0) && (!(number.ToString()[number.ToString().Length-1] == '5') || !(number.ToString()[number.ToString().Length - 1] == '0')) && i != 1 && i != number)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
