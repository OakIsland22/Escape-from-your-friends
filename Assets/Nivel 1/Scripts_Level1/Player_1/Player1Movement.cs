using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI; // Necesario para trabajar con UI

public class Player1Movement : MonoBehaviour
{
    public float speedPlayer = 5f;
    public float rotationSpeed = 100f;
    public CharacterController player;
    public Animator animator;

    // A�ade una variable para la salud del jugador
    public int health = 100;

    // Referencia al objeto de UI que contiene la pantalla de "Has muerto"
    public GameObject deathScreen;

    private void Update()
    {
        // Rotaci�n horizontal
        float rotation = Input.GetAxis("Horizontal_P1") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Movimiento adelante y atr�s
        float moveVertical = Input.GetAxis("Vertical_P1");
        Vector3 move = transform.forward * moveVertical;

        // Movimiento lateral (strafe) de izquierda a derecha
        float moveHorizontal = Input.GetAxis("Horizontal_Player1");
        Vector3 strafe = transform.right * moveHorizontal;

        // Aplicar movimiento y gravedad
        move.y += Physics.gravity.y * Time.deltaTime;
        player.Move((move + strafe) * speedPlayer * Time.deltaTime);
        // Aplicar movimiento y gravedad
        move.y += Physics.gravity.y * Time.deltaTime;
        player.Move(move * speedPlayer * Time.deltaTime);

        // Verifica si la salud del jugador ha llegado a cero
        if (health <= 0)
        {
            Die();
        }

    }

    // M�todo para recibir da�o
    public void TakeDamage(int damage)
    {
        health -= damage;
        // Aqu� puedes a�adir l�gica para actualizar la UI de salud si tienes una
        if (health <= 0)
        {
            Die();
        }
    }

    // M�todo para "morir"
    void Die()
    {
        deathScreen.SetActive(true);
        // Aqu� puedes a�adir l�gica para desactivar el control del jugador si es necesario
    }

    // M�todo para detectar colisi�n con dardos
    private void OnTriggerEnter(Collider other)
    {
        // Aseg�rate de que el objeto con el que colisiona tenga una etiqueta "Dart"
        if (other.CompareTag("Dart"))
        {
            // Aqu� puedes ajustar la cantidad de da�o
            TakeDamage(50);
        }
    }
}
