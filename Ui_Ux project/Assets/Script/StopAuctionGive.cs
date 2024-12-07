using UnityEngine;

public class StopAuctionGive : MonoBehaviour
{
    public GameObject disappear;
    public GameObject appear;

    public void GiveShitToShitter()
    {
        Starf.instance.trucAppear = appear;
        Starf.instance.trucDisappear = disappear;
    }
}
