using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartTrampa : MonoBehaviour
{
    public GameObject dartPrefab;
    public float shootInterval = 2f;
    public float dartLifetime = 5f; // Tiempo de vida del dardo en segundos
    private float shootTimer;

    void Update()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            ShootDart();
            shootTimer = 0f;
        }
    }

    void ShootDart()
    {
        // Instancia el dardo y añade fuerza para dispararlo
        GameObject dart = Instantiate(dartPrefab, transform.position, transform.rotation);
        Rigidbody rb = dart.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * 10f, ForceMode.Impulse);

        // Destruye el dardo después de 'dartLifetime' segundos
        Destroy(dart, dartLifetime);
    }

}
