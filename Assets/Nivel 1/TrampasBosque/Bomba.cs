using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public GameObject[] wires; // Arreglo de los cables
    private int bombWireIndex; // �ndice del cable con la bomba

    void Start()
    {
        // Selecciona un cable al azar como el cable de la bomba
        bombWireIndex = Random.Range(0, wires.Length);
    }

    void Update()
    {
        // Suponiendo que el bot�n A es para cortar el cable
        if (Input.GetButtonDown("Cortar Bomba"))
        {
            CutWire(bombWireIndex); // Llama al m�todo CutWire con el �ndice del cable seleccionado
        }
    }

    // M�todo llamado cuando un cable es cortado
    public void CutWire(int index)
    {
        if (index == bombWireIndex)
        {
            // C�digo para desactivar la bomba
            Debug.Log("�Bomba desactivada!");
        }
        else
        {
            // C�digo para activar la explosi�n
            Debug.Log("�BOOM!");
        }
    }
}
