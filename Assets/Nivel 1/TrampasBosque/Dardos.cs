using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dardos : MonoBehaviour
{
    public float damage = 10f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            //if (playerHealth != null)
            //{
                //playerHealth.TakeDamage(damage);
            //}
            Destroy(gameObject); // Destruye el dardo después de golpear
        }
    }
}
