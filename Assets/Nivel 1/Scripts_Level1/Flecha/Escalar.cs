using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalar : MonoBehaviour
{
    public float minScale = 0.5f;
    public float maxScale = 2.0f;
    public float scaleSpeed = 1.0f;

    private float targetScale;
    private float currentScale;

    void Start()
    {
        currentScale = transform.localScale.x; // Asumimos que el scaleX y scaleY son iguales al inicio
    }

    void Update()
    {
        // Oscilar el targetScale entre minScale y maxScale
        float scaleRange = (maxScale - minScale) / 2.0f;
        targetScale = minScale + scaleRange * (1 + Mathf.Sin(Time.time * scaleSpeed));

        // Aplicar el escalamiento
        currentScale = Mathf.Lerp(currentScale, targetScale, Time.deltaTime * scaleSpeed);
        transform.localScale = new Vector3(currentScale, currentScale, transform.localScale.z);
    }
}
