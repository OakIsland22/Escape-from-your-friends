using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2Junp : MonoBehaviour
{
    public CharacterController controller;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Asegura que esté pegado al suelo
        }

        if (Input.GetButtonDown("Jump_P2") && isGrounded)
        {
            Debug.Log("Salto2");
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
