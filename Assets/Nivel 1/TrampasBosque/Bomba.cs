using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject[] wires; // Arreglo de los cables
    private int bombWireIndex; // Índice del cable con la bomba

    void Start()
    {
        // Selecciona un cable al azar como el cable de la bomba
        bombWireIndex = Random.Range(0, wires.Length);
    }

    void Update()
    {
        // Suponiendo que el botón A es para cortar el cable
        if (Input.GetButtonDown("Cortar Bomba"))
        {
            CutWire(bombWireIndex); // Llama al método CutWire con el índice del cable seleccionado
        }
    }

    // Método llamado cuando un cable es cortado
    public void CutWire(int index)
    {
        if (index == bombWireIndex)
        {
            // Código para desactivar la bomba
            Debug.Log("¡Bomba desactivada!");
        }
        else
        {
            // Código para activar la explosión
            Debug.Log("¡BOOM!");
        }
    }
}
