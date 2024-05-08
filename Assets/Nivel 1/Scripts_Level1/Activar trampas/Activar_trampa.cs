using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_trampa : MonoBehaviour
{
    public bool activarTrampa = false;
    public bool EstaEnTrampa = false;

    public GameObject TXTdardos;

    private float Timer = 0;
    public float TiempoDesactivar = 2;

    private void Update()
    {
        // Verificar si el bot�n de activar la trampa es presionado mientras el jugador est� dentro de la trampa
        if (EstaEnTrampa && Input.GetButtonDown("Activar_T"))
        {
            activarTrampa = true;
            Timer = 0; // Reseteamos el temporizador al activar la trampa
            TXTdardos.SetActive(false);
        }

        // Si la trampa est� activada, incrementar el temporizador
        if (activarTrampa)
        {
            Timer += Time.deltaTime;
            if (Timer >= TiempoDesactivar)
            {
                activarTrampa = false; // Desactivar la trampa despu�s de que el tiempo se agote
                Timer = 0; // Reseteamos el temporizador despu�s de desactivar la trampa
                TXTdardos.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        TXTdardos.SetActive(true);
        EstaEnTrampa = true;
    }

    private void OnTriggerExit(Collider other)
    {
        TXTdardos.SetActive(false);
        EstaEnTrampa = false;
    }
}
