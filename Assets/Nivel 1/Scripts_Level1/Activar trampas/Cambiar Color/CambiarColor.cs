using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{
    public Activar_trampa activar_Trampa;

    public bool cambiarColor = false;

    public Material[] colors; 
    private Renderer cubeRenderer; 
    private int currentColorIndex = 0; 

    private void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.material = colors[currentColorIndex]; 
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
