using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    public Activar_trampa activar_Trampa;

    public bool cambiarColor = false;

    public Material[] colors; // Arreglo de materiales con los colores disponibles
    private Renderer cubeRenderer; // Referencia al componente Renderer del cubo
    private int currentColorIndex = 0; // Índice del color actual

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>(); // Obtener el componente Renderer del cubo
        cubeRenderer.material = colors[currentColorIndex]; // Establecer el color inicial del cubo
    }

    private void Update()
    {
        if(activar_Trampa.activarTrampa == true && cambiarColor == false)
        {
            cambiarelColor();
            cambiarColor = true;
        }
        if (activar_Trampa.activarTrampa == false && cambiarColor == true)
        {
            cambiarelColor();
            cambiarColor = false;
        }
    }

    private void cambiarelColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        cubeRenderer.material = colors[currentColorIndex];
    }
}
