using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Player_1 : MonoBehaviour
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
            velocity.y = -2f; // Asegura que est� pegado al suelo
        }

        if (Input.GetButtonDown("Jump_P1") && isGrounded)
        {
            Debug.Log("Salto1");
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
