using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMovedisas : MonoBehaviour
{
    public Transform pointA; // Punto inicial
    public Transform pointB; // Punto final
    private bool moveToB = true; // Dirección del movimiento

    public float speed = 1.0f; // Velocidad de movimiento

    void Update()
    {
        if (moveToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
            if (transform.position == pointB.position)
                moveToB = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed * Time.deltaTime);
            if (transform.position == pointA.position)
                moveToB = true;
        }
    }
}
