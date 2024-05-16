using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.AI;

public class VidaPlayer_1 : MonoBehaviour
{
    public float vida;
    public int vidaMaxima = 6;
    
    public GameObject Perdiste_P1;

    public bool Moriste = false;

    private void Start()
    {
        vida = vidaMaxima;
    }
    private void Update()
    {
        Dead();

        if (vida < 0)
        {
            vida = 0;
        }
    }
    public void TomarDano(float dano)
    {
        vida -= dano; 
        Debug.Log("jugador2recibedaño");
    }

    public void Dead()
    {
        if(vida == 0)
        {
            Perdiste_P1.gameObject.SetActive(true);
            Moriste = true;
        }
    }
}
