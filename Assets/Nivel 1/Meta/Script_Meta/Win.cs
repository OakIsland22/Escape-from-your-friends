using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject TXTWin_P2;
    public GameObject TXTWin_P3;
    public GameObject TXT_Perdiste_P1;

    private bool Player_2_WIn = false;
    private bool Player_3_WIn = false;

    private void Update()
    {
        if (Player_2_WIn && Player_3_WIn)
        {
            AmbosPerdieron2();
        }
        else if (Player_2_WIn || Player_3_WIn)
        {
            AmbosPerdieron1();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player_2"))
        {
            TXTWin_P2.SetActive(true);
            Player_2_WIn = true;
            AmbosPerdieron2();
        }
        if (other.gameObject.CompareTag("Player_3"))
        {
            TXTWin_P3.SetActive(true);
            Player_3_WIn = true;
            AmbosPerdieron2();
        }
    }

    private void AmbosPerdieron1()
    {
        SceneManager.LoadScene("EscenaVictoriaPresas - copia");
    }

    private void AmbosPerdieron2()
    {
        if (Player_2_WIn && Player_3_WIn)
        {
            SceneManager.LoadScene("EscenaVictoriaCazador");
        }
    }
}
