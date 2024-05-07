// Dardos.cs
using UnityEngine;

public class Dardos : MonoBehaviour
{
    public float damage = 10f; // Daño que el dardo aplicará al jugador

    // Este método se llama cuando el dardo colisiona con otro objeto
    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que colisionó tiene la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            // Obtiene el componente Player1Movement del objeto con el que colisionó
            Player1Movement playerHealth = other.GetComponent<Player1Movement>();

            // Si encuentra el componente, aplica daño
            if (playerHealth != null)
            {
                playerHealth.TakeDamage((int)damage);
            }

            // Destruye el dardo después de golpear al jugador para que no pueda causar más daño
            Destroy(gameObject);
        }
    }
}
