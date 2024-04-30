using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Movement : MonoBehaviour
{
    public float speedPlayer = 5f;
    public float rotationSpeed = 100f;
    public CharacterController player;

    public Animator animator;

    private void Update()
    {
        // Rotación horizontal
        float rotation = Input.GetAxis("Horizontal_P2") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);

        // Movimiento adelante y atrás
        float moveVertical = Input.GetAxis("Vertical_P2");
        Vector3 move = transform.forward * moveVertical;


        // Aplicar movimiento y gravedad
        move.y += Physics.gravity.y * Time.deltaTime;
        player.Move(move * speedPlayer * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        // animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Vertical")));
    }
}
