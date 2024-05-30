using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartTrampa : MonoBehaviour
{
    public GameObject dartPrefab;
    public float shootInterval = 2f;
    public float dartLifetime = 5f; // Tiempo de vida del dardo en segundos
    private float shootTimer;

    public Activar_trampa activar_Trampa;

    void Update()
    {
        if (activar_Trampa.activarTrampa == true)
        {
            shootTimer += Time.deltaTime;
            if (shootTimer >= shootInterval)
            {
                ShootDart();
                shootTimer = 0f;
            }
        }
    }

    void ShootDart()
    {
        // Instancia el dardo y ajusta su rotación
        GameObject dart = Instantiate(dartPrefab, transform.position, transform.rotation);

        // Ajuste la rotación
        dart.transform.rotation = Quaternion.LookRotation(transform.forward) * Quaternion.Euler(0, 90, 0);

        // Añade fuerza para dispararlo
        Rigidbody rb = dart.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 10f, ForceMode.Impulse);

        // Destruye el dardo después de 'dartLifetime' segundos
        Destroy(dart, dartLifetime);
    }
}
