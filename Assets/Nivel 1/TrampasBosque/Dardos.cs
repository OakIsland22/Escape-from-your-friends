// Dardos.cs
using UnityEngine;

public class Dardos : MonoBehaviour
{
    public float damage = 10f;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player1Movement playerHealth = other.GetComponent<Player1Movement>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage((int)damage);
            }
            Destroy(gameObject); // Destruye el dardo después de golpear
        }
    }
}
