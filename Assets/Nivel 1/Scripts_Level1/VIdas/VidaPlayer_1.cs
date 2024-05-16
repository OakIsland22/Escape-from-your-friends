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

    //Vidas Completas
    public GameObject Vida_1;
    public GameObject Vida_2;
    public GameObject Vida_3;

    //Vidas Mitad
    public GameObject Vida_Mitad_1;
    public GameObject Vida_Mitad_2;
    public GameObject Vida_Mitad_3;

    //Vidas Vacias
    public GameObject Vida_Vacia_1;
    public GameObject Vida_Vacia_2;
    public GameObject Vida_Vacia_3;

    public GameObject Perdiste_P1;

    public bool Moriste = false;
    private void Start()
    {
        vida = vidaMaxima;
    }
    private void Update()
    {
        Dead();

        if(vida == 6)
        {
            todasActivas();
        }
        else if(vida == 5)
        {
            primerMitad();
        }
        else if (vida == 4)
        {
            SinUnaVida();
        }
        else if (vida == 3)
        {
            SegundaMitad();
        }
        else if (vida == 2)
        {
            SinDosVida();
        }
        else if (vida == 1)
        {
            TercerMitad();
        }
        else if (vida == 0)
        {
            SinTresVida();
            todasDes();
        }


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

    private void todasActivas()
    {
        Vida_1.gameObject.SetActive(true);
        Vida_2.gameObject.SetActive(true);
        Vida_3.gameObject.SetActive(true);
    }

    private void todasDes()
    {
        Vida_1.gameObject.SetActive(false);
        Vida_2.gameObject.SetActive(false);
        Vida_3.gameObject.SetActive(false);
    }

    private void primerMitad()
    {
        Vida_3.gameObject.SetActive(false);
        Vida_Mitad_3.gameObject.SetActive(true);
    }
    private void SinUnaVida()
    {
        Vida_Mitad_3.gameObject.SetActive(false);
        Vida_Vacia_3.gameObject.SetActive(true);
    }

    private void SegundaMitad()
    {
        Vida_2.gameObject.SetActive(false);
        Vida_Mitad_2.gameObject.SetActive(true);
    }
    private void SinDosVida()
    {
        Vida_Mitad_2.gameObject.SetActive(false);
        Vida_Vacia_2.gameObject.SetActive(true);
    }

    private void TercerMitad()
    {
        Vida_1.gameObject.SetActive(false);
        Vida_Mitad_1.gameObject.SetActive(true);
    }
    private void SinTresVida()
    {
        Vida_Mitad_1.gameObject.SetActive(false);
        Vida_Vacia_1.gameObject.SetActive(true);
    }
}
