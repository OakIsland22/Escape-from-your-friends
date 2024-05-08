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
        if (EstaEnTrampa && Input.GetButtonDown("Activar_T"))
        {
            activarTrampa = true;
            Timer = 0; 
            TXTdardos.SetActive(false);
        }

        if (activarTrampa)
        {
            Timer += Time.deltaTime;
            if (Timer >= TiempoDesactivar)
            {
                activarTrampa = false; 
                Timer = 0; 
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
