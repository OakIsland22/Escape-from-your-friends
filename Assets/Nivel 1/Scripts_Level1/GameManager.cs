using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator animator_vida_1;
    public Animator animator_vida_2;
    public Animator animator_vida_3;

    public VidaPlayer_1 vidaP1;
    public VidaPlayer_3 vidaP2;

    public Animator P3animator_vida_1;
    public Animator P3animator_vida_2;
    public Animator P3animator_vida_3;
    private void FixedUpdate()
    {
        AnimacionesP1();
        AnimacionesP2();
        AmbosPerdieron();
       
    }

    private void AnimacionesP1()
    {
        if (vidaP1.vida <= 5)
        {
            animator_vida_3.SetBool("perdioMitad", true);
        }
        if (vidaP1.vida <= 4)
        {
            animator_vida_3.SetBool("perdioUna", true);
        }
        if (vidaP1.vida <= 3)
        {
            animator_vida_2.SetBool("perdioMitad", true);
        }
        if (vidaP1.vida <= 2)
        {
            animator_vida_2.SetBool("perdioUna", true);
        }
        if (vidaP1.vida <= 1)
        {
            animator_vida_1.SetBool("perdioMitad", true);
        }
        if (vidaP1.vida <= 0)
        {
            animator_vida_1.SetBool("perdioUna", true);
        }
    }

    private void AnimacionesP2()
    {
        if (vidaP2.vida <= 5)
        {
            P3animator_vida_3.SetBool("perdioMitad", true);
        }
        if (vidaP2.vida <= 4)
        {
            P3animator_vida_3.SetBool("perdioUna", true);
        }
        if (vidaP2.vida <= 3)
        {
            P3animator_vida_2.SetBool("perdioMitad", true);
        }
        if (vidaP2.vida <= 2)
        {
            P3animator_vida_2.SetBool("perdioUna", true);
        }
        if (vidaP2.vida <= 1)
        {
            P3animator_vida_1.SetBool("perdioMitad", true);
        }
        if (vidaP2.vida <= 0)
        {
            P3animator_vida_1.SetBool("perdioUna", true);
        }
    }

    //agrega un metodo que compruebe si ambos jugadores han perdido y si ambos perdieron te lleva a otra escena

    public void AmbosPerdieron()
    {
        if (vidaP1.vida <= 0 && vidaP2.vida <= 0)
        {
            SceneManager.LoadScene("EscenaVictoriaCazador");
        }
    }

    
}
