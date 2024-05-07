using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.AI;

public class VidaPlayer_1 : MonoBehaviour
{
    public int vida = 100;
    public int vidaMaxima = 100;

    public TextMeshProUGUI txtVida;

    public GameObject Perdiste_P1;

    public bool Moriste = false;
    private void Start()
    {
        vida = vidaMaxima;
    }
    private void Update()
    {
        Dead();
        txtVida.text = "Vida: " + vida.ToString();

        if (vida < 0)
        {
            vida = 0;
        }
    }
    public void TomarDano(int Dano)
    {
        vida -= Dano;   
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
