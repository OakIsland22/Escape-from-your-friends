using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI; // Necesario para trabajar con UI

public class Player1Movement : MonoBehaviour
{
    public float speedPlayer = 5f;
    public float rotationSpeed = 100f;
    public CharacterController player;
    public Animator animator;

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

        //// Aplicar movimiento y gravedad
        //move.y += Physics.gravity.y * Time.deltaTime;
        //player.Move(move * speedPlayer * Time.deltaTime);

    }
}
