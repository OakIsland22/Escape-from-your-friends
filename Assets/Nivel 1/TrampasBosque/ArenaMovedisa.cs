using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArenaMovedisa : MonoBehaviour
{
    public float danoTrampa = 1;
    public float intervaloDano = 1.0f; 

    public VidaPlayer_1 vidaP2;
    public VidaPlayer_3 vidaP3;

    public Player_2_Movement movement2;
    public Player_3_Move movement3;

    public float detenerPlayer = 1f;

    private float moveInicial_1;
    private float moveInicial_2;
    private float timerP2;
    private float timerP3;
    private bool isPlayer2Inside;
    private bool isPlayer3Inside;


    public Activar_trampa activar_trampa;
    private void Start()
    {
        moveInicial_1 = movement2.speedPlayer;
        moveInicial_2 = movement3.speedPlayer;
        timerP2 = 0f;
        timerP3 = 0f;
    }

    private void Update()
    {
        if(activar_trampa.activarTrampa == true)
        {
            if (isPlayer2Inside)
            {
                timerP2 += Time.deltaTime;
                if (timerP2 >= intervaloDano)
                {
                    vidaP2.vida -= danoTrampa;
                    timerP2 = 0f;
                }
            }

            if (isPlayer3Inside)
            {
                timerP3 += Time.deltaTime;
                if (timerP3 >= intervaloDano)
                {
                    vidaP3.vida -= danoTrampa;
                    timerP3 = 0f;
                }
            }
        }        
    }

    private void OnTriggerEnter(Collider other)
    {        
        if (other.CompareTag("Player_2"))
        {
            isPlayer2Inside = true;
            movement2.speedPlayer -= detenerPlayer;            
        }
        else if (other.CompareTag("Player_3"))
        {
            isPlayer3Inside = true;
            movement3.speedPlayer -= detenerPlayer;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player_2"))
        {
            movement2.speedPlayer = moveInicial_1;
            isPlayer2Inside = false;
            timerP2 = 0f; // Reset timer
        }
        else if (other.CompareTag("Player_3"))
        {
            movement3.speedPlayer = moveInicial_2;
            isPlayer3Inside = false;
            timerP3 = 0f; // Reset timer
        }
    }
}