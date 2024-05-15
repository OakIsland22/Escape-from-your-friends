using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamara : MonoBehaviour
{
    public float speed = 5;
    public float minAngle = -30f;  // M�nimo �ngulo de rotaci�n en grados
    public float maxAngle = 30f;   // M�ximo �ngulo de rotaci�n en grados

    private void Update()
    {
        float angle = transform.localEulerAngles.x;  // Obtener el �ngulo actual
        angle = (angle > 180) ? angle - 360 : angle; // Convertir �ngulos mayores de 180 a negativos

        // Cambiar el signo para invertir el control
        float rotationAmount = -Time.deltaTime * Input.GetAxis("Vertical_Cam_1") * speed; // Cantidad de rotaci�n invertida

        float newAngle = Mathf.Clamp(angle + rotationAmount, minAngle, maxAngle);  // Calcular nuevo �ngulo limitado

        // Asignar el nuevo �ngulo a la rotaci�n en el eje X, manteniendo los otros �ngulos
        transform.localEulerAngles = new Vector3(newAngle, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
