using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamara : MonoBehaviour
{
    public float speed = 5;
    public float minAngle = -30f;  // Mínimo ángulo de rotación en grados
    public float maxAngle = 30f;   // Máximo ángulo de rotación en grados

    private void Update()
    {
        float angle = transform.localEulerAngles.x;  // Obtener el ángulo actual
        angle = (angle > 180) ? angle - 360 : angle; // Convertir ángulos mayores de 180 a negativos

        // Cambiar el signo para invertir el control
        float rotationAmount = -Time.deltaTime * Input.GetAxis("Vertical_Cam_1") * speed; // Cantidad de rotación invertida

        float newAngle = Mathf.Clamp(angle + rotationAmount, minAngle, maxAngle);  // Calcular nuevo ángulo limitado

        // Asignar el nuevo ángulo a la rotación en el eje X, manteniendo los otros ángulos
        transform.localEulerAngles = new Vector3(newAngle, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
