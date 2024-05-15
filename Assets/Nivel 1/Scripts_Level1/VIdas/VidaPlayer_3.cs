using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VidaPlayer_3 : MonoBehaviour
{
    public float vida = 100;
    public int vidaMaxima = 100;
    public TextMeshProUGUI txtVida;

    public GameObject Perdiste_P2;

    public bool Moriste = false;
    private void Start()
    {
        vida = vidaMaxima;
    }
    private void Update()
    {
        Dead();
        txtVida.text = "Vida: " + vida.ToString();

        if(vida < 0)
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
        if (vida == 0)
        {
            Perdiste_P2.gameObject.SetActive(true);
            Moriste = true;
        }
    }
}
