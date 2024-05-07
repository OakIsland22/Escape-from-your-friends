using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer_3 : MonoBehaviour
{
    public int vida = 100;
    public int vidaMaxima = 100;

    public GameObject Perdiste_P2;

    public bool Moriste = false;
    private void Start()
    {
        vida = vidaMaxima;
    }
    private void Update()
    {
        Dead();
    }
    public void Dano(int Dano)
    {
        vida -= Dano;
    }

    public void Dead()
    {
        if (vida == 0)
        {
            Perdiste_P2.gameObject.SetActive(true);
            Moriste = true;
        }
    }
}
