using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Player_1 : MonoBehaviour
{
    public VidaPlayer_1 player_2;
    public VidaPlayer_3 player_3;

    public GameObject win_P1;
    private void Update()
    {
        if(player_2.vida == 0 && player_3.vida == 0)
        {
            win_P1.gameObject.SetActive(true);
        }
    }
}
