using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Movement : MonoBehaviour
{
    public float speedPlayer = 5f;
    public float rotationSpeed = 100f;
    public CharacterController player;

    public Animator animator;

    public VidaPlayer_1 player_1;
    private void Update()
    {
        if(player_1.Moriste == false)
        {
            // Rotaci�n horizontal
            float rotation = Input.GetAxis("Horizontal_P2") * rotationSpeed * Time.deltaTime;
            transform.Rotate(0, rotation, 0);

            // Movimiento adelante y atr�s
            float moveVertical = Input.GetAxis("Vertical_P2");
            Vector3 move = transform.forward * moveVertical;


            //// Aplicar movimiento y gravedad
            //move.y += Physics.gravity.y * Time.deltaTime;
            //player.Move(move * speedPlayer * Time.deltaTime);

            // Movimiento lateral (strafe) de izquierda a derecha
            float moveHorizontal = Input.GetAxis("Horizontal_Player2");
            Vector3 strafe = transform.right * moveHorizontal;

            // Aplicar movimiento y gravedad
            move.y += Physics.gravity.y * Time.deltaTime;
            player.Move((move + strafe) * speedPlayer * Time.deltaTime);
        }
    }
    private void FixedUpdate()
    {
        // animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Vertical")));
    }
}
