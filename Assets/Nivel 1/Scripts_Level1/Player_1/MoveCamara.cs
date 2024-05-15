using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamara : MonoBehaviour
{
    public float speed = 5;
    public float minAngle = -30f; 
    public float maxAngle = 30f;  

    private void Update()
    {
        float angle = transform.localEulerAngles.x;  
        angle = (angle > 180) ? angle - 360 : angle;

       
        float rotationAmount = -Time.deltaTime * Input.GetAxis("Vertical_Cam_1") * speed; 

        float newAngle = Mathf.Clamp(angle + rotationAmount, minAngle, maxAngle);  

        transform.localEulerAngles = new Vector3(newAngle, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }
}
