using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SueloFalso : MonoBehaviour
{
    // Variable para controlar la activación de la trampa
    public bool trampaActivada = false;

    // Referencia al componente Collider del suelo
    private Collider colliderDelSuelo;

    // Referencia al componente Renderer del suelo para hacerlo desaparecer
    private Renderer rendererDelSuelo;

    void Start()
    {
        // Inicializar las referencias
        colliderDelSuelo = GetComponent<Collider>();
        rendererDelSuelo = GetComponent<Renderer>();
    }

    void Update()
    {
        // Verificar si la trampa ha sido activada
        if (trampaActivada)
        {
            ActivarTrampa();
        }
    }

    void ActivarTrampa()
    {
        // Desactivar el collider para que los objetos caigan
        colliderDelSuelo.enabled = false;

        // Hacer desaparecer el suelo visualmente
        rendererDelSuelo.enabled = false;

        // Aquí puedes añadir más lógica, como reproducir un sonido o animación
    }

    // Método para activar la trampa desde otro script o evento
    public void Activar()
    {
        trampaActivada = true;
    }
}
