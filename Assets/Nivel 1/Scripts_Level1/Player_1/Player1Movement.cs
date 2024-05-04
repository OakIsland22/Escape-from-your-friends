using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI; // Necesario para trabajar con UI

public class Player1Movement : MonoBehaviour
{
    public float speedPlayer = 5f;
    public float rotationSpeed = 100f;
    public CharacterController player;
    public Animator animator;

    // Añade una variable para la salud del jugador
    public int health = 100;

    // Referencia al objeto de UI que contiene la pantalla de "Has muerto"
    public GameObject deathScreen;

    private void Update()
    {
        // Rotación horizontal
        float rotation = Input.GetAxis("Horizontal_P1") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Movimiento adelante y atrás
        float moveVertical = Input.GetAxis("Vertical_P1");
        Vector3 move = transform.forward * moveVertical;

        // Aplicar movimiento y gravedad
        move.y += Physics.gravity.y * Time.deltaTime;
        player.Move(move * speedPlayer * Time.deltaTime);

        // Verifica si la salud del jugador ha llegado a cero
        if (health <= 0)
        {
            Die();
        }
    }

    // Método para recibir daño
    public void TakeDamage(int damage)
    {
        health -= damage;
        // Aquí puedes añadir lógica para actualizar la UI de salud si tienes una
        if (health <= 0)
        {
            Die();
        }
    }

    // Método para "morir"
    void Die()
    {
        
        
        // Muestra la pantalla de "Has muerto"
        deathScreen.SetActive(true);
        // Aquí puedes añadir más lógica, como reiniciar el nivel o mostrar un menú de "Game Over"
        Debug.Log("me mori ");
    }
}
