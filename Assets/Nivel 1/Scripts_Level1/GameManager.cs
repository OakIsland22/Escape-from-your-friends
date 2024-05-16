using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator animator_vida_1;
    public Animator animator_vida_2;
    public Animator animator_vida_3;

    public VidaPlayer_1 vidaP1;
    private void FixedUpdate()
    {
        if (vidaP1.vida <= 5)
        {
            animator_vida_3.SetBool("perdioMitad", true);
        }
        if(vidaP1.vida <= 4)
        {
            animator_vida_3.SetBool("perdioUna", true);
        }
        if(vidaP1.vida <= 3)
        {
            animator_vida_2.SetBool("perdioMitad", true);
        }
        if (vidaP1.vida <= 2)
        {
            animator_vida_2.SetBool("perdioUna", true);
        }        
        if(vidaP1.vida <= 1)
        {
            animator_vida_1.SetBool("perdioMitad", true);
        }
        if(vidaP1.vida <= 0)
        {
            animator_vida_1.SetBool("perdioUna", true);
        }
    }
}
