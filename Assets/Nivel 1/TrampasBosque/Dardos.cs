// Dardos.cs
using UnityEngine;

public class Dardos : MonoBehaviour
{
    public float damage = 10f; // Da�o que el dardo aplicar� al jugador

    // Este m�todo se llama cuando el dardo colisiona con otro objeto
    void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que colision� tiene la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            // Obtiene el componente Player1Movement del objeto con el que colision�
            Player1Movement playerHealth = other.GetComponent<Player1Movement>();

            // Si encuentra el componente, aplica da�o
            if (playerHealth != null)
            {
                playerHealth.TakeDamage((int)damage);
            }

            // Destruye el dardo despu�s de golpear al jugador para que no pueda causar m�s da�o
            Destroy(gameObject);
        }
    }
}
