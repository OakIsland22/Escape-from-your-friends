using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamara : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 50f;
    public float minYRotation = -50f;
    public float maxYRotation = 50f;
    public float minXRotation = -30f;
    public float maxXRotation = 30f;

    void Update()
    {
        //// Movimiento
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        //Vector3 moveDirection = new Vector3(moveHorizontal, moveVertical, 0f).normalized;
        //transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Rotación en X
        float rotateX = -Input.GetAxis("Vertical_Player1") * rotationSpeed * Time.deltaTime;
        float newRotationX = Mathf.Clamp(transform.eulerAngles.x + rotateX, minYRotation, maxYRotation);

        // Rotación en Y
        float rotateY = Input.GetAxis("Horizontal_Player1") * rotationSpeed * Time.deltaTime;
        float newRotationY = Mathf.Clamp(transform.eulerAngles.y + rotateY, minXRotation, maxXRotation);

        transform.rotation = Quaternion.Euler(newRotationX, newRotationY, 0f);
    }
}
