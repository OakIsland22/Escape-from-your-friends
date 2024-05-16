using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class aplastarJugador : MonoBehaviour
{
    public VidaPlayer_1 vida_P2;
    public VidaPlayer_3 vida_P3;

    public float DanoTrampa = 6;

    public bool estaEnTrampaP2 = false;
    public bool estaEnTrampaP3 = false;

    public Activar_trampa activar_Trampa;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player_2") && activar_Trampa == true)
        {
            estaEnTrampaP2 = true;
            DanoPlayer2();
        }

        if (other.gameObject.CompareTag("Player_3") && activar_Trampa == true)
        {
            estaEnTrampaP3 = true;
            DanoPlayer3();
        }
    }

    public void DanoPlayer2()
    {
        if(estaEnTrampaP2 == true)
        {
            vida_P2.TomarDano(DanoTrampa);
        }        
    }

    public void DanoPlayer3()
    {
        if (estaEnTrampaP3 == true)
        {
            vida_P3.TomarDano(DanoTrampa);
        }
    }
}
