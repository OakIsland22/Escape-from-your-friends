using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_3_Move : MonoBehaviour
{
    public float speedPlayer = 5f;
    public float rotationSpeed = 100f;
    public CharacterController player;

    public Animator animator;


    public VidaPlayer_3 Vida_P3;
    private void Update()
    {
        if(Vida_P3.Moriste == false)
        {
            // Rotaci�n horizontal
            float rotation = Input.GetAxis("Horizontal_P3") * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, rotation, 0);

            // Movimiento adelante y atr�s
            float moveVertical = Input.GetAxis("Vertical_P3");
            Vector3 move = transform.forward * moveVertical;


            //// Aplicar movimiento y gravedad
            //move.y += Physics.gravity.y * Time.deltaTime;
            //player.Move(move * speedPlayer * Time.deltaTime);

            // Movimiento lateral (strafe) de izquierda a derecha
            float moveHorizontal = Input.GetAxis("Horizontal_Player3");
            Vector3 strafe = transform.right * moveHorizontal;

            // Aplicar movimiento y gravedad
            move.y += Physics.gravity.y * Time.deltaTime;
            player.Move((move + strafe) * speedPlayer * Time.deltaTime);
        }        
    }
    private void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical_P3");
        float moveHorizontal = Input.GetAxis("Horizontal_Player3");

        if (Mathf.Abs(moveVertical) > Mathf.Abs(moveHorizontal))
        {
            if (moveVertical > 0)
            {
                animator.SetFloat("speed", Mathf.Abs(moveVertical)); // Corriendo hacia adelante
                animator.SetBool("isRunningBack", false);
                animator.SetBool("isRunningLeft", false);
                animator.SetBool("isRunningRight", false);
            }
            else if (moveVertical < 0)
            {
                animator.SetFloat("speed", Mathf.Abs(moveVertical)); // Corriendo hacia atr�s
                animator.SetBool("isRunningBack", true);
                animator.SetBool("isRunningLeft", false);
                animator.SetBool("isRunningRight", false);
            }
        }
        else
        {
            if (moveHorizontal > 0)
            {
                animator.SetFloat("speed", Mathf.Abs(moveHorizontal)); // Corriendo hacia la derecha
                animator.SetBool("isRunningBack", false);
                animator.SetBool("isRunningLeft", false);
                animator.SetBool("isRunningRight", true);
            }
            else if (moveHorizontal < 0)
            {
                animator.SetFloat("speed", Mathf.Abs(moveHorizontal)); // Corriendo hacia la izquierda
                animator.SetBool("isRunningBack", false);
                animator.SetBool("isRunningLeft", true);
                animator.SetBool("isRunningRight", false);
            }
            else
            {
                animator.SetFloat("speed", 0);
                animator.SetBool("isRunningBack", false);
                animator.SetBool("isRunningLeft", false);
                animator.SetBool("isRunningRight", false);
            }
        }
    }
}
